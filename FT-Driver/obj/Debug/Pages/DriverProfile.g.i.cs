﻿#pragma checksum "H:\Hoc Tap\FPT Univerdity\Do an tot nghiep 2015\2015FALLIS01\Source Code\FTaxi_Project_FPT_Uiversity\FT-Driver\Pages\DriverProfile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "69703D9C8CB64ECE618DDE92FA46B2DA"
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
using Microsoft.Phone.Maps.Controls;
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


namespace FT_Driver.Pages {
    
    
    public partial class DriverProfile : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.DataTemplate lpkItemTemplate;
        
        internal System.Windows.DataTemplate lpkFullItemTemplate;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.DataTemplate PickerItemTemplate;
        
        internal System.Windows.DataTemplate PickerFullModeItemTemplate;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Shapes.Rectangle panel_name;
        
        internal System.Windows.Shapes.Rectangle panel_moreInfor;
        
        internal System.Windows.Shapes.Rectangle panel_AddAddress;
        
        internal System.Windows.Controls.TextBlock tbl_ChangePassword;
        
        internal System.Windows.Controls.TextBlock tbl_HomeAddress;
        
        internal System.Windows.Controls.TextBlock tbl_OfficeAddress;
        
        internal System.Windows.Controls.Image img_EditIcon_HomeAddress;
        
        internal System.Windows.Controls.StackPanel StckUserDetailsUI;
        
        internal System.Windows.Controls.Image img_Avatar;
        
        internal System.Windows.Controls.TextBlock txt_LastName;
        
        internal System.Windows.Controls.TextBlock txt_FirstName;
        
        internal System.Windows.Controls.TextBlock txt_Email;
        
        internal System.Windows.Controls.TextBlock txt_Mobile;
        
        internal System.Windows.Controls.TextBlock txt_Balance;
        
        internal System.Windows.Controls.Image img_UserFName;
        
        internal System.Windows.Controls.Image img_UserFName_Copy;
        
        internal System.Windows.Controls.Image img_UserFName_Copy1;
        
        internal System.Windows.Controls.Image img_UserFName_Copy2;
        
        internal System.Windows.Controls.Image img_UserFName_Copy3;
        
        internal System.Windows.Controls.Image icon_money;
        
        internal System.Windows.Shapes.Rectangle line1;
        
        internal System.Windows.Shapes.Rectangle line1_Copy;
        
        internal System.Windows.Shapes.Rectangle line1_Copy1;
        
        internal System.Windows.Shapes.Rectangle line1_Copy2;
        
        internal System.Windows.Shapes.Rectangle line1_Copy3;
        
        internal System.Windows.Controls.Image img_UserFName_Copy4;
        
        internal System.Windows.Controls.Image img_Navbar;
        
        internal System.Windows.Controls.TextBlock tbl_Profile;
        
        internal System.Windows.Controls.TextBlock tbl_Lang;
        
        internal System.Windows.Controls.Grid grv_AddHomeAddress;
        
        internal System.Windows.Controls.Image img_header;
        
        internal System.Windows.Controls.Image img_CloseHome;
        
        internal System.Windows.Controls.TextBox txt_HomeAddress;
        
        internal System.Windows.Controls.Button btn_SaveHome;
        
        internal System.Windows.Controls.TextBlock tbl_Address;
        
        internal System.Windows.Controls.Image img_CloseClearHomeAddress;
        
        internal Microsoft.Phone.Maps.Controls.Map map_HomeAddress;
        
        internal System.Windows.Controls.Image img_PickerPin;
        
        internal System.Windows.Controls.Image img_PickerLabel;
        
        internal Microsoft.Phone.Controls.LongListSelector lls_HomeAddress;
        
        internal System.Windows.Controls.Grid grv_OfficeAddress;
        
        internal System.Windows.Controls.Image img_header_Copy;
        
        internal System.Windows.Controls.Image img_CloseOffice;
        
        internal System.Windows.Controls.TextBlock tbl_OfficeAddress_Show;
        
        internal Microsoft.Phone.Maps.Controls.Map map_OfficeAddress;
        
        internal System.Windows.Controls.Image img_PickerPin1;
        
