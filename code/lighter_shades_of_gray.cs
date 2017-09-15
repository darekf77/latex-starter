private void CreateLighterShadesOfGray(DepthImageFrame depthFrame , short[] pixelData)
{
    int depth;
    int loThreshold = 1220;
    int hiThreshold = 3048;
    short[] enhPixelData = new short[depthFrame.Width * depthFrame.Height];
    for(int i = 0; i < pixelData.Length; i++)
    {
        depth = pixelData[i] >> DepthImageFrame.PlayerIndexBitmaskWidth;
        if(depth < loThreshold || depth > hiThreshold)
        {
            enhPixelData [i] = 0xFF;
        } else
        {
            enhPixelData [i] = (short) ~pixelData[i];
        }
    }
    EnhancedDepthImage.Source = BitmapSource
        .Create(depthFrame.Width, depthFrame.Height,
            96, 96,
            PixelFormats.Gray16, null,
            enhPixelData,
            depthFrame.Width * depthFrame.BytesPerPixel);
}