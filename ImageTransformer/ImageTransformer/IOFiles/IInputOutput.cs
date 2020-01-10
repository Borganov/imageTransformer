using System.Drawing;

namespace ImageTransformer.IOFiles
{
    public interface IInputOutput
    {
        Bitmap getImage();

        void saveImage(Bitmap image);

    }
}
