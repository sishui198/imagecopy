namespace ImageCopy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageCopyView1 = new ImageCopy.Views.ImageCopyView();
            this.SuspendLayout();
            // 
            // imageCopyView1
            // 
            this.imageCopyView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageCopyView1.Location = new System.Drawing.Point(0, 0);
            this.imageCopyView1.Name = "imageCopyView1";
            this.imageCopyView1.Size = new System.Drawing.Size(434, 171);
            this.imageCopyView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 171);
            this.Controls.Add(this.imageCopyView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Easy Copy Image";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.ImageCopyView imageCopyView1;
    }
}

