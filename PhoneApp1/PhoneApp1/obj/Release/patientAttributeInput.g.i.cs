﻿#pragma checksum "C:\Users\Vivek\Documents\Visual Studio 2013\Projects\PhoneApp1\PhoneApp1\patientAttributeInput.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "58EE3402BA1FA7197094225A812DFE1E"
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
    
    
    public partial class patientAttributeInput : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot UserNavigation;
        
        internal Microsoft.Phone.Controls.PivotItem Age;
        
        internal Microsoft.Phone.Controls.PhoneTextBox userEnteredAge;
        
        internal Microsoft.Phone.Controls.PivotItem Gender;
        
        internal System.Windows.Controls.Button Male;
        
        internal System.Windows.Controls.Button Female;
        
        internal Microsoft.Phone.Controls.PivotItem Race;
        
        internal System.Windows.Controls.RadioButton AfricanAmerican;
        
        internal System.Windows.Controls.RadioButton AmericanIndian;
        
        internal System.Windows.Controls.RadioButton Asian;
        
        internal System.Windows.Controls.RadioButton Caucasian;
        
        internal System.Windows.Controls.RadioButton HispanicLatino;
        
        internal System.Windows.Controls.RadioButton MultiRacial;
        
        internal System.Windows.Controls.RadioButton PacificIslander;
        
        internal System.Windows.Controls.RadioButton Others;
        
        internal Microsoft.Phone.Controls.PivotItem PriorToHospitalization;
        
        internal System.Windows.Controls.Button HospitalizationYes;
        
        internal System.Windows.Controls.Button HospitalizationNo;
        
        internal Microsoft.Phone.Controls.PivotItem LengthOfStay;
        
        internal Microsoft.Phone.Controls.PhoneTextBox lengthofstay;
        
        internal Microsoft.Phone.Controls.PivotItem Diabetes;
        
        internal System.Windows.Controls.Button DiabetesYes;
        
        internal System.Windows.Controls.Button DiabetesNo;
        
        internal Microsoft.Phone.Controls.PivotItem Stroke;
        
        internal System.Windows.Controls.Button StrokeYes;
        
        internal System.Windows.Controls.Button StrokeNo;
        
        internal Microsoft.Phone.Controls.PivotItem BP;
        
        internal System.Windows.Controls.RadioButton BPC1;
        
        internal System.Windows.Controls.RadioButton BPC2;
        
        internal System.Windows.Controls.RadioButton BPC3;
        
        internal System.Windows.Controls.RadioButton BPC4;
        
        internal System.Windows.Controls.RadioButton BPC5;
        
        internal System.Windows.Controls.RadioButton BPC6;
        
        internal System.Windows.Controls.RadioButton BPC7;
        
        internal System.Windows.Controls.RadioButton BPC8;
        
        internal System.Windows.Controls.RadioButton BPC9;
        
        internal System.Windows.Controls.RadioButton BPC10;
        
        internal Microsoft.Phone.Controls.PivotItem BMI;
        
        internal Microsoft.Phone.Controls.PhoneTextBox userEnteredBMI;
        
        internal System.Windows.Controls.Button nextButtonBMI;
        
        internal Microsoft.Phone.Controls.PivotItem EFV;
        
        internal Microsoft.Phone.Controls.PhoneTextBox userEnteredEFV;
        
        internal System.Windows.Controls.Button calculateRiskButton;
        
        internal System.Windows.Controls.Button CalculateRisk;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/patientAttributeInput.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.UserNavigation = ((Microsoft.Phone.Controls.Pivot)(this.FindName("UserNavigation")));
            this.Age = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("Age")));
            this.userEnteredAge = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("userEnteredAge")));
            this.Gender = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("Gender")));
            this.Male = ((System.Windows.Controls.Button)(this.FindName("Male")));
            this.Female = ((System.Windows.Controls.Button)(this.FindName("Female")));
            this.Race = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("Race")));
            this.AfricanAmerican = ((System.Windows.Controls.RadioButton)(this.FindName("AfricanAmerican")));
            this.AmericanIndian = ((System.Windows.Controls.RadioButton)(this.FindName("AmericanIndian")));
            this.Asian = ((System.Windows.Controls.RadioButton)(this.FindName("Asian")));
            this.Caucasian = ((System.Windows.Controls.RadioButton)(this.FindName("Caucasian")));
            this.HispanicLatino = ((System.Windows.Controls.RadioButton)(this.FindName("HispanicLatino")));
            this.MultiRacial = ((System.Windows.Controls.RadioButton)(this.FindName("MultiRacial")));
            this.PacificIslander = ((System.Windows.Controls.RadioButton)(this.FindName("PacificIslander")));
            this.Others = ((System.Windows.Controls.RadioButton)(this.FindName("Others")));
            this.PriorToHospitalization = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("PriorToHospitalization")));
            this.HospitalizationYes = ((System.Windows.Controls.Button)(this.FindName("HospitalizationYes")));
            this.HospitalizationNo = ((System.Windows.Controls.Button)(this.FindName("HospitalizationNo")));
            this.LengthOfStay = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("LengthOfStay")));
            this.lengthofstay = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("lengthofstay")));
            this.Diabetes = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("Diabetes")));
            this.DiabetesYes = ((System.Windows.Controls.Button)(this.FindName("DiabetesYes")));
            this.DiabetesNo = ((System.Windows.Controls.Button)(this.FindName("DiabetesNo")));
            this.Stroke = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("Stroke")));
            this.StrokeYes = ((System.Windows.Controls.Button)(this.FindName("StrokeYes")));
            this.StrokeNo = ((System.Windows.Controls.Button)(this.FindName("StrokeNo")));
            this.BP = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("BP")));
            this.BPC1 = ((System.Windows.Controls.RadioButton)(this.FindName("BPC1")));
            this.BPC2 = ((System.Windows.Controls.RadioButton)(this.FindName("BPC2")));
            this.BPC3 = ((System.Windows.Controls.RadioButton)(this.FindName("BPC3")));
            this.BPC4 = ((System.Windows.Controls.RadioButton)(this.FindName("BPC4")));
            this.BPC5 = ((System.Windows.Controls.RadioButton)(this.FindName("BPC5")));
            this.BPC6 = ((System.Windows.Controls.RadioButton)(this.FindName("BPC6")));
            this.BPC7 = ((System.Windows.Controls.RadioButton)(this.FindName("BPC7")));
            this.BPC8 = ((System.Windows.Controls.RadioButton)(this.FindName("BPC8")));
            this.BPC9 = ((System.Windows.Controls.RadioButton)(this.FindName("BPC9")));
            this.BPC10 = ((System.Windows.Controls.RadioButton)(this.FindName("BPC10")));
            this.BMI = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("BMI")));
            this.userEnteredBMI = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("userEnteredBMI")));
            this.nextButtonBMI = ((System.Windows.Controls.Button)(this.FindName("nextButtonBMI")));
            this.EFV = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("EFV")));
            this.userEnteredEFV = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("userEnteredEFV")));
            this.calculateRiskButton = ((System.Windows.Controls.Button)(this.FindName("calculateRiskButton")));
            this.CalculateRisk = ((System.Windows.Controls.Button)(this.FindName("CalculateRisk")));
        }
    }
}

