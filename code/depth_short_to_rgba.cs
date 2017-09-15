int colorPixelIndex = 0;
var pixelsDepthDataLength = 4 * _frame.Depth.Length;
if (depthBytes == null) depthBytes = new byte[pixelsDepthDataLength];
for (int i = 0; i < _frame.Depth.Length; ++i)
{
    byte intensity = (byte)(_frame.Depth[i] >= MinDepth
        && _frame.Depth[i] <= MaxDepth ? 255 : 0);
    depthBytes[colorPixelIndex++] = intensity;
    depthBytes[colorPixelIndex++] = intensity;
    depthBytes[colorPixelIndex++] = intensity;
    ++colorPixelIndex;
}