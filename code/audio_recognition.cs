

void audioWroker() { // Kinect audio is in the separated thread

    SpeechRecognizer = new SpeechRecognitionEngine(recognizerInfo.Id);

    // Load grammar
    var gb = new GrammarBuilder { Culture = recognizerInfo.Culture };
    var choices = new Choices();
    choices.Add("start game");
    gb.Append(choices);
    SpeechRecognizer.LoadGrammar(new Grammar(gb));

    // Prepare events
    SpeechRecognizer.SpeechRecognized += (e,v) => {
        Console.WriteLine( "Recognized audio command: " + e.Result.Text);
        if( e.Result.Text == "start game" ) startGame(); 
    };
    SpeechRecognizer.SpeechHypothesized += (e,v) => {
        Console.WriteLine( "Hypothetical recognized audio command: " + e.Result.Text);
        Console.WriteLine( "confidence: " e.Result.Confidence);
         if( e.Result.Text == "start game"  && e.Result.Confidence > 0.6F  ) {
             startGame();
         } 
    };
    SpeechRecognizer.SpeechRecognitionRejected += (e,v) => {
        Console.WriteLine( "Rejected voice command: " + e.Result.Text);
    };;

    //set sensor audio source to variable
    KinectAudioSource audioSource = Sensor.AudioSource;
    audioSource.BeamAngleMode = BeamAngleMode.Adaptive;
    
    // enable kinect audio
    Stream kinectStream = audioSource.Start();
    
    // set to recognizer kinect audio stream
    SpeechRecognizer.SetInputToAudioStream(
        kinectStream, new SpeechAudioFormatInfo(EncodingFormat.Pcm, 16000, 16, 1, 32000, 2, null));
    
    // be ready for multiple recognitions
    SpeechRecognizer.RecognizeAsync(RecognizeMode.Multiple);

    //reduce background and ambient noise for better accuracy
    Sensor.AudioSource.EchoCancellationMode = EchoCancellationMode.CancellationAndSuppression;
    Sensor.AudioSource.AutomaticGainControlEnabled = true;
}

