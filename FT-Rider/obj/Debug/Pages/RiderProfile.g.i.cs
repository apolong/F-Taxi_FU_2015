﻿#pragma checksum "H:\Hoc Tap\FPT Univerdity\Do an tot nghiep 2015\2015FALLIS01\Source Code\FTaxi_Project_FPT_Uiversity\FT-Rider\Pages\RiderProfile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "03491F85A449E511EEEB3B6518E73440"
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


namespace FT_Rider.Pages {
    
    
    public partial class RiderProfile : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.DataTemplate lpkItemTemplate;
        
        internal System.Windows.DataTemplate lpkFullItemTemplate;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Shapes.Rectangle panel_name;
        
        internal System.Windows.Shapes.Rectangle panel_moreInfor;
        
        internal System.Windows.Shapes.Rectangle panel_AddAddress;
        
        internal System.Windows.Controls.TextBlock tbl_ChangePassword;
        
        internal System.Windows.Shapes.Rectangle line1;
        
        internal System.Windows.Shapes.Rectangle line2;
        
        internal System.Windows.Shapes.Rectangle line3;
        
        internal System.Windows.Shapes.Rectangle line4;
        
        internal System.Windows.Controls.TextBlock tbl_HomeAddress;
        
        internal System.Windows.Controls.TextBlock tbl_OfficeAddress;
        
        internal System.Windows.Controls.Image img_EditIcon_HomeAddress;
        
        internal System.Windows.Controls.Image img_EditIcon_OfficeAddress;
        
        internal System.Windows.Controls.StackPanel StckUserDetailsUI;
        
        internal Microsoft.Phone.Controls.ListPicker lpk_Language;
        
        internal System.Windows.Controls.Image img_Avatar;
        
        internal System.Windows.Controls.TextBox txt_Email;
        
        internal System.Windows.Controls.TextBox txt_FirstName;
        
        internal System.Windows.Controls.TextBox txt_Mobile;
        
        internal System.Windows.Controls.TextBox txt_LastName;
        
        internal System.Windows.Controls.TextBox txt_Lang;
        
        internal System.Windows.Controls.TextBlock tbl_Lang;
        
        internal System.Windows.Controls.Image img_UserFName;
        
        internal System.Windows.Controls.Image img_UserFName_Copy;
        
        internal System.Windows.Controls.Image img_UserFName_Copy1;
        
        internal System.Windows.Controls.Image img_UserFName_Copy2;
        
        internal System.Windows.Controls.Image img_UserFName_Copy3;
        
        internal System.Windows.Controls.Image img_UserFName_Copy4;
        
        internal System.Windows.Controls.Image img_Navbar;
        
        internal System.Windows.Controls.TextBlock tbl_Profile;
        
        internal System.Windows.Controls.Button btn_Save;
        
        internal System.Windows.Controls.Button btn_Edit;
        
        internal System.Windows.Controls.Grid grv_AddHomeAddress;
        
        internal System.Windows.Controls.Image img_header;
        
        internal System.Windows.Controls.Image img_CloseHome;
        
        internal System.Windows.Controls.TextBox txt_HomeAddress;
        
        internal System.Windows.Controls.Button btn_SaveHome;
        
        internal System.Windows.Controls.TextBlock tbl_Account;
        
        internal System.Windows.Controls.Image img_CloseClearHomeAddress;
        
        internal Microsoft.Phone.Maps.Controls.Map map_HomeAddress;
        
        internal System.Windows.Controls.Image img_PickerPin;
        
        internal System.Windows.Controls.Image img_PickerLabel;
        
        internal Microsoft.Phone.Controls.LongListSelector lls_HomeAddress;
        
        internal System.Windows.Controls.Grid grv_AddOfficeAddress;
        
        internal System.Windows.Controls.Image img_header1;
        
        internal System.Windows.Controls.Image img_CloseOffice;
        
        internal System.Windows.Controls.TextBox txt_OfficeAddress;
        
        internal System.Windows.Controls.Button btn_SaveOffice;
        
        internal System.Windows.Controls.TextBlock tbl_Office;
        
        internal System.Windows.Controls.Image img_CloseClearOfficeAddress;
        
        internal Microsoft.Phone.Maps.Controls.Map map_OfficeAddress;
        
        internal System.Windows.Controls.Image img_PickerPin1;
        
        internal System.Windows.Controls.Image img_PickerLabel1;
        
