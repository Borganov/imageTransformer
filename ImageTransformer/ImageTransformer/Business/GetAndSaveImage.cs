using ImageTransformer.IOFiles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTransformer.Business
{
    public class GetAndSaveImage
    {
        private ImageManagerFile imf;

        public Bitmap getImage()
        {
            imf = new ImageManagerFile();
            return imf.getImage();
        }


        public void saveImage(Bitmap img)
        {
            imf = new ImageManagerFile();
            imf.saveImage(img);
        }
    }
}
