﻿#pragma checksum "H:\Hoc Tap\FPT Univerdity\Do an tot nghiep 2015\2015FALLIS01\Source Code\FTaxi_Project_FPT_Uiversity\FT-Rider\Pages\RiderAddHomePlace.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B2EDC6C8229576100147C74537C218BE"
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
    
    
    public partial class RiderAddHomePlace : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txt_Address;
        
        internal System.Windows.Controls.TextBox txt_City;
        
        internal System.Windows.Controls.Button btn_Save;
        
        internal System.Windows.Shapes.Rectangle rt_AddressBG;
        
        internal System.Windows.Controls.Image img_TextboxIcon;
        
        internal System.Windows.Controls.Image img_TextboxIcon_Copy1;
        
        internal Microsoft.Phone.Maps.Controls.Map map_RiderHome;
        
        internal Microsoft.Phone.Controls.LongListSelector lls_AutoComplete;
        
        internal System.Windows.Controls.Image img_ClearText;
        
        internal System.Windows.Controls.Grid grv_ProcessScreen;
        
        internal System.Windows.Shapes.Rectangle rt_processBar;
        
        internal System.Windows.Controls.ProgressBar pb_ProcessBar;
        
        internal System.Windows.Controls.TextBlock tbl_loading;
        
        internal System.Windows.Controls.Image img_Navbar;
        
        internal System.Windows.Controls.TextBlock tbl_AddHomePlace;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FT-Rider;component/Pages/RiderAddHomePlace.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txt_Address = ((System.Windows.Controls.TextBox)(this.FindName("txt_Address")));
            this.txt_City = ((System.Windows.Controls.TextBox)(this.FindName("txt_City")));
            this.btn_Save = ((System.Windows.Controls.Button)(this.FindName("btn_Save")));
            this.rt_AddressBG = ((System.Windows.Shapes.Rectangle)(this.FindName("rt_AddressBG")));
            this.img_TextboxIcon = ((System.Windows.Controls.Image)(this.FindName("img_TextboxIcon")));
            this.img_TextboxIcon_Copy1 = ((System.Windows.Controls.Image)(this.FindName("img_TextboxIcon_Copy1")));
            this.map_RiderHome = ((Microsoft.Phone.Maps.Controls.Map)(this.FindName("map_RiderHome")));
            this.lls_AutoComplete = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("lls_AutoComplete")));
            this.img_ClearText = ((System.Windows.Controls.Image)(this.FindName("img_ClearText")));
            this.grv_ProcessScreen = ((System.Windows.Controls.Grid)(this.FindName("grv_ProcessScreen")));
            this.rt_processBar = ((System.Windows.Shapes.Rectangle)(this.FindName("rt_processBar")));
            this.pb_ProcessBar = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_ProcessBar")));
            this.tbl_loading = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_loading")));
            this.img_Navbar = ((System.Windows.Controls.Image)(this.FindName("img_Navbar")));
            this.tbl_AddHomePlace = ((System.Windows.Controls.TextBlock)(this.FindName("tbl_AddHomePlace")));
        }
    }
}

