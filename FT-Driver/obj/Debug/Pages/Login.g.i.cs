﻿#pragma checksum "H:\Hoc Tap\FPT Univerdity\Do an tot nghiep 2015\2015FALLIS01\Source Code\FTaxi_Project_FPT_Uiversity\FT-Driver\Pages\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D1968D124906E0B07429AC23E6BDF801"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using Telerik.Windows.Controls;


namespace FT_Driver.Pages {
    
    
    public partial class Login : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button btn_Login;
        
        internal Telerik.Windows.Controls.RadTextBox txt_UserId;
        
        internal Telerik.Windows.Controls.RadPasswordBox txt_Password;
        
        internal System.Windows.Controls.TextBlock tbl_LostPassword;
        
        internal System.Windows.Controls.Image img_FTaxiLogo;
        
        internal System.Windows.Controls.Image img_UserIdIcon;
        
        internal System.Windows.Controls.Image img_PasswordIcon;
        
        internal System.Windows.Controls.TextBlock tbl_Account;
        
        internal System.Windows.Controls.TextBlock tbl_Password;
        
        internal System.Windows.Controls.Grid grv_ProcessScreen;
        
        internal System.Windows.Shapes.Rectangle rt_processBar;
        
        internal System.Windows.Controls.ProgressBar pb_ProcessBar;
        
        internal System.Windows.Controls.TextBlock tbl_loading;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FT-Driver;component/Pages/Login.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btn_Login = ((System.Windows.Controls.Button)(this.FindName("btn_Login")));
            this.txt_UserId = ((Telerik.Windows.Controls.RadTextBox)(this.FindName("txt_UserId")));
            this.txt_Password = ((Telerik.Windows.Controls.RadPasswordBox)(this.FindName("txt_Password")));
            this.tbl_LostPassword = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_LostPassword")));
            this.img_FTaxiLogo = ((System.Windows.Controls.Image)(this.FindName("img_FTaxiLogo")));
            this.img_UserIdIcon = ((System.Windows.Controls.Image)(this.FindName("img_UserIdIcon")));
            this.img_PasswordIcon = ((System.Windows.Controls.Image)(this.FindName("img_PasswordIcon")));
            this.tbl_Account = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Account")));
            this.tbl_Password = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Password")));
            this.grv_ProcessScreen = ((System.Windows.Controls.Grid)(this.FindName("grv_ProcessScreen")));
            this.rt_processBar = ((System.Windows.Shapes.Rectangle)(this.FindName("rt_processBar")));
            this.pb_ProcessBar = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_ProcessBar")));
            this.tbl_loading = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_loading")));
        }
    }
}

