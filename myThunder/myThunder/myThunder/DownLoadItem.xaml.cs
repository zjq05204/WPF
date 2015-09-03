using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace myThunder
{
    /// <summary>
    /// DownLoadItem.xaml 的交互逻辑
    /// </summary>
    public partial class DownLoadItem : UserControl
    {
        public DownLoadItem()
        {
            InitializeComponent();
        }

        private Cdownloaditem_info downloaditem_info;
        public Cdownloaditem_info Downloaditem_info
        {
            get 
            {
                return downloaditem_info;
            }
            set
            {
                downloaditem_info = value;
                this.ctrl_file_name.Content = downloaditem_info.file_name;
                this.ctrl_file_size.Content = downloaditem_info.file_size;
                this.ctrl_progressbar.Value = downloaditem_info.file_progress;
                this.ctrl_progress.Content = downloaditem_info.file_progress.ToString() + "%";
                this.ctrl_download_remain_time.Content = downloaditem_info.remain_time;
                this.ctrl_download_speed.Content = downloaditem_info.download_speed;            
            }    
        }
    }

    public class Cdownloaditem_info
    {
        public string file_name { get; set; }
        public string file_size { get; set; }
        public uint file_progress { get; set; }
        public string remain_time { get; set; }
        public string download_speed { get; set; }    
    }
}
