﻿#pragma checksum "H:\Hoc Tap\FPT Univerdity\Do an tot nghiep 2015\2015FALLIS01\Source Code\FTaxi_Project_FPT_Uiversity\FT-Rider\Pages\RiderChangePassword.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3DD801D83D6063C6D09A5831B5074D6D"
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


namespace FT_Rider.Pages {
    
    
    public partial class RiderChangePassword : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.PasswordBox txt_OldPassword;
        
        internal System.Windows.Controls.PasswordBox txt_NewPassword;
        
        internal System.Windows.Controls.PasswordBox txt_NewPassWordAgain;
        
        internal System.Windows.Controls.Button btn_Confirm;
        
        internal System.Windows.Controls.Image img_OldPasswordIcon;
        
        internal System.Windows.Controls.Image img_OldPasswordIcon_Copy;
        
        internal System.Windows.Controls.Image img_OldPasswordIcon_Copy1;
        
        internal System.Windows.Controls.TextBlock tbl_Account;
        
        internal System.Windows.Controls.TextBlock tbl_Account_Copy;
        
        internal System.Windows.Controls.TextBlock tbl_Account_Copy1;
        
        internal System.Windows.Controls.Grid grv_ProcessScreen;
        
        internal System.Windows.Controls.ProgressBar pb_ProcessBar;
        
        internal System.Windows.Controls.TextBlock tbl_loading;
        
        internal System.Windows.Controls.Image img_Navbar;
        
        internal System.Windows.Controls.TextBlock tbl_ChangePassword;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FT-Rider;component/Pages/RiderChangePassword.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txt_OldPassword = ((System.Windows.Controls.PasswordBox)(this.FindName("txt_OldPassword")));
            this.txt_NewPassword = ((System.Windows.Controls.PasswordBox)(this.FindName("txt_NewPassword")));
            this.txt_NewPassWordAgain = ((System.Windows.Controls.PasswordBox)(this.FindName("txt_NewPassWordAgain")));
            this.btn_Confirm = ((System.Windows.Controls.Button)(this.FindName("btn_Confirm")));
            this.img_OldPasswordIcon = ((System.Windows.Controls.Image)(this.FindName("img_OldPasswordIcon")));
            this.img_OldPasswordIcon_Copy = ((System.Windows.Controls.Image)(this.FindName("img_OldPasswordIcon_Copy")));
            this.img_OldPasswordIcon_Copy1 = ((System.Windows.Controls.Image)(this.FindName("img_OldPasswordIcon_Copy1")));
            this.tbl_Account = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Account")));
            this.tbl_Account_Copy = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Account_Copy")));
            this.tbl_Account_Copy1 = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Account_Copy1")));
            this.grv_ProcessScreen = ((System.Windows.Controls.Grid)(this.FindName("grv_ProcessScreen")));
            this.pb_ProcessBar = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_ProcessBar")));
            this.tbl_loading = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_loading")));
            this.img_Navbar = ((System.Windows.Controls.Image)(this.FindName("img_Navbar")));
            this.tbl_ChangePassword = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_ChangePassword")));
        }
    }
}

