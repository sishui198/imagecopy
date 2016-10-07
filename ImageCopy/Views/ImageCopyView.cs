using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ImageCopy.Views
{
    public partial class ImageCopyView : DevExpress.XtraEditors.XtraUserControl
    {
        public ImageCopyView()
        {
            InitializeComponent();
        }

        private void be_Source_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.be_Source.EditValue = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void be_Target_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.be_Target.EditValue = this.folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
