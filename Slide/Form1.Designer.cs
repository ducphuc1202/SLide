namespace Slide
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.slideContainer = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slideContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // slideContainer
            // 
            this.slideContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slideContainer.Location = new System.Drawing.Point(43, 21);
            this.slideContainer.Name = "slideContainer";
            this.slideContainer.Size = new System.Drawing.Size(728, 294);
            this.slideContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slideContainer.TabIndex = 0;
            this.slideContainer.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImage.AutoSize = true;
            this.btnImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImage.LinkColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(698, 354);
            this.btnImage.Name = "btnImage";
            this.btnImage.Padding = new System.Windows.Forms.Padding(10);
            this.btnImage.Size = new System.Drawing.Size(73, 33);
            this.btnImage.TabIndex = 1;
            this.btnImage.TabStop = true;
            this.btnImage.Text = "Chon anh";
            this.btnImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnImage_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.slideContainer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slide Image";
            ((System.ComponentModel.ISupportInitialize)(this.slideContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slideContainer;
        private System.Windows.Forms.LinkLabel btnImage;
        private System.Windows.Forms.Timer timer1;
    }
}

