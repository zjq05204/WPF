﻿#pragma checksum "..\..\..\URLDownLoadWin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7C79ED38B7BD6D79036C120AFFA6F14C"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using myWPFCustomControls;


namespace myThunder {
    
    
    /// <summary>
    /// URLDownLoadWin
    /// </summary>
    public partial class URLDownLoadWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\URLDownLoadWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal myWPFCustomControls.myImageButton Quit_btn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\URLDownLoadWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox ctrl_download;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\URLDownLoadWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ctrl_RenameFile;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/myThunder;component/urldownloadwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\URLDownLoadWin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\URLDownLoadWin.xaml"
            ((myThunder.URLDownLoadWin)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.myf_WinMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Quit_btn = ((myWPFCustomControls.myImageButton)(target));
            
            #line 33 "..\..\..\URLDownLoadWin.xaml"
            this.Quit_btn.Click += new System.Windows.RoutedEventHandler(this.Quit_NewTask);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ctrl_download = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 4:
            this.ctrl_RenameFile = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 77 "..\..\..\URLDownLoadWin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.myf_Select_download_file);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 79 "..\..\..\URLDownLoadWin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.myf_StartDownload);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
