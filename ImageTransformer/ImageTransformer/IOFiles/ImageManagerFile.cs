using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTransformer.IOFiles
{
    class ImageManagerFile : IInputOutput
    {
        public Bitmap getImage()
        {
            Bitmap result = null;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                result = (Bitmap)Image.FromStream(streamReader.BaseStream);
                streamReader.Close();
            }

            return result;
        }

        public void saveImage(Bitmap image)
        {
            if (image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = null;
                    switch (fileExtension)
                    {
                        case "PNG":
                            imgFormat = ImageFormat.Png;
                            break;
                        case "JPG":
                            imgFormat = ImageFormat.Jpeg;
                            break;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    image.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                }

            }


        }

    }
}
