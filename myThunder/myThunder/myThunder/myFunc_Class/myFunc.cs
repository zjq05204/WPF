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
using System.IO;
using System.Net;
using System.ComponentModel;

namespace myThunder
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public WebClient mywebclient = new WebClient();

        public void myFunc_ResizeWindow(string btn_name)
        {
            switch (btn_name)
            {
                case "Setting":
                    //myf_Setting();
                    MessageBox.Show("设置");
                    break;

                case "ResizeWindow_min":
                    //myf_Window_min();
                    this.WindowState = WindowState.Minimized;
                    break;

                case "ResizeWindow_mxn":
                    //myf_Window_mxn();
                    if (this.WindowState == WindowState.Maximized)
                        this.WindowState = WindowState.Normal;
                    else
                        this.WindowState = WindowState.Maximized;
                    break;

                case "ResizeWindow_xn":
                    //myf_Window_xn();
                    Application.Current.Shutdown();
                    break;

                default:
                    MessageBox.Show("程序异常");
                    break;
            }        
        }
        public void myFunc_Task_Handle(string btn_name)
        {
            switch (btn_name)
            { 
                case "NewUrl":
                    myf_NewDownLoadWin();
                    break;
                case "Pause_Play":
                    break;
                case "Stop":
                    break;
                case "AllTask_Selected":
                    break;
                default:
                    MessageBox.Show("程序异常");
                    break;
            
            }
        }
        public void myf_NewDownLoadWin()
        {
            URLDownLoadWin urlwin = new URLDownLoadWin();
            urlwin.new_download_event += new URLDownLoadWin.newDownloadEventHandle(this.NewDownLoadTask);
            urlwin.ShowDialog();
        }

        double download_file_size = 0;
        long time_start = 0;

        public void NewDownLoadTask(object sender, newDownloadEventArgs uri_string)
        {
            
            if (mywebclient.IsBusy)
            {
                mywebclient.CancelAsync();
                return;
            }
            Uri uri = new Uri(uri_string.download_uri);

            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            download_file_size = Math.Round(((double)webresponse.ContentLength)/(1024*1024),2);
            //MessageBox.Show(webresponse.ContentLength.ToString());  //获取下载文件的大小
            //MessageBox.Show(webresponse.ContentType); //不知道什么意思
            webresponse.Close();

            mywebclient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(myf_DownloadProgressChanged);
            mywebclient.DownloadFileCompleted += new AsyncCompletedEventHandler(myf_DownloadFileCompleted);
            mywebclient.DownloadFileAsync(uri, uri_string.file_rename);
            time_start = DateTime.Now.Second + DateTime.Now.Minute * 60 + DateTime.Now.Hour * 3600;
            task_count++;
            if (task_count > 0)
            {
                Cdownloaditem_info download_info = new Cdownloaditem_info() { file_name = "QQ.rar", file_size = (download_file_size.ToString()+" MB"), file_progress = 0, remain_time = "0:00:00", download_speed = "10KB/s" };
                DownLoadItem downloaditem = new DownLoadItem();
                downloaditem.Downloaditem_info = download_info;
                ctrl_download_list.Items.Add(downloaditem);
            }
        }

        public void myf_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        { 
            //Cdownloaditem_info download_info = new Cdownloaditem_info(){file_name = "QQ.rar", file_size = "1MB", file_progress = 0, remain_time = "0:00:00", download_speed = "10KB/s" };
            //download_info.file_progress = (uint)e.ProgressPercentage;
            DownLoadItem download_item = this.ctrl_download_list.Items[0] as DownLoadItem;
            download_item.ctrl_progress.Content = e.ProgressPercentage.ToString() + "%";
            long time_now = DateTime.Now.Second + DateTime.Now.Minute * 60 + DateTime.Now.Hour * 3600;
            double download_speed = download_file_size*e.ProgressPercentage/100/(time_now-time_start);
            download_speed = Math.Round(download_speed, 2);
            download_item.ctrl_download_speed.Content = download_speed.ToString()+" MB/s";
        }

        public void myf_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DownLoadItem download_item = this.ctrl_download_list.Items[0] as DownLoadItem;
            download_item.ctrl_download_speed.Content = String.Format("{0} MB/s",0);
            MessageBox.Show("下载文件成功");
        }
        //public event newDownloadEventHandle new_download_event;

        //public delegate void newDownloadEventHandle(object sender, newDownloadEventArgs uri_string);        
    }

    //public class newDownloadEventArgs : EventArgs
    //{
    //    public string download_uri;
    //    public newDownloadEventArgs(string download_uri_temp)
    //    {
    //        download_uri = download_uri_temp;
    //    }
    //}    
}