        internal System.Windows.Controls.Image img_PickerLabel1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FT-Driver;component/Pages/DriverProfile.xaml", System.UriKind.Relative));
            this.lpkItemTemplate = ((System.Windows.DataTemplate)(this.FindName("lpkItemTemplate")));
            this.lpkFullItemTemplate = ((System.Windows.DataTemplate)(this.FindName("lpkFullItemTemplate")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PickerItemTemplate = ((System.Windows.DataTemplate)(this.FindName("PickerItemTemplate")));
            this.PickerFullModeItemTemplate = ((System.Windows.DataTemplate)(this.FindName("PickerFullModeItemTemplate")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.panel_name = ((System.Windows.Shapes.Rectangle)(this.FindName("panel_name")));
            this.panel_moreInfor = ((System.Windows.Shapes.Rectangle)(this.FindName("panel_moreInfor")));
            this.panel_AddAddress = ((System.Windows.Shapes.Rectangle)(this.FindName("panel_AddAddress")));
            this.tbl_ChangePassword = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_ChangePassword")));
            this.tbl_HomeAddress = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_HomeAddress")));
            this.tbl_OfficeAddress = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_OfficeAddress")));
            this.img_EditIcon_HomeAddress = ((System.Windows.Controls.Image)(this.FindName("img_EditIcon_HomeAddress")));
            this.StckUserDetailsUI = ((System.Windows.Controls.StackPanel)(this.FindName("StckUserDetailsUI")));
            this.img_Avatar = ((System.Windows.Controls.Image)(this.FindName("img_Avatar")));
            this.txt_LastName = ((System.Windows.Controls.TextBlock)(this.FindName("txt_LastName")));
            this.txt_FirstName = ((System.Windows.Controls.TextBlock)(this.FindName("txt_FirstName")));
            this.txt_Email = ((System.Windows.Controls.TextBlock)(this.FindName("txt_Email")));
            this.txt_Mobile = ((System.Windows.Controls.TextBlock)(this.FindName("txt_Mobile")));
            this.txt_Balance = ((System.Windows.Controls.TextBlock)(this.FindName("txt_Balance")));
            this.img_UserFName = ((System.Windows.Controls.Image)(this.FindName("img_UserFName")));
            this.img_UserFName_Copy = ((System.Windows.Controls.Image)(this.FindName("img_UserFName_Copy")));
            this.img_UserFName_Copy1 = ((System.Windows.Controls.Image)(this.FindName("img_UserFName_Copy1")));
            this.img_UserFName_Copy2 = ((System.Windows.Controls.Image)(this.FindName("img_UserFName_Copy2")));
            this.img_UserFName_Copy3 = ((System.Windows.Controls.Image)(this.FindName("img_UserFName_Copy3")));
            this.icon_money = ((System.Windows.Controls.Image)(this.FindName("icon_money")));
            this.line1 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1")));
            this.line1_Copy = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy")));
            this.line1_Copy1 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy1")));
            this.line1_Copy2 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy2")));
            this.line1_Copy3 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy3")));
            this.img_UserFName_Copy4 = ((System.Windows.Controls.Image)(this.FindName("img_UserFName_Copy4")));
            this.img_Navbar = ((System.Windows.Controls.Image)(this.FindName("img_Navbar")));
            this.tbl_Profile = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Profile")));
            this.tbl_Lang = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Lang")));
            this.grv_AddHomeAddress = ((System.Windows.Controls.Grid)(this.FindName("grv_AddHomeAddress")));
            this.img_header = ((System.Windows.Controls.Image)(this.FindName("img_header")));
            this.img_CloseHome = ((System.Windows.Controls.Image)(this.FindName("img_CloseHome")));
            this.txt_HomeAddress = ((System.Windows.Controls.TextBox)(this.FindName("txt_HomeAddress")));
            this.btn_SaveHome = ((System.Windows.Controls.Button)(this.FindName("btn_SaveHome")));
            this.tbl_Address = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Address")));
            this.img_CloseClearHomeAddress = ((System.Windows.Controls.Image)(this.FindName("img_CloseClearHomeAddress")));
            this.map_HomeAddress = ((Microsoft.Phone.Maps.Controls.Map)(this.FindName("map_HomeAddress")));
            this.img_PickerPin = ((System.Windows.Controls.Image)(this.FindName("img_PickerPin")));
            this.img_PickerLabel = ((System.Windows.Controls.Image)(this.FindName("img_PickerLabel")));
            this.lls_HomeAddress = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("lls_HomeAddress")));
            this.grv_OfficeAddress = ((System.Windows.Controls.Grid)(this.FindName("grv_OfficeAddress")));
            this.img_header_Copy = ((System.Windows.Controls.Image)(this.FindName("img_header_Copy")));
            this.img_CloseOffice = ((System.Windows.Controls.Image)(this.FindName("img_CloseOffice")));
            this.tbl_OfficeAddress_Show = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_OfficeAddress_Show")));
            this.map_OfficeAddress = ((Microsoft.Phone.Maps.Controls.Map)(this.FindName("map_OfficeAddress")));
            this.img_PickerPin1 = ((System.Windows.Controls.Image)(this.FindName("img_PickerPin1")));
            this.img_PickerLabel1 = ((System.Windows.Controls.Image)(this.FindName("img_PickerLabel1")));
            this.grv_ProcessScreen = ((System.Windows.Controls.Grid)(this.FindName("grv_ProcessScreen")));
            this.rt_processBar = ((System.Windows.Shapes.Rectangle)(this.FindName("rt_processBar")));
            this.pb_ProcessBar = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_ProcessBar")));
            this.tbl_loading = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_loading")));
        }
    }
}

