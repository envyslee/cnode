﻿#pragma checksum "D:\documents\visual studio 2013\Projects\cnode\trunk\cnode\cnode\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8BF76889D00412D7182F37A2D96BD8F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using cnode.Control;


namespace cnode {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage homepage;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal cnode.Control.Loading loadingpage;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/cnode;component/MainPage.xaml", System.UriKind.Relative));
            this.homepage = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("homepage")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.loadingpage = ((cnode.Control.Loading)(this.FindName("loadingpage")));
        }
    }
}

