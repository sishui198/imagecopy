namespace ImageCopy.Views
{
    partial class ImageCopyView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Cencel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Do = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.be_Target = new DevExpress.XtraEditors.ButtonEdit();
            this.be_Source = new DevExpress.XtraEditors.ButtonEdit();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_Info = new DevExpress.XtraEditors.LabelControl();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.be_Target.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.be_Source.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cencel
            // 
            this.btn_Cencel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cencel.Location = new System.Drawing.Point(219, 87);
            this.btn_Cencel.Name = "btn_Cencel";
            this.btn_Cencel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cencel.TabIndex = 12;
            this.btn_Cencel.Text = "取消";
            // 
            // btn_Do
            // 
            this.btn_Do.Location = new System.Drawing.Point(113, 87);
            this.btn_Do.Name = "btn_Do";
            this.btn_Do.Size = new System.Drawing.Size(75, 23);
            this.btn_Do.TabIndex = 11;
            this.btn_Do.Text = "执行";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "目标保存目录：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "相片源目录：";
            // 
            // be_Target
            // 
            this.be_Target.Location = new System.Drawing.Point(113, 47);
            this.be_Target.Name = "be_Target";
            this.be_Target.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.be_Target.Size = new System.Drawing.Size(289, 20);
            this.be_Target.TabIndex = 10;
            this.be_Target.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.be_Target_ButtonClick);
            // 
            // be_Source
            // 
            this.be_Source.Location = new System.Drawing.Point(113, 21);
            this.be_Source.Name = "be_Source";
            this.be_Source.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.be_Source.Size = new System.Drawing.Size(289, 20);
            this.be_Source.TabIndex = 8;
            this.be_Source.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.be_Source_ButtonClick);
            // 
            // lbl_Info
            // 
            this.lbl_Info.Location = new System.Drawing.Point(23, 136);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(0, 14);
            this.lbl_Info.TabIndex = 13;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "Source", this.be_Source, "Text"),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "AsyncImageCopy", this.btn_Do),
            DevExpress.Utils.MVVM.BindingExpression.CreateCancelCommandBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "AsyncImageCopy", this.btn_Cencel),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "Progress", this.lbl_Info, "Text"),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "Target", this.be_Target, "Text")});
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(ImageCopy.ViewModels.ImageCopyViewModel);
            // 
            // ImageCopyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.btn_Cencel);
            this.Controls.Add(this.btn_Do);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.be_Target);
            this.Controls.Add(this.be_Source);
            this.Name = "ImageCopyView";
            this.Size = new System.Drawing.Size(440, 172);
            ((System.ComponentModel.ISupportInitialize)(this.be_Target.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.be_Source.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.SimpleButton btn_Cencel;
        private DevExpress.XtraEditors.SimpleButton btn_Do;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit be_Target;
        private DevExpress.XtraEditors.ButtonEdit be_Source;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraEditors.LabelControl lbl_Info;
    }
}
