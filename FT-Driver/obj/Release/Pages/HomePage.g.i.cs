﻿#pragma checksum "H:\Hoc Tap\FPT Univerdity\Do an tot nghiep 2015\2015FALLIS01\Source Code\FTaxi_Project_FPT_Uiversity\FT-Driver\Pages\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA98C8439EB7FE3630ABEEABB59EDB3A"
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
    
    
    public partial class HomePage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Canvas canvas;
        
        internal System.Windows.Media.Animation.Storyboard moveAnimation;
        
        internal System.Windows.Controls.Canvas LayoutRoot;
        
        internal System.Windows.Controls.Grid grv_Menu;
        
        internal System.Windows.Controls.Border bd_Menu;
        
        internal System.Windows.Controls.Image img_MenuAvatar;
        
        internal System.Windows.Controls.TextBlock tbl_LastName;
        
        internal System.Windows.Controls.TextBlock tbl_FirstName;
        
        internal System.Windows.Controls.TextBlock tbl_RegisterPromotionTrip;
        
        internal System.Windows.Controls.TextBlock tbl_PromotionTrips;
        
        internal System.Windows.Controls.TextBlock tbl_MyTrips;
        
        internal System.Windows.Controls.TextBlock tbl_VipRider;
        
        internal System.Windows.Controls.TextBlock tbl_CompanyInfo;
        
        internal System.Windows.Controls.TextBlock tbl_Support;
        
        internal System.Windows.Controls.TextBlock tbl_About;
        
        internal System.Windows.Controls.TextBlock tbl_Feedback;
        
        internal System.Windows.Controls.Button btn_Logout;
        
        internal System.Windows.Controls.Image img_MenuIcon1;
        
        internal System.Windows.Controls.Image img_MenuIcon2;
        
        internal System.Windows.Controls.Image img_MenuIcon3;
        
        internal System.Windows.Controls.Image img_MenuIcon4;
        
        internal System.Windows.Controls.Image img_MenuIcon5;
        
        internal System.Windows.Controls.Image img_MenuIcon6;
        
        internal System.Windows.Controls.Image img_MenuIcon7;
        
        internal System.Windows.Controls.Image img_MenuIcon8;
        
        internal System.Windows.Shapes.Rectangle line1;
        
        internal System.Windows.Shapes.Rectangle line1_Copy;
        
        internal System.Windows.Shapes.Rectangle line1_Copy1;
        
        internal System.Windows.Shapes.Rectangle line1_Copy2;
        
        internal System.Windows.Shapes.Rectangle line1_Copy3;
        
        internal System.Windows.Shapes.Rectangle line1_Copy4;
        
        internal System.Windows.Shapes.Rectangle line1_Copy5;
        
        internal System.Windows.Shapes.Rectangle line1_Copy6;
        
        internal System.Windows.Shapes.Rectangle line1_Copy7;
        
        internal System.Windows.Shapes.Rectangle line1_Copy8;
        
        internal System.Windows.Controls.Grid grv_HomePanel;
        
        internal System.Windows.Controls.Grid grv_navbar;
        
        internal System.Windows.Controls.Image img_Navbar;
        
        internal System.Windows.Controls.Image img_FtaxiLogo;
        
        internal System.Windows.Controls.Button btn_OpenMenu;
        
        internal System.Windows.Controls.Grid grv_Map;
        
        internal Microsoft.Phone.Maps.Controls.Map map_DriverMap;
        
        internal System.Windows.Controls.Grid grv_ChangeStatus;
        
        internal System.Windows.Controls.Button btn_ChangeStatus;
        
        internal System.Windows.Controls.Grid grv_AcceptReject;
        
        internal System.Windows.Controls.Image img_AcceptRejectBG;
        
        internal System.Windows.Controls.Image img_RiderAvatarAvatar;
        
        internal System.Windows.Controls.TextBlock txt_RiderName;
        
        internal System.Windows.Controls.TextBlock txt_RiderMobile;
        
        internal System.Windows.Controls.TextBlock txt_RiderAddress;
        
        internal System.Windows.Controls.Grid grv_AcceptRejectbtn;
        
        internal System.Windows.Controls.Button btn_AcceptTrip;
        
        internal System.Windows.Controls.Button btn_RejectTrip;
        
        internal System.Windows.Controls.Grid grv_StartCancelbtn;
        
        internal System.Windows.Controls.Button btn_StartTrip;
        
        internal System.Windows.Controls.Button btn_CancelTrip;
        
        internal System.Windows.Controls.Grid grv_LoadingGridScreen;
        
        internal System.Windows.Shapes.Rectangle rg_PleaseWaitBG;
        
        internal System.Windows.Controls.ProgressBar pb_ButtonPleaseWait;
        
        internal System.Windows.Controls.Grid grv_RiderCancel;
        
        internal System.Windows.Shapes.Rectangle rg_CancelNotificationBG;
        
        internal System.Windows.Controls.Button btn_ConfirmCancelFromRider;
        
        internal System.Windows.Controls.Image img_CanceledTrip;
        
        internal System.Windows.Controls.TextBlock tbl_RiderCanceled;
        
        internal System.Windows.Controls.Grid grv_StartTrip;
        
        internal System.Windows.Controls.Image img_StartTripBG;
        
        internal System.Windows.Controls.Image img_PriceBar;
        
        internal System.Windows.Controls.Button btn_TapToPay;
        
        internal System.Windows.Controls.TextBlock txt_DistanceKm;
        
        internal System.Windows.Controls.TextBlock txt_PricePerDistance;
        
        internal System.Windows.Controls.TextBlock txt_RiderNameStartTrip;
        
        internal System.Windows.Controls.TextBlock txt_PromotionPrice;
        
        internal System.Windows.Controls.TextBlock txt_TotalPrice;
        
        internal System.Windows.Controls.Grid grv_TapToPayProcess;
        
        internal System.Windows.Shapes.Rectangle rt_bg;
        
        internal System.Windows.Controls.ProgressBar pb_TapToPay;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FT-Driver;component/Pages/HomePage.xaml", System.UriKind.Relative));
            this.canvas = ((System.Windows.Controls.Canvas)(this.FindName("canvas")));
            this.moveAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("moveAnimation")));
            this.LayoutRoot = ((System.Windows.Controls.Canvas)(this.FindName("LayoutRoot")));
            this.grv_Menu = ((System.Windows.Controls.Grid)(this.FindName("grv_Menu")));
            this.bd_Menu = ((System.Windows.Controls.Border)(this.FindName("bd_Menu")));
            this.img_MenuAvatar = ((System.Windows.Controls.Image)(this.FindName("img_MenuAvatar")));
            this.tbl_LastName = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_LastName")));
            this.tbl_FirstName = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_FirstName")));
            this.tbl_RegisterPromotionTrip = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_RegisterPromotionTrip")));
            this.tbl_PromotionTrips = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_PromotionTrips")));
            this.tbl_MyTrips = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_MyTrips")));
            this.tbl_VipRider = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_VipRider")));
            this.tbl_CompanyInfo = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_CompanyInfo")));
            this.tbl_Support = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Support")));
            this.tbl_About = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_About")));
            this.tbl_Feedback = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_Feedback")));
            this.btn_Logout = ((System.Windows.Controls.Button)(this.FindName("btn_Logout")));
            this.img_MenuIcon1 = ((System.Windows.Controls.Image)(this.FindName("img_MenuIcon1")));
            this.img_MenuIcon2 = ((System.Windows.Controls.Image)(this.FindName("img_MenuIcon2")));
            this.img_MenuIcon3 = ((System.Windows.Controls.Image)(this.FindName("img_MenuIcon3")));
            this.img_MenuIcon4 = ((System.Windows.Controls.Image)(this.FindName("img_MenuIcon4")));
            this.img_MenuIcon5 = ((System.Windows.Controls.Image)(this.FindName("img_MenuIcon5")));
            this.img_MenuIcon6 = ((System.Windows.Controls.Image)(this.FindName("img_MenuIcon6")));
            this.img_MenuIcon7 = ((System.Windows.Controls.Image)(this.FindName("img_MenuIcon7")));
            this.img_MenuIcon8 = ((System.Windows.Controls.Image)(this.FindName("img_MenuIcon8")));
            this.line1 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1")));
            this.line1_Copy = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy")));
            this.line1_Copy1 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy1")));
            this.line1_Copy2 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy2")));
            this.line1_Copy3 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy3")));
            this.line1_Copy4 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy4")));
            this.line1_Copy5 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy5")));
            this.line1_Copy6 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy6")));
            this.line1_Copy7 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy7")));
            this.line1_Copy8 = ((System.Windows.Shapes.Rectangle)(this.FindName("line1_Copy8")));
            this.grv_HomePanel = ((System.Windows.Controls.Grid)(this.FindName("grv_HomePanel")));
            this.grv_navbar = ((System.Windows.Controls.Grid)(this.FindName("grv_navbar")));
            this.img_Navbar = ((System.Windows.Controls.Image)(this.FindName("img_Navbar")));
            this.img_FtaxiLogo = ((System.Windows.Controls.Image)(this.FindName("img_FtaxiLogo")));
            this.btn_OpenMenu = ((System.Windows.Controls.Button)(this.FindName("btn_OpenMenu")));
            this.grv_Map = ((System.Windows.Controls.Grid)(this.FindName("grv_Map")));
            this.map_DriverMap = ((Microsoft.Phone.Maps.Controls.Map)(this.FindName("map_DriverMap")));
            this.grv_ChangeStatus = ((System.Windows.Controls.Grid)(this.FindName("grv_ChangeStatus")));
            this.btn_ChangeStatus = ((System.Windows.Controls.Button)(this.FindName("btn_ChangeStatus")));
            this.grv_AcceptReject = ((System.Windows.Controls.Grid)(this.FindName("grv_AcceptReject")));
            this.img_AcceptRejectBG = ((System.Windows.Controls.Image)(this.FindName("img_AcceptRejectBG")));
            this.img_RiderAvatarAvatar = ((System.Windows.Controls.Image)(this.FindName("img_RiderAvatarAvatar")));
            this.txt_RiderName = ((System.Windows.Controls.TextBlock)(this.FindName("txt_RiderName")));
            this.txt_RiderMobile = ((System.Windows.Controls.TextBlock)(this.FindName("txt_RiderMobile")));
            this.txt_RiderAddress = ((System.Windows.Controls.TextBlock)(this.FindName("txt_RiderAddress")));
            this.grv_AcceptRejectbtn = ((System.Windows.Controls.Grid)(this.FindName("grv_AcceptRejectbtn")));
            this.btn_AcceptTrip = ((System.Windows.Controls.Button)(this.FindName("btn_AcceptTrip")));
            this.btn_RejectTrip = ((System.Windows.Controls.Button)(this.FindName("btn_RejectTrip")));
            this.grv_StartCancelbtn = ((System.Windows.Controls.Grid)(this.FindName("grv_StartCancelbtn")));
            this.btn_StartTrip = ((System.Windows.Controls.Button)(this.FindName("btn_StartTrip")));
            this.btn_CancelTrip = ((System.Windows.Controls.Button)(this.FindName("btn_CancelTrip")));
            this.grv_LoadingGridScreen = ((System.Windows.Controls.Grid)(this.FindName("grv_LoadingGridScreen")));
            this.rg_PleaseWaitBG = ((System.Windows.Shapes.Rectangle)(this.FindName("rg_PleaseWaitBG")));
            this.pb_ButtonPleaseWait = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_ButtonPleaseWait")));
            this.grv_RiderCancel = ((System.Windows.Controls.Grid)(this.FindName("grv_RiderCancel")));
            this.rg_CancelNotificationBG = ((System.Windows.Shapes.Rectangle)(this.FindName("rg_CancelNotificationBG")));
            this.btn_ConfirmCancelFromRider = ((System.Windows.Controls.Button)(this.FindName("btn_ConfirmCancelFromRider")));
            this.img_CanceledTrip = ((System.Windows.Controls.Image)(this.FindName("img_CanceledTrip")));
            this.tbl_RiderCanceled = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_RiderCanceled")));
            this.grv_StartTrip = ((System.Windows.Controls.Grid)(this.FindName("grv_StartTrip")));
            this.img_StartTripBG = ((System.Windows.Controls.Image)(this.FindName("img_StartTripBG")));
            this.img_PriceBar = ((System.Windows.Controls.Image)(this.FindName("img_PriceBar")));
            this.btn_TapToPay = ((System.Windows.Controls.Button)(this.FindName("btn_TapToPay")));
            this.txt_DistanceKm = ((System.Windows.Controls.TextBlock)(this.FindName("txt_DistanceKm")));
            this.txt_PricePerDistance = ((System.Windows.Controls.TextBlock)(this.FindName("txt_PricePerDistance")));
            this.txt_RiderNameStartTrip = ((System.Windows.Controls.TextBlock)(this.FindName("txt_RiderNameStartTrip")));
            this.txt_PromotionPrice = ((System.Windows.Controls.TextBlock)(this.FindName("txt_PromotionPrice")));
            this.txt_TotalPrice = ((System.Windows.Controls.TextBlock)(this.FindName("txt_TotalPrice")));
            this.grv_TapToPayProcess = ((System.Windows.Controls.Grid)(this.FindName("grv_TapToPayProcess")));
            this.rt_bg = ((System.Windows.Shapes.Rectangle)(this.FindName("rt_bg")));
            this.pb_TapToPay = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_TapToPay")));
            this.grv_ProcessScreen = ((System.Windows.Controls.Grid)(this.FindName("grv_ProcessScreen")));
            this.rt_processBar = ((System.Windows.Shapes.Rectangle)(this.FindName("rt_processBar")));
            this.pb_ProcessBar = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_ProcessBar")));
            this.tbl_loading = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_loading")));
        }
    }
}

