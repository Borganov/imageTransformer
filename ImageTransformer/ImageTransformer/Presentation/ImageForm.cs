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
        ImageManagerFile imf;

        public ImageForm()
        {
            imf = new ImageManagerFile();
            InitializeComponent();
        }

        private void button_click_Browse(object sender, EventArgs e)
        {
            //Browse image and set picture box with result
            pictureBox.Image = imf.getImage();

            //Center image into picutrebox
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button_click_Save(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox.Image);
            imf.saveImage(bm);
        }
    }
}
