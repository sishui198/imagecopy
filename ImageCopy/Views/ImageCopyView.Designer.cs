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
            this.lbl_Info = new DevExpress.XtraEditors.LabelControl();
            this.chk_Rename = new DevExpress.XtraEditors.CheckEdit();
            this.txt_Prefix = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.be_Target.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.be_Source.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Rename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Prefix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cencel
            // 
            this.btn_Cencel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cencel.Location = new System.Drawing.Point(236, 121);
            this.btn_Cencel.Name = "btn_Cencel";
            this.btn_Cencel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cencel.TabIndex = 8;
            this.btn_Cencel.Text = "取消";
            // 
            // btn_Do
            // 
            this.btn_Do.Location = new System.Drawing.Point(130, 121);
            this.btn_Do.Name = "btn_Do";
            this.btn_Do.Size = new System.Drawing.Size(75, 23);
            this.btn_Do.TabIndex = 7;
            this.btn_Do.Text = "执行";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "目标保存目录：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "相片源目录：";
            // 
            // be_Target
            // 
            this.be_Target.Location = new System.Drawing.Point(113, 47);
            this.be_Target.Name = "be_Target";
            this.be_Target.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.be_Target.Properties.ReadOnly = true;
            this.be_Target.Size = new System.Drawing.Size(289, 20);
            this.be_Target.TabIndex = 3;
            // 
            // be_Source
            // 
            this.be_Source.Location = new System.Drawing.Point(113, 21);
            this.be_Source.Name = "be_Source";
            this.be_Source.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.be_Source.Properties.ReadOnly = true;
            this.be_Source.Size = new System.Drawing.Size(289, 20);
            this.be_Source.TabIndex = 1;
            // 
            // lbl_Info
            // 
            this.lbl_Info.Location = new System.Drawing.Point(21, 151);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(0, 14);
            this.lbl_Info.TabIndex = 9;
            // 
            // chk_Rename
            // 
            this.chk_Rename.Location = new System.Drawing.Point(113, 83);
            this.chk_Rename.Name = "chk_Rename";
            this.chk_Rename.Properties.AutoWidth = true;
            this.chk_Rename.Properties.Caption = "照片批量重命名";
            this.chk_Rename.Size = new System.Drawing.Size(106, 19);
            this.chk_Rename.TabIndex = 4;
            // 
            // txt_Prefix
            // 
            this.txt_Prefix.Location = new System.Drawing.Point(277, 82);
            this.txt_Prefix.Name = "txt_Prefix";
            this.txt_Prefix.Size = new System.Drawing.Size(100, 20);
            this.txt_Prefix.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(235, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "前缀：";
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "Source", this.be_Source, "Text"),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "AsyncImageCopy", this.btn_Do),
            DevExpress.Utils.MVVM.BindingExpression.CreateCancelCommandBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "AsyncImageCopy", this.btn_Cencel),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "Progress", this.lbl_Info, "Text"),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "Target", this.be_Target, "Text"),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "Prefix", this.txt_Prefix, "Text"),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "IsRename", this.chk_Rename, "Checked"),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "IsRename", this.txt_Prefix, "Enabled")});
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterEventToCommand(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "ButtonClick", this.be_Source, "SelectSource"),
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterEventToCommand(typeof(ImageCopy.ViewModels.ImageCopyViewModel), "ButtonClick", this.be_Target, "SetTarget"),
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterMessageBoxService(null, false, DevExpress.Utils.MVVM.Services.DefaultMessageBoxServiceType.Default)});
            this.mvvmContext1.ViewModelType = typeof(ImageCopy.ViewModels.ImageCopyViewModel);
            // 
            // ImageCopyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_Prefix);
            this.Controls.Add(this.chk_Rename);
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
            ((System.ComponentModel.ISupportInitialize)(this.chk_Rename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Prefix.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lbl_Info;
        private DevExpress.XtraEditors.TextEdit txt_Prefix;
        private DevExpress.XtraEditors.CheckEdit chk_Rename;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
