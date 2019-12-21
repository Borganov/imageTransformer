using System;

namespace ImageTransformer
{
    partial class ImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalBox = new System.Windows.Forms.PictureBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.labelApplyFilter = new System.Windows.Forms.Label();
            this.labelApplyDetection = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.labelSelectResult = new System.Windows.Forms.Label();
            this.checkBoxRainbow = new System.Windows.Forms.CheckBox();
            this.checkBoxBlackWhite = new System.Windows.Forms.CheckBox();
            this.checkBoxSwap = new System.Windows.Forms.CheckBox();
            this.labelFilterMessage = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.radioButtonPrewitt = new System.Windows.Forms.RadioButton();
            this.radioButtonKirsh = new System.Windows.Forms.RadioButton();
            this.labelEdgeDetectionMessage = new System.Windows.Forms.Label();
            this.labelSaveMessage = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.labelOriginalPicture = new System.Windows.Forms.Label();
            this.labelPreviewImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalBox
            // 
            this.originalBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.originalBox.Location = new System.Drawing.Point(12, 36);
            this.originalBox.Name = "originalBox";
            this.originalBox.Size = new System.Drawing.Size(700, 350);
            this.originalBox.TabIndex = 0;
            this.originalBox.TabStop = false;
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.labelSelect.Location = new System.Drawing.Point(741, 37);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(165, 24);
            this.labelSelect.TabIndex = 1;
            this.labelSelect.Text = "1. Select a picture";
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonSelectImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSelectImage.FlatAppearance.BorderSize = 0;
            this.buttonSelectImage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectImage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSelectImage.Location = new System.Drawing.Point(764, 64);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(142, 34);
            this.buttonSelectImage.TabIndex = 2;
            this.buttonSelectImage.Text = "Browse";
            this.buttonSelectImage.UseVisualStyleBackColor = false;
            this.buttonSelectImage.Click += new System.EventHandler(this.button_click_Browse);
            // 
            // labelApplyFilter
            // 
            this.labelApplyFilter.AutoSize = true;
            this.labelApplyFilter.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplyFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.labelApplyFilter.Location = new System.Drawing.Point(741, 134);
            this.labelApplyFilter.Name = "labelApplyFilter";
            this.labelApplyFilter.Size = new System.Drawing.Size(137, 24);
            this.labelApplyFilter.TabIndex = 5;
            this.labelApplyFilter.Text = "2. Apply filters";
            // 
            // labelApplyDetection
            // 
            this.labelApplyDetection.AutoSize = true;
            this.labelApplyDetection.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplyDetection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.labelApplyDetection.Location = new System.Drawing.Point(741, 272);
            this.labelApplyDetection.Name = "labelApplyDetection";
            this.labelApplyDetection.Size = new System.Drawing.Size(214, 24);
            this.labelApplyDetection.TabIndex = 6;
            this.labelApplyDetection.Text = "3. Apply edge detection";
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.labelSave.Location = new System.Drawing.Point(741, 362);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(165, 24);
            this.labelSave.TabIndex = 7;
            this.labelSave.Text = "4. Save your work";
            // 
            // labelSelectResult
            // 
            this.labelSelectResult.AutoSize = true;
            this.labelSelectResult.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSelectResult.Location = new System.Drawing.Point(761, 105);
            this.labelSelectResult.Name = "labelSelectResult";
            this.labelSelectResult.Size = new System.Drawing.Size(174, 15);
            this.labelSelectResult.TabIndex = 8;
            this.labelSelectResult.Text = "Image selected successfuly !";
            // 
            // checkBoxRainbow
            // 
            this.checkBoxRainbow.AutoSize = true;
            this.checkBoxRainbow.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBoxRainbow.ForeColor = System.Drawing.Color.Black;
            this.checkBoxRainbow.Location = new System.Drawing.Point(764, 173);
            this.checkBoxRainbow.Name = "checkBoxRainbow";
            this.checkBoxRainbow.Size = new System.Drawing.Size(82, 21);
            this.checkBoxRainbow.TabIndex = 9;
            this.checkBoxRainbow.Text = "Rainbow";
            this.checkBoxRainbow.UseVisualStyleBackColor = true;
            this.checkBoxRainbow.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxBlackWhite
            // 
            this.checkBoxBlackWhite.AutoSize = true;
            this.checkBoxBlackWhite.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBlackWhite.Location = new System.Drawing.Point(764, 200);
            this.checkBoxBlackWhite.Name = "checkBoxBlackWhite";
            this.checkBoxBlackWhite.Size = new System.Drawing.Size(119, 19);
            this.checkBoxBlackWhite.TabIndex = 10;
            this.checkBoxBlackWhite.Text = "Black And White";
            this.checkBoxBlackWhite.UseVisualStyleBackColor = true;
            this.checkBoxBlackWhite.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxSwap
            // 
            this.checkBoxSwap.AutoSize = true;
            this.checkBoxSwap.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBoxSwap.Location = new System.Drawing.Point(764, 225);
            this.checkBoxSwap.Name = "checkBoxSwap";
            this.checkBoxSwap.Size = new System.Drawing.Size(62, 21);
            this.checkBoxSwap.TabIndex = 11;
            this.checkBoxSwap.Text = "Swap";
            this.checkBoxSwap.UseVisualStyleBackColor = true;
            this.checkBoxSwap.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // labelFilterMessage
            // 
            this.labelFilterMessage.AutoSize = true;
            this.labelFilterMessage.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelFilterMessage.Location = new System.Drawing.Point(761, 251);
            this.labelFilterMessage.Name = "labelFilterMessage";
            this.labelFilterMessage.Size = new System.Drawing.Size(85, 15);
            this.labelFilterMessage.TabIndex = 12;
            this.labelFilterMessage.Text = "Filter applied !";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Location = new System.Drawing.Point(764, 395);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(142, 34);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.button_click_Save);
            // 
            // radioButtonPrewitt
            // 
            this.radioButtonPrewitt.AutoSize = true;
            this.radioButtonPrewitt.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrewitt.Location = new System.Drawing.Point(764, 310);
            this.radioButtonPrewitt.Name = "radioButtonPrewitt";
            this.radioButtonPrewitt.Size = new System.Drawing.Size(65, 19);
            this.radioButtonPrewitt.TabIndex = 14;
            this.radioButtonPrewitt.TabStop = true;
            this.radioButtonPrewitt.Text = "Prewitt";
            this.radioButtonPrewitt.UseVisualStyleBackColor = true;
            // 
            // radioButtonKirsh
            // 
            this.radioButtonKirsh.AutoSize = true;
            this.radioButtonKirsh.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKirsh.Location = new System.Drawing.Point(870, 310);
            this.radioButtonKirsh.Name = "radioButtonKirsh";
            this.radioButtonKirsh.Size = new System.Drawing.Size(61, 19);
            this.radioButtonKirsh.TabIndex = 15;
            this.radioButtonKirsh.TabStop = true;
            this.radioButtonKirsh.Text = "Kirsch";
            this.radioButtonKirsh.UseVisualStyleBackColor = true;
            this.radioButtonKirsh.CheckedChanged += new System.EventHandler(this.radioButtonKirsh_CheckedChanged);
            // 
            // labelEdgeDetectionMessage
            // 
            this.labelEdgeDetectionMessage.AutoSize = true;
            this.labelEdgeDetectionMessage.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdgeDetectionMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelEdgeDetectionMessage.Location = new System.Drawing.Point(761, 339);
            this.labelEdgeDetectionMessage.Name = "labelEdgeDetectionMessage";
            this.labelEdgeDetectionMessage.Size = new System.Drawing.Size(141, 15);
            this.labelEdgeDetectionMessage.TabIndex = 16;
            this.labelEdgeDetectionMessage.Text = "Edge detection applied !";
            // 
            // labelSaveMessage
            // 
            this.labelSaveMessage.AutoSize = true;
            this.labelSaveMessage.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSaveMessage.Location = new System.Drawing.Point(761, 441);
            this.labelSaveMessage.Name = "labelSaveMessage";
            this.labelSaveMessage.Size = new System.Drawing.Size(86, 15);
            this.labelSaveMessage.TabIndex = 17;
            this.labelSaveMessage.Text = "Save worked !";
            // 
            // previewBox
            // 
            this.previewBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.previewBox.Location = new System.Drawing.Point(12, 427);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(700, 350);
            this.previewBox.TabIndex = 18;
            this.previewBox.TabStop = false;
            // 
            // labelOriginalPicture
            // 
            this.labelOriginalPicture.AutoSize = true;
            this.labelOriginalPicture.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOriginalPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.labelOriginalPicture.Location = new System.Drawing.Point(12, 9);
            this.labelOriginalPicture.Name = "labelOriginalPicture";
            this.labelOriginalPicture.Size = new System.Drawing.Size(142, 24);
            this.labelOriginalPicture.TabIndex = 19;
            this.labelOriginalPicture.Text = "Original picture";
            // 
            // labelPreviewImage
            // 
            this.labelPreviewImage.AutoSize = true;
            this.labelPreviewImage.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPreviewImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.labelPreviewImage.Location = new System.Drawing.Point(12, 400);
            this.labelPreviewImage.Name = "labelPreviewImage";
            this.labelPreviewImage.Size = new System.Drawing.Size(143, 24);
            this.labelPreviewImage.TabIndex = 20;
            this.labelPreviewImage.Text = "Preview picture";
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 789);
            this.Controls.Add(this.labelPreviewImage);
            this.Controls.Add(this.labelOriginalPicture);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.labelSaveMessage);
            this.Controls.Add(this.labelEdgeDetectionMessage);
            this.Controls.Add(this.radioButtonKirsh);
            this.Controls.Add(this.radioButtonPrewitt);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelFilterMessage);
            this.Controls.Add(this.checkBoxSwap);
            this.Controls.Add(this.checkBoxBlackWhite);
            this.Controls.Add(this.checkBoxRainbow);
            this.Controls.Add(this.labelSelectResult);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.labelApplyDetection);
            this.Controls.Add(this.labelApplyFilter);
            this.Controls.Add(this.buttonSelectImage);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.originalBox);
            this.Name = "ImageForm";
            this.Text = "Image Transformer";
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        //Section picture
        private System.Windows.Forms.PictureBox originalBox;

        //Section 1
        private System.Windows.Forms.Label labelSelect; 
        private System.Windows.Forms.Label labelSelectResult;
        private System.Windows.Forms.Button buttonSelectImage;

        //Section 2
        private System.Windows.Forms.Label labelApplyFilter;
        private System.Windows.Forms.CheckBox checkBoxRainbow;
        private System.Windows.Forms.CheckBox checkBoxBlackWhite;
        private System.Windows.Forms.CheckBox checkBoxSwap;
        private System.Windows.Forms.Label labelFilterMessage;

        //Section 3
        private System.Windows.Forms.Label labelApplyDetection;
        private System.Windows.Forms.RadioButton radioButtonPrewitt;
        private System.Windows.Forms.RadioButton radioButtonKirsh;
        private System.Windows.Forms.Label labelEdgeDetectionMessage;


        //Section 4
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Label labelSaveMessage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Label labelOriginalPicture;
        private System.Windows.Forms.Label labelPreviewImage;
    }
}

