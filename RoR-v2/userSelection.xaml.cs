﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp1
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void doctorButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/doctorSignInScreen.xaml", UriKind.Relative));
        }

        private void patientButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/patientLandingPage.xaml", UriKind.Relative));
        }
    }
}