        internal Microsoft.Phone.Controls.LongListSelector lls_OfficeAddress;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FT-Rider;component/Pages/RiderProfile.xaml", System.UriKind.Relative));
            this.lpkItemTemplate = ((System.Windows.DataTemplate)(this.FindName("lpkItemTemplate")));
            this.lpkFullItemTemplate = ((System.Windows.DataTemplate)(this.FindName("lpkFullItemTemplate")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.panel_name = ((System.Windows.Shapes.Rectangle)(this.FindName("panel_name")));
            this.panel_moreInfor = ((System.Windows.Shapes.Rectangle)(this.FindName("panel_moreInfor")));
            this.panel_AddAddress = ((System.Windows.Shapes.Rectangle)(this.FindName("panel_AddAddress")));
            this.tbl_ChangePassword = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_ChangePassword")));
            this.line1 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1")));
            this.line2 = ((System.Windows.Shapes.Rectangle)(this.FindName("line2")));
            this.line3 = ((System.Windows.Shapes.Rectangle)(this.FindName("line3")));
            this.line4 = ((System.Windows.Shapes.Rectangle)(this.FindName("line4")));
            this.tbl_HomeAddress = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_HomeAddress")));
            this.tbl_OfficeAddress = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_OfficeAddress")));
            this.img_EditIcon_HomeAddress = ((System.Windows.Controls.Image)(this.FindName("img_EditIcon_HomeAddress")));
            this.img_EditIcon_OfficeAddress = ((System.Windows.Controls.Image)(this.FindName("img_EditIcon_OfficeAddress")));
            this.StckUserDetailsUI = ((System.Windows.Controls.StackPanel)(this.FindName("StckUserDetailsUI")));
            this.lpk_Language = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lpk_Language")));
            this.img_Avatar = ((System.Windows.Controls.Image)(this.FindName("img_Avatar")));
            this.txt_Email = ((System.Windows.Controls.TextBox)(this.FindName("txt_Email")));
            this.txt_FirstName = ((System.Windows.Controls.TextBox)(this.FindName("txt_FirstName")));
            this.txt_Mobile = ((System.Windows.Controls.TextBox)(this.FindName("txt_Mobile")));
            this.txt_LastName = ((System.Windows.Controls.TextBox)(this.FindName("txt_LastName")));
            this.txt_Lang = ((System.Windows.Controls.TextBox)(this.FindName("txt_Lang")));
            this.tbl_Lang = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Lang")));
            this.img_UserFName = ((System.Windows.Controls.Image)(this.FindName("img_UserFName")));
            this.img_UserFName_Copy = ((System.Windows.Controls.Image)(this.FindName("img_UserFName_Copy")));
            this.img_UserFName_Copy1 = ((System.Windows.Controls.Image)(this.FindName("img_UserFName_Copy1")));
            this.img_UserFName_Copy2 = ((System.Windows.Controls.Image)(this.FindName("img_UserFName_Copy2")));
            this.img_UserFName_Copy3 = ((System.Windows.Controls.Image)(this.FindName("img_UserFName_Copy3")));
            this.img_UserFName_Copy4 = ((System.Windows.Controls.Image)(this.FindName("img_UserFName_Copy4")));
            this.img_Navbar = ((System.Windows.Controls.Image)(this.FindName("img_Navbar")));
            this.tbl_Profile = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Profile")));
            this.btn_Save = ((System.Windows.Controls.Button)(this.FindName("btn_Save")));
            this.btn_Edit = ((System.Windows.Controls.Button)(this.FindName("btn_Edit")));
            this.grv_AddHomeAddress = ((System.Windows.Controls.Grid)(this.FindName("grv_AddHomeAddress")));
            this.img_header = ((System.Windows.Controls.Image)(this.FindName("img_header")));
            this.img_CloseHome = ((System.Windows.Controls.Image)(this.FindName("img_CloseHome")));
            this.txt_HomeAddress = ((System.Windows.Controls.TextBox)(this.FindName("txt_HomeAddress")));
            this.btn_SaveHome = ((System.Windows.Controls.Button)(this.FindName("btn_SaveHome")));
            this.tbl_Account = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Account")));
            this.img_CloseClearHomeAddress = ((System.Windows.Controls.Image)(this.FindName("img_CloseClearHomeAddress")));
            this.map_HomeAddress = ((Microsoft.Phone.Maps.Controls.Map)(this.FindName("map_HomeAddress")));
            this.img_PickerPin = ((System.Windows.Controls.Image)(this.FindName("img_PickerPin")));
            this.img_PickerLabel = ((System.Windows.Controls.Image)(this.FindName("img_PickerLabel")));
            this.lls_HomeAddress = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("lls_HomeAddress")));
            this.grv_AddOfficeAddress = ((System.Windows.Controls.Grid)(this.FindName("grv_AddOfficeAddress")));
            this.img_header1 = ((System.Windows.Controls.Image)(this.FindName("img_header1")));
            this.img_CloseOffice = ((System.Windows.Controls.Image)(this.FindName("img_CloseOffice")));
            this.txt_OfficeAddress = ((System.Windows.Controls.TextBox)(this.FindName("txt_OfficeAddress")));
            this.btn_SaveOffice = ((System.Windows.Controls.Button)(this.FindName("btn_SaveOffice")));
            this.tbl_Office = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Office")));
            this.img_CloseClearOfficeAddress = ((System.Windows.Controls.Image)(this.FindName("img_CloseClearOfficeAddress")));
            this.map_OfficeAddress = ((Microsoft.Phone.Maps.Controls.Map)(this.FindName("map_OfficeAddress")));
            this.img_PickerPin1 = ((System.Windows.Controls.Image)(this.FindName("img_PickerPin1")));
            this.img_PickerLabel1 = ((System.Windows.Controls.Image)(this.FindName("img_PickerLabel1")));
            this.lls_OfficeAddress = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("lls_OfficeAddress")));
            this.grv_ProcessScreen = ((System.Windows.Controls.Grid)(this.FindName("grv_ProcessScreen")));
            this.rt_processBar = ((System.Windows.Shapes.Rectangle)(this.FindName("rt_processBar")));
            this.pb_ProcessBar = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_ProcessBar")));
            this.tbl_loading = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_loading")));
        }
    }
}

