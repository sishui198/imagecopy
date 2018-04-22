using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageCopy.ViewModels
{
    [POCOViewModel]
    public class ImageCopyViewModel
    {
        private const string NO_DATE_FILE_DIR_NAME = "未获取日期";
        private const string ALREADY_EXIST_FILE_DIR_NAME = "可能重复";

        public ImageCopyViewModel()
        {
            IsRename = false;
            Prefix = "IMG";
        }

        public virtual string Source { get; set; }
        public virtual string Target { get; set; }
        public virtual bool IsRename { get; set; }
        public virtual string Prefix { get; set; }
        public virtual string Progress { get; set; }

        protected IDispatcherService DispatcherService
        {
            get { return this.GetService<IDispatcherService>(); }
        }

        protected IMessageBoxService MessageBoxService
        {
            get { return this.GetService<IMessageBoxService>(); }
        }

        public virtual void SelectSource()
        {
            FolderBrowserDialog fbdlg = new FolderBrowserDialog();
            if (fbdlg.ShowDialog() == DialogResult.OK)
            {
                Source = fbdlg.SelectedPath;
            }
        }

        public virtual void SetTarget()
        {
            FolderBrowserDialog fbdlg = new FolderBrowserDialog();
            if (fbdlg.ShowDialog() == DialogResult.OK)
            {
                Target = fbdlg.SelectedPath;
            }
        }

        public Task AsyncImageCopy()
        {
            return Task.Factory.StartNew(() =>
            {
                if (String.IsNullOrEmpty(Source))
                {
                    MessageBoxService.ShowMessage("请选择源文件");
                    return;
                }
                if (String.IsNullOrEmpty(Target))
                {
                    MessageBoxService.ShowMessage("请确定目标路径");
                    return;
                }

                if (!Directory.Exists(Source))
                {
                    MessageBoxService.ShowMessage("源路径不合法");
                    return;
                }
                if (!Directory.Exists(Target))
                {
                    MessageBoxService.ShowMessage("目标路径不合法");
                    return;
                }

                var asyncCommand = this.GetAsyncCommand(x => x.AsyncImageCopy());

                FileInfo[] files = new DirectoryInfo(Source).GetFiles("*.JPG");
                int z = 0;
                for (int i = 0; i < files.Length; i++)
                {
                    if (asyncCommand.IsCancellationRequested)
                        break;
                    //File.Copy(Path.Combine(Source,files[i].Name), Path.Combine(Target, files[i].Name), true);
                    UpdateProgressOnUIThread(String.Format("正在处理“{0}”...", files[i].Name));

                    string takedatetime = NO_DATE_FILE_DIR_NAME;
                    foreach (var item in Image.FromFile(Path.Combine(Source, files[i].Name)).PropertyItems)
                    {
                        if (item.Id == 0x0132)
                        {
                            takedatetime = Encoding.ASCII.GetString(item.Value);
                            break;
                        }
                    }

                    if (takedatetime != NO_DATE_FILE_DIR_NAME)
                    {
                        takedatetime = takedatetime.Split(' ')[0].Replace(":", "").Replace("/", "");
                        if (takedatetime.IndexOf(":") >= 0)
                        {
                            takedatetime = takedatetime.Replace(":", "");
                        }
                        if (takedatetime.IndexOf("/") >= 0)
                        {
                            takedatetime = takedatetime.Replace("/", "");
                        }
                        //takedatetime = takedatetime.Trim('\0');
                        //DateTime dt = Convert.ToDateTime(takedatetime);
                        //takedatetime = dt.ToString("yyyyMMddHHmmss");
                    }

                    string sourcefilename = Path.Combine(Source, files[i].Name);
                    string targetfilename = Path.Combine(Target, takedatetime, files[i].Name);
                    if (File.Exists(targetfilename))
                    {
                        takedatetime = ALREADY_EXIST_FILE_DIR_NAME;
                        targetfilename = Path.Combine(Target, takedatetime, files[i].Name); 
                    }

                    if (!Directory.Exists(Path.Combine(Target, takedatetime)))
                        Directory.CreateDirectory(Path.Combine(Target, takedatetime));

                    File.Copy(sourcefilename, targetfilename, true);
                    z++;
                }

                if (asyncCommand.IsCancellationRequested) UpdateProgressOnUIThread("用户取消");
                // 批量重命名
                UpdateProgressOnUIThread("正在重命名所有文件");
                if (IsRename)
                {
                    DirectoryInfo drtmp = new DirectoryInfo(Target);
                    DirectoryInfo[] dris = drtmp.GetDirectories();
                    for (int j = 0; j < dris.Length; j++)
                    {
                        if (dris[j].Name == ALREADY_EXIST_FILE_DIR_NAME || dris[j].Name == NO_DATE_FILE_DIR_NAME)
                        {
                            continue;
                        }
                        FileInfo[] rmfiles = dris[j].GetFiles("*.JPG");
                        for (int i = 0; i < rmfiles.Length; i++)
                        {
                            string newname = Path.Combine(dris[j].FullName, String.Format("{0}_{1:D4}.jpg", Prefix, i));
                            rmfiles[i].MoveTo(newname);
                        }
                    }
                }

                UpdateProgressOnUIThread(String.Format("完成，总共处理了{0}个文件", z));
                if (asyncCommand.IsCancellationRequested) UpdateProgressOnUIThread("用户取消");
            }
                );
        }

        void UpdateProgressOnUIThread(string progress)
        {
            DispatcherService.BeginInvoke(() =>
            {
                Progress = progress;
                this.RaisePropertyChanged(x => x.Progress);
            });
        }
    }
}