
void createColorMask() {
    // create hsv limits that matches only balls
    Hsv Lower = new Hsv( HueMin , SaturatinoMin , ValueMin);
    Hsv Upper = new Hsv( HueMax , SaturatinoMax , ValueMax);

    // convert rba color image from kinect to hsv color space
    Image<Hsv,Byte> hsvImage = colorImageFromKinect.Convert<Hsv, byte>();

    // apply limits
    Image<Gray,byte> colorMask  = hsvImage.InRange(Upper,Lower);

    // remove noise, make important regions more sagnificant
    colorMask = colorMask.Erode(ERODE_ITER_HSV_COLOR);
    colorMask = colorMask.Dilate(DILATE_ITER_HSV_MASK);
}

