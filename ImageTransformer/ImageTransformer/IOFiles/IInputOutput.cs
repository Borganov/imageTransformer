using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTransformer.IOFiles
{
    public interface IInputOutput
    {
        Bitmap getImage();

        void saveImage(Bitmap image);

    }
}
