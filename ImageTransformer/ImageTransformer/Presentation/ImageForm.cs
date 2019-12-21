using ImageTransformer.Business;
using ImageTransformer.IOFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTransformer
{
    public partial class ImageForm : Form
    {
        private GetAndSaveImage gsi;
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;

        public ImageForm()
        {
            gsi = new GetAndSaveImage();
            InitializeComponent();
        }

        //SECTION 1 (BROWSE IMAGE)
        private void button_click_Browse(object sender, EventArgs e)
        {
            //Browse image and set picture box with result
            originalBitmap = gsi.getImage();
            previewBitmap = originalBitmap;

            originalBox.Image = originalBitmap;
            previewBox.Image = originalBitmap;

            checkBoxBlackWhite.Checked = false;
            checkBoxRainbow.Checked = false;
            checkBoxSwap.Checked = false;

            radioButtonKirsh.Checked = false;
            radioButtonPrewitt.Checked = false;

            adjustSizePictureBox();
        }


        //SECTION 2 (SELECT FILTER)
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            int cbBW = checkBoxBlackWhite.Checked ? 1 : 0;
            int cbR = checkBoxRainbow.Checked ? 1 : 0;
            int cbS = checkBoxSwap.Checked ? 1 : 0;

            String toCheck = String.Concat(cbBW, cbR, cbS);
            
            switch (toCheck)
            {
                case "100":
                    //Only BlackWhite
                    previewBitmap = FilterBLL.BlackWhite(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                case "010":
                    //Only Rainbow
                    previewBitmap = FilterBLL.RainbowFilter(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                case "001":
                    //Only Swap
                    previewBitmap = FilterBLL.Swap(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                case "110":
                    //BlackWhite then Rainbow
                    previewBitmap = FilterBLL.BlackWhite(previewBitmap);
                    previewBitmap = FilterBLL.RainbowFilter(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                case "101":
                    //BlackWhite then Swap
                    previewBitmap = FilterBLL.BlackWhite(previewBitmap);
                    previewBitmap = FilterBLL.Swap(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                case "011":
                    previewBitmap = FilterBLL.RainbowFilter(previewBitmap);
                    previewBitmap = FilterBLL.Swap(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                case "111":
                    previewBitmap = FilterBLL.BlackWhite(previewBitmap);
                    previewBitmap = FilterBLL.RainbowFilter(previewBitmap);
                    previewBitmap = FilterBLL.Swap(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                default :
                    Console.WriteLine(toCheck);
                    previewBitmap = originalBitmap;
                    previewBox.Image = originalBitmap;
                    break;

            }

            resultBitmap = previewBitmap;
            adjustSizePictureBox();

        }

        //SECTION 3 (SELECT EDGE DETECTION)
        private void radioButtonKirsh_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKirsh.Checked)
            {
                resultBitmap = EdgeDetectionBLL.KirschFilter(previewBitmap);
                previewBox.Image = resultBitmap;
            }
            else
            {
                resultBitmap = EdgeDetectionBLL.PrewittFilter(previewBitmap);
                previewBox.Image = resultBitmap;
            }
            adjustSizePictureBox();
        }

        //SECTION 4 (SAVE IMAGE)

        //SECTION 5 (SAVE IMAGE)

        private void button_click_Save(object sender, EventArgs e)
        {
            gsi.saveImage(resultBitmap);
        }

        //CROSS SECTION METHOD
        private void adjustSizePictureBox() 
        {
            var imageSize = previewBox.Image.Size;
            var fitSize = previewBox.ClientSize;
            previewBox.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;

            //Center image into originalBox
            originalBox.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

    }
}
