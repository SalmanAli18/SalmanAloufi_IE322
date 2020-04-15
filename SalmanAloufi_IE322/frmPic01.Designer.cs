namespace SalmanAloufi_IE322
{
    partial class frmPic01
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
            this.BtnImageFromFile = new System.Windows.Forms.Button();
            this.BtnImageFromRes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picTry = new System.Windows.Forms.PictureBox();
            this.picTry2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnImageFromFile
            // 
            this.BtnImageFromFile.Location = new System.Drawing.Point(32, 34);
            this.BtnImageFromFile.Name = "BtnImageFromFile";
            this.BtnImageFromFile.Size = new System.Drawing.Size(118, 56);
            this.BtnImageFromFile.TabIndex = 0;
            this.BtnImageFromFile.Text = "Image from file";
            this.BtnImageFromFile.UseVisualStyleBackColor = true;
            // 
            // BtnImageFromRes
            // 
            this.BtnImageFromRes.Location = new System.Drawing.Point(32, 96);
            this.BtnImageFromRes.Name = "BtnImageFromRes";
            this.BtnImageFromRes.Size = new System.Drawing.Size(118, 55);
            this.BtnImageFromRes.TabIndex = 1;
            this.BtnImageFromRes.Text = "Image from resource";
            this.BtnImageFromRes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTry2);
            this.groupBox1.Controls.Add(this.picTry);
            this.groupBox1.Location = new System.Drawing.Point(156, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 310);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture boxes";
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(3, 20);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(299, 284);
            this.picTry.TabIndex = 0;
            this.picTry.TabStop = false;
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(308, 20);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(318, 284);
            this.picTry2.TabIndex = 1;
            this.picTry2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(625, 375);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 46);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmPic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnImageFromRes);
            this.Controls.Add(this.BtnImageFromFile);
            this.Name = "frmPic01";
            this.Text = "frmPic01";
            this.Load += new System.EventHandler(this.frmPic01_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnImageFromFile;
        private System.Windows.Forms.Button BtnImageFromRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picTry2;
        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.Button btnBack;
    }
}