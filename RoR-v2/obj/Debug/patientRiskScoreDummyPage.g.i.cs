﻿#pragma checksum "C:\Users\Vivek\Documents\Visual Studio 2013\Projects\PhoneApp1\PhoneApp1\patientRiskScoreDummyPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9CE35C0053A3BEBE78C69446C00E093B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace PhoneApp1 {
    
    
    public partial class patientRiskScoreDummyPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot resultsPatient;
        
        internal Microsoft.Phone.Controls.PivotItem patientNameInHeading;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock Score;
        
        internal System.Windows.Controls.TextBlock anemia;
        
        internal System.Windows.Controls.TextBlock dialysis;
        
        internal System.Windows.Controls.TextBlock cardio;
        
        internal System.Windows.Controls.CheckBox monitorPatient;
        
        internal Microsoft.Phone.Controls.PivotItem anemiaPivot;
        
        internal Microsoft.Phone.Controls.PivotItem dialysisPivot;
        
        internal Microsoft.Phone.Controls.PivotItem cardioPivot;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/patientRiskScoreDummyPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.resultsPatient = ((Microsoft.Phone.Controls.Pivot)(this.FindName("resultsPatient")));
            this.patientNameInHeading = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("patientNameInHeading")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Score = ((System.Windows.Controls.TextBlock)(this.FindName("Score")));
            this.anemia = ((System.Windows.Controls.TextBlock)(this.FindName("anemia")));
            this.dialysis = ((System.Windows.Controls.TextBlock)(this.FindName("dialysis")));
            this.cardio = ((System.Windows.Controls.TextBlock)(this.FindName("cardio")));
            this.monitorPatient = ((System.Windows.Controls.CheckBox)(this.FindName("monitorPatient")));
            this.anemiaPivot = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("anemiaPivot")));
            this.dialysisPivot = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("dialysisPivot")));
            this.cardioPivot = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("cardioPivot")));
        }
    }
}

