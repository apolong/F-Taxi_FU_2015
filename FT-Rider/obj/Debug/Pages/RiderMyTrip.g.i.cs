﻿#pragma checksum "H:\Hoc Tap\FPT Univerdity\Do an tot nghiep 2015\2015FALLIS01\Source Code\FTaxi_Project_FPT_Uiversity\FT-Rider\Pages\RiderMyTrip.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA30028FD4CE3E3FE8D64EBDE8A9792F"
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
    
    
    public partial class RiderMyTrip : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock tbl_intro;
        
        internal System.Windows.Controls.Image img_PageBreak;
        
        internal Microsoft.Phone.Controls.LongListSelector lls_MyTrip;
        
        internal System.Windows.Controls.TextBlock txt_MyTripStatus;
        
        internal System.Windows.Controls.Grid grv_TripDetail;
        
        internal System.Windows.Controls.Button btn_Close;
        
        internal System.Windows.Shapes.Rectangle panel_name;
        
        internal System.Windows.Shapes.Rectangle panel_Pay;
        
        internal System.Windows.Controls.TextBox txt_DriverName;
        
        internal System.Windows.Controls.Image img_DriverAvatar;
        
        internal System.Windows.Controls.TextBox txt_Mobile;
        
        internal System.Windows.Controls.TextBox txt_From;
        
        internal System.Windows.Controls.TextBox txt_To;
        
        internal System.Windows.Controls.TextBlock tbl_Distance;
        
        internal System.Windows.Controls.TextBox txt_Distance;
        
        internal System.Windows.Controls.TextBlock tbl_TotalCost;
        
        internal System.Windows.Controls.TextBox txt_TotalCost;
        
        internal System.Windows.Controls.TextBlock tbl_PaymentType;
        
        internal System.Windows.Controls.TextBox txt_PaymentType;
        
        internal System.Windows.Controls.PasswordBox pwd_Password;
        
        internal System.Windows.Shapes.Rectangle line1;
        
        internal System.Windows.Shapes.Rectangle line1_Copy;
        
        internal System.Windows.Shapes.Rectangle line1_Copy1;
        
        internal System.Windows.Controls.Image img_Username;
        
        internal System.Windows.Controls.Image img_mobile;
        
        internal System.Windows.Controls.Image img_From;
        
        internal System.Windows.Controls.Image img_To;
        
        internal System.Windows.Shapes.Rectangle line1_Copy2;
        
        internal System.Windows.Shapes.Rectangle line1_Copy3;
        
        internal System.Windows.Shapes.Rectangle line1_Copy4;
        
        internal System.Windows.Controls.Button btn_AddFavorite;
        
        internal System.Windows.Controls.TextBlock tbl_CarLevel;
        
        internal System.Windows.Controls.TextBox txt_CarLevel;
        
        internal System.Windows.Controls.Image img_Navbar;
        
        internal System.Windows.Controls.TextBlock tbl_MyTrip;
        
        internal System.Windows.Controls.Grid grv_RiderLossAssets;
        
        internal System.Windows.Controls.Image img_header;
        
        internal System.Windows.Controls.Image img_CloseRiderLostAsset;
        
        internal System.Windows.Controls.TextBox txt_Content;
        
        internal System.Windows.Controls.Button btn_SendLostAsset;
        
        internal System.Windows.Controls.Grid grv_FunctionMenu;
        
        internal System.Windows.Controls.Button btn_Cancel;
        
        internal System.Windows.Controls.Button btn_AlertAssets;
        
        internal System.Windows.Controls.Button btn_CallToDriver;
        
        internal System.Windows.Controls.Button btn_ViewTripDetail;
        
        internal System.Windows.Controls.Grid grv_ButtonLoadingScreen;
        
        internal System.Windows.Shapes.Rectangle rt_bg;
        
        internal System.Windows.Controls.ProgressBar pb_loading;
        
        internal System.Windows.Controls.Grid grv_ProcessScreen;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FT-Rider;component/Pages/RiderMyTrip.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.tbl_intro = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_intro")));
            this.img_PageBreak = ((System.Windows.Controls.Image)(this.FindName("img_PageBreak")));
            this.lls_MyTrip = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("lls_MyTrip")));
            this.txt_MyTripStatus = ((System.Windows.Controls.TextBlock)(this.FindName("txt_MyTripStatus")));
            this.grv_TripDetail = ((System.Windows.Controls.Grid)(this.FindName("grv_TripDetail")));
            this.btn_Close = ((System.Windows.Controls.Button)(this.FindName("btn_Close")));
            this.panel_name = ((System.Windows.Shapes.Rectangle)(this.FindName("panel_name")));
            this.panel_Pay = ((System.Windows.Shapes.Rectangle)(this.FindName("panel_Pay")));
            this.txt_DriverName = ((System.Windows.Controls.TextBox)(this.FindName("txt_DriverName")));
            this.img_DriverAvatar = ((System.Windows.Controls.Image)(this.FindName("img_DriverAvatar")));
            this.txt_Mobile = ((System.Windows.Controls.TextBox)(this.FindName("txt_Mobile")));
            this.txt_From = ((System.Windows.Controls.TextBox)(this.FindName("txt_From")));
            this.txt_To = ((System.Windows.Controls.TextBox)(this.FindName("txt_To")));
            this.tbl_Distance = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Distance")));
            this.txt_Distance = ((System.Windows.Controls.TextBox)(this.FindName("txt_Distance")));
            this.tbl_TotalCost = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_TotalCost")));
            this.txt_TotalCost = ((System.Windows.Controls.TextBox)(this.FindName("txt_TotalCost")));
            this.tbl_PaymentType = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_PaymentType")));
            this.txt_PaymentType = ((System.Windows.Controls.TextBox)(this.FindName("txt_PaymentType")));
            this.pwd_Password = ((System.Windows.Controls.PasswordBox)(this.FindName("pwd_Password")));
            this.line1 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1")));
            this.line1_Copy = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy")));
            this.line1_Copy1 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy1")));
            this.img_Username = ((System.Windows.Controls.Image)(this.FindName("img_Username")));
            this.img_mobile = ((System.Windows.Controls.Image)(this.FindName("img_mobile")));
            this.img_From = ((System.Windows.Controls.Image)(this.FindName("img_From")));
            this.img_To = ((System.Windows.Controls.Image)(this.FindName("img_To")));
            this.line1_Copy2 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy2")));
            this.line1_Copy3 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy3")));
            this.line1_Copy4 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy4")));
            this.btn_AddFavorite = ((System.Windows.Controls.Button)(this.FindName("btn_AddFavorite")));
            this.tbl_CarLevel = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_CarLevel")));
            this.txt_CarLevel = ((System.Windows.Controls.TextBox)(this.FindName("txt_CarLevel")));
            this.img_Navbar = ((System.Windows.Controls.Image)(this.FindName("img_Navbar")));
            this.tbl_MyTrip = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_MyTrip")));
            this.grv_RiderLossAssets = ((System.Windows.Controls.Grid)(this.FindName("grv_RiderLossAssets")));
            this.img_header = ((System.Windows.Controls.Image)(this.FindName("img_header")));
            this.img_CloseRiderLostAsset = ((System.Windows.Controls.Image)(this.FindName("img_CloseRiderLostAsset")));
            this.txt_Content = ((System.Windows.Controls.TextBox)(this.FindName("txt_Content")));
            this.btn_SendLostAsset = ((System.Windows.Controls.Button)(this.FindName("btn_SendLostAsset")));
            this.grv_FunctionMenu = ((System.Windows.Controls.Grid)(this.FindName("grv_FunctionMenu")));
            this.btn_Cancel = ((System.Windows.Controls.Button)(this.FindName("btn_Cancel")));
            this.btn_AlertAssets = ((System.Windows.Controls.Button)(this.FindName("btn_AlertAssets")));
            this.btn_CallToDriver = ((System.Windows.Controls.Button)(this.FindName("btn_CallToDriver")));
            this.btn_ViewTripDetail = ((System.Windows.Controls.Button)(this.FindName("btn_ViewTripDetail")));
            this.grv_ButtonLoadingScreen = ((System.Windows.Controls.Grid)(this.FindName("grv_ButtonLoadingScreen")));
            this.rt_bg = ((System.Windows.Shapes.Rectangle)(this.FindName("rt_bg")));
            this.pb_loading = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_loading")));
            this.grv_ProcessScreen = ((System.Windows.Controls.Grid)(this.FindName("grv_ProcessScreen")));
            this.pb_ProcessBar = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_ProcessBar")));
            this.tbl_loading = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_loading")));
        }
    }
}
