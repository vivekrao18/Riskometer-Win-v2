﻿#pragma checksum "C:\Users\Vivek\Documents\Visual Studio 2013\Projects\PhoneApp1\PhoneApp1\ResultsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C789B295C0396A90E98F35B9E2B5E384"
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
    
    
    public partial class ResultsPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Canvas graphCanvas;
        
        internal System.Windows.Controls.StackPanel graphStack;
        
        internal System.Windows.Controls.TextBlock graphProbability;
        
        internal System.Windows.Shapes.Rectangle graphBar;
        
        internal System.Windows.Controls.TextBlock Probability;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.TextBlock disclaimer;
        
        internal System.Windows.Controls.TextBlock Prob;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/ResultsPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.graphCanvas = ((System.Windows.Controls.Canvas)(this.FindName("graphCanvas")));
            this.graphStack = ((System.Windows.Controls.StackPanel)(this.FindName("graphStack")));
            this.graphProbability = ((System.Windows.Controls.TextBlock)(this.FindName("graphProbability")));
            this.graphBar = ((System.Windows.Shapes.Rectangle)(this.FindName("graphBar")));
            this.Probability = ((System.Windows.Controls.TextBlock)(this.FindName("Probability")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.disclaimer = ((System.Windows.Controls.TextBlock)(this.FindName("disclaimer")));
            this.Prob = ((System.Windows.Controls.TextBlock)(this.FindName("Prob")));
        }
    }
}

