﻿using ImageTransformer.Business;
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
        private Bitmap test = null;

        public ImageForm()
        {
            gsi = new GetAndSaveImage();
            InitializeComponent();
            showSections2(false);
            showSections3(false);
            showSections4(false);
        }

        //SECTION 1 (BROWSE IMAGE)
        private void button_click_Browse(object sender, EventArgs e)
        {
            //Browse image and set picture box with result
            ImageManagerFile imf = new ImageManagerFile();
            originalBitmap = gsi.getImage(imf);

            //If cancel selection halt method
            if(originalBitmap == null)
            {
                return;
            }

            previewBitmap = originalBitmap;
            test = originalBitmap;

            originalBox.Image = originalBitmap;
            previewBox.Image = originalBitmap;

            checkBoxSwapDivide.Checked = false;
            checkBoxRainbow.Checked = false;
            checkBoxSwap.Checked = false;

            radioButtonKirsh.Checked = false;
            radioButtonPrewitt.Checked = false;

            adjustSizePictureBox();
            showSections2(true);
            
        }


        //SECTION 2 (SELECT FILTER)
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            int cbBW = checkBoxSwapDivide.Checked ? 1 : 0;
            int cbR = checkBoxRainbow.Checked ? 1 : 0;
            int cbS = checkBoxSwap.Checked ? 1 : 0;

            String toCheck = String.Concat(cbBW, cbR, cbS);
            if (toCheck == "000")
            {
                showSections3(false);
                showSections4(false);
            }
            else
            {
                showSections3(true);
                showSections4(true);
            }

            switch (toCheck)
            {
                case "100":
                    //Only Swap Divide
                    previewBitmap = FilterBLL.SwapDivide(previewBitmap,1,1,2,1);
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
                    previewBitmap = FilterBLL.SwapDivide(previewBitmap, 1, 1, 2, 1);
                    previewBitmap = FilterBLL.RainbowFilter(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                case "101":
                    //BlackWhite then Swap
                    previewBitmap = FilterBLL.SwapDivide(previewBitmap, 1, 1, 2, 1);
                    previewBitmap = FilterBLL.Swap(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                case "011":
                    previewBitmap = FilterBLL.RainbowFilter(previewBitmap);
                    previewBitmap = FilterBLL.Swap(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                case "111":
                    previewBitmap = FilterBLL.SwapDivide(previewBitmap, 1, 1, 2, 1);
                    previewBitmap = FilterBLL.RainbowFilter(previewBitmap);
                    previewBitmap = FilterBLL.Swap(previewBitmap);
                    previewBox.Image = previewBitmap;
                    break;

                default:

                    previewBox.Refresh();
                    previewBitmap = test;
                    previewBox.Image = test;

                    break;

            }


            resultBitmap = previewBitmap;
            adjustSizePictureBox();
        }

        //SECTION 3 (SELECT EDGE DETECTION)
        private void radioButtonKirsh_CheckedChanged(object sender, EventArgs e)
        {
            applyEdgeDetection();
        }

        private void radioButtonPrewitt_CheckedChanged(object sender, EventArgs e)
        {
            applyEdgeDetection();
        }

        private void radioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            applyEdgeDetection();
        }

        private void applyEdgeDetection()
        {
            if (radioButtonKirsh.Checked)
            {
                resultBitmap = EdgeDetectionBLL.KirschFilter(previewBitmap);
                previewBox.Image = resultBitmap;
            }
            else if (radioButtonPrewitt.Checked)
            {
                resultBitmap = EdgeDetectionBLL.PrewittFilter(previewBitmap);
                previewBox.Image = resultBitmap;
            }
            else
            {
                resultBitmap = previewBitmap;
                previewBox.Image = resultBitmap;
            }
            adjustSizePictureBox();
        }

        //SECTION 4 (SAVE IMAGE)

        private void button_click_Save(object sender, EventArgs e)
        {
            //Save image
            ImageManagerFile imf = new ImageManagerFile();
            gsi.saveImage(resultBitmap,imf);
        }

        //CROSS SECTION METHOD
        private void adjustSizePictureBox() 
        {
            if(previewBox != null && previewBox.Image != null)
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

        // if no image has been selected, disable section 2, 3 and 4
        public void showSections2(Boolean condition)
        {
                if(condition)
                {
                    checkBoxSwapDivide.Enabled = true;
                    checkBoxRainbow.Enabled = true;
                    checkBoxSwap.Enabled = true;
                }
                else
                {
                    checkBoxSwapDivide.Checked = false;
                    checkBoxRainbow.Checked = false;
                    checkBoxSwap.Checked = false;

                    checkBoxSwapDivide.Enabled = false;
                    checkBoxRainbow.Enabled = false;
                    checkBoxSwap.Enabled = false;
                }
        }

        public void showSections3(Boolean condition)
        {
            if (condition)
            {
                radioButtonKirsh.Enabled = true;
                radioButtonPrewitt.Enabled = true;
                radioButtonNone.Enabled = true;
                radioButtonNone.Checked = true;
            }
            else
            {
                radioButtonKirsh.Checked = false;
                radioButtonPrewitt.Checked = false;
                radioButtonNone.Checked = true;
                
                radioButtonKirsh.Enabled = false;
                radioButtonPrewitt.Enabled = false;
                radioButtonNone.Enabled = false;

                
            }
        }

        public void showSections4(Boolean condition)
        {
            if (condition)
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;

            }
        }


    }
}
