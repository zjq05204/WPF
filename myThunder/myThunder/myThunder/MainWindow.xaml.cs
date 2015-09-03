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
        public MainWindow()
        {
            InitializeComponent();

            task_count = 0;
            
            //URLDownLoadWin urlWin = new URLDownLoadWin();
            //urlWin.new_download_event += new urlWin.newDownloadEventHandle(this.NewDownLoadTask);
        }

        private uint task_count;

        private void myf_DragWindow(object sender, MouseEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            this.DragMove();
        }

        private void myf_ResizeWindow(object sender, RoutedEventArgs e)
        {
            myFunc_ResizeWindow((e.Source as FrameworkElement).Name);
        }

        private void myf_Task(object sender, RoutedEventArgs e)
        {
            myFunc_Task_Handle((e.Source as FrameworkElement).Name);
        }           
    }
}
