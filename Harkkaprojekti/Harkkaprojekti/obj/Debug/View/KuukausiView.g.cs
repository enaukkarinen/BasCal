﻿#pragma checksum "C:\GitProjects\BasCal\Harkkaprojekti\Harkkaprojekti\View\KuukausiView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1DBFDCC26881D84CB16CE525852A90FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Harkkaprojekti.View {
    
    
    public partial class KuukausiView : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid headerGrid;
        
        internal System.Windows.Controls.TextBlock testBlock;
        
        internal System.Windows.Controls.Grid mainGrid;
        
        internal System.Windows.Controls.DataGrid kalenteriGrid;
        
        internal System.Windows.Controls.ListBox listboxUpcomingEvents;
        
        internal System.Windows.Controls.Button btn1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Harkkaprojekti;component/View/KuukausiView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.headerGrid = ((System.Windows.Controls.Grid)(this.FindName("headerGrid")));
            this.testBlock = ((System.Windows.Controls.TextBlock)(this.FindName("testBlock")));
            this.mainGrid = ((System.Windows.Controls.Grid)(this.FindName("mainGrid")));
            this.kalenteriGrid = ((System.Windows.Controls.DataGrid)(this.FindName("kalenteriGrid")));
            this.listboxUpcomingEvents = ((System.Windows.Controls.ListBox)(this.FindName("listboxUpcomingEvents")));
            this.btn1 = ((System.Windows.Controls.Button)(this.FindName("btn1")));
        }
    }
}

