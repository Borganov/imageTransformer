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
        

        public Bitmap getImage(IInputOutput iio)
        {
            return iio.getImage();
        }


        public void saveImage(Bitmap img, IInputOutput iio)
        {
            try
            {
                iio.saveImage(img);
            }
            catch(Exception e)
            {
                throw;
            }
            
        }
    }
}
