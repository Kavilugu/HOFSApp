namespace HOFSApp
{
    partial class EstateInfo
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
            this.FullInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.FullInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FullInfoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FullInfoPictureBox
            // 
            this.FullInfoPictureBox.Location = new System.Drawing.Point(344, 21);
            this.FullInfoPictureBox.Name = "FullInfoPictureBox";
            this.FullInfoPictureBox.Size = new System.Drawing.Size(174, 127);
            this.FullInfoPictureBox.TabIndex = 0;
            this.FullInfoPictureBox.TabStop = false;
            // 
            // FullInfoLabel
            // 
            this.FullInfoLabel.AutoSize = true;
            this.FullInfoLabel.Location = new System.Drawing.Point(22, 21);
            this.FullInfoLabel.Name = "FullInfoLabel";
            this.FullInfoLabel.Size = new System.Drawing.Size(0, 15);
            this.FullInfoLabel.TabIndex = 1;
            // 
            // EstateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 170);
            this.Controls.Add(this.FullInfoLabel);
            this.Controls.Add(this.FullInfoPictureBox);
            this.Name = "EstateInfo";
            this.Text = "EstateInfo";
            ((System.ComponentModel.ISupportInitialize)(this.FullInfoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox FullInfoPictureBox;
        public System.Windows.Forms.Label FullInfoLabel;
    }
}