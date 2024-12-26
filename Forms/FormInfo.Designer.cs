namespace Forms
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            pictureBoxMePhoto_KDV = new PictureBox();
            labelTextInfo_KDV = new Label();
            buttonOK_KDV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMePhoto_KDV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMePhoto_KDV
            // 
            pictureBoxMePhoto_KDV.Image = (Image)resources.GetObject("pictureBoxMePhoto_KDV.Image");
            pictureBoxMePhoto_KDV.Location = new Point(32, 33);
            pictureBoxMePhoto_KDV.Name = "pictureBoxMePhoto_KDV";
            pictureBoxMePhoto_KDV.Size = new Size(227, 394);
            pictureBoxMePhoto_KDV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMePhoto_KDV.TabIndex = 0;
            pictureBoxMePhoto_KDV.TabStop = false;
            // 
            // labelTextInfo_KDV
            // 
            labelTextInfo_KDV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTextInfo_KDV.AutoSize = true;
            labelTextInfo_KDV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextInfo_KDV.Location = new Point(280, 89);
            labelTextInfo_KDV.Name = "labelTextInfo_KDV";
            labelTextInfo_KDV.Size = new Size(600, 207);
            labelTextInfo_KDV.TabIndex = 1;
            labelTextInfo_KDV.Text = resources.GetString("labelTextInfo_KDV.Text");
            // 
            // buttonOK_KDV
            // 
            buttonOK_KDV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK_KDV.Location = new Point(749, 439);
            buttonOK_KDV.Name = "buttonOK_KDV";
            buttonOK_KDV.Size = new Size(131, 41);
            buttonOK_KDV.TabIndex = 2;
            buttonOK_KDV.Text = "Ок";
            buttonOK_KDV.UseVisualStyleBackColor = true;
            buttonOK_KDV.Click += buttonOK_KDV_Click;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 492);
            Controls.Add(buttonOK_KDV);
            Controls.Add(labelTextInfo_KDV);
            Controls.Add(pictureBoxMePhoto_KDV);
            Name = "FormInfo";
            Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMePhoto_KDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMePhoto_KDV;
        private Label labelTextInfo_KDV;
        private Button buttonOK_KDV;
    }
}