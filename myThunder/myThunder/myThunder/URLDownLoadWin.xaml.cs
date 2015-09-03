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
using System.Windows.Shapes;
using Microsoft.Win32;

namespace myThunder
{
    /// <summary>
    /// URLDownLoadWin.xaml 的交互逻辑
    /// </summary>
    public partial class URLDownLoadWin : Window
    {
        public URLDownLoadWin()
        {
            InitializeComponent();
            ctrl_download.Document.Blocks.Clear();          
        }

        //List<Uri> urilist = new List<Uri>();

        

        //bool new_task;

        //Uri uri;

        private void myf_WinMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void myf_StartDownload(object sender, RoutedEventArgs e)
        {
            
            //if(ctrl_download.Document)
            //uri = new Uri(new TextRange(ctrl_download.Document.ContentStart,ctrl_download.Document.ContentEnd).Text);
            string download_uri = new TextRange(ctrl_download.Document.ContentStart, ctrl_download.Document.ContentEnd).Text;
            string file_rename = this.ctrl_RenameFile.Text;
            if (download_uri != "")
            {
                this.Hide();
                //new_download_event += new newDownloadEventHandle(mainWin.NewDownLoadTask); 
                this.ctrl_download.AppendText(download_uri);
                new_download_event(this, new newDownloadEventArgs(download_uri, file_rename));

                
                this.Close();
                return;
            }
            this.ctrl_download.AppendText("URL无效");
        }

        public event newDownloadEventHandle new_download_event;

        public delegate void newDownloadEventHandle(object sender, newDownloadEventArgs uri_string);

        private void Quit_NewTask(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void myf_Select_download_file(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog file_open_dialog = new OpenFileDialog();
            //file_open_dialog.Filter = "All File|*.*";
            //if (file_open_dialog.ShowDialog() == true)
            //{
            //    this.ctrl_RenameFile.Text = file_open_dialog.FileName;
            //}
            SaveFileDialog save_file_dialog = new SaveFileDialog();
            save_file_dialog.FileName = "Document";
            save_file_dialog.DefaultExt = ".rar";
            if (save_file_dialog.ShowDialog() == true)
            {
                this.ctrl_RenameFile.Text = save_file_dialog.FileName;
            }
        }        
    }

    public class newDownloadEventArgs : EventArgs
    {
        public string download_uri;
        public string file_rename;
        public newDownloadEventArgs(string download_uri_temp, string file_rename_temp)
        {
            download_uri = download_uri_temp;
            file_rename = file_rename_temp;
        }
    }
}
