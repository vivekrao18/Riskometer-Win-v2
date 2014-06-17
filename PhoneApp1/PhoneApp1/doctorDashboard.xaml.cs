using System;
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
    public partial class PivotPage1 : PhoneApplicationPage
    {
        String username;
        public PivotPage1()
        {
            InitializeComponent();
        }


        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            username = NavigationContext.QueryString["username"];
        }
        private void Pivot_Loaded(object sender, RoutedEventArgs e)
        {
           DocNavigation.Title= "Welcome Dr. "+username.ToString().ToUpper();
            doctorDisplay.Text = "Hello Dr. "+username.ToString().ToUpperInvariant();
         
        }

        private void monitorPatientButton_Click(object sender, RoutedEventArgs e)
        {
            DocNavigation.SelectedItem = patientList;
        }

        private void notificationsButton_Click(object sender, RoutedEventArgs e)
        {
            DocNavigation.SelectedItem = notifications;
        }

    

        private void signOutButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        //private void viewTop5PatientsButton_Click(object sender, RoutedEventArgs e)
        //{
        //    DocNavigation.SelectedItem = top5Patients;
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/patientRiskScoreDummyPage.xaml?patientName="+patientName.Content, UriKind.Relative));
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/patientRiskScoreDummyPage.xaml?patientName=" + patientName1.Content, UriKind.Relative));
        //}

        //private void Juliet_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/notificationPatientDummyPage.xaml?patientName="+Juliet.Content, UriKind.Relative));
        //}

        //private void Kilo_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/notificationPatientDummyPage.xaml?patientName=" + Kilo.Content, UriKind.Relative));
        //}

        //private void Oscar_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/notificationPatientDummyPage.xaml?patientName=" + Oscar.Content, UriKind.Relative));
        //}

        //private void Romio_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/patientRiskScoreDummyPage.xaml?patientName=" + Romio.Content, UriKind.Relative));
        //}

        //private void Sara_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/patientRiskScoreDummyPage.xaml?patientName=" + Sara.Content, UriKind.Relative));
        //}

        //private void Victor_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/patientRiskScoreDummyPage.xaml?patientName=" + Victor.Content, UriKind.Relative));
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/patientRiskScoreDummyPage.xaml?patientName=" + patientName2.Content, UriKind.Relative));
        //}

         private void p1FN_Click(object sender, RoutedEventArgs e)
        {
            p1clicked();
        }

        private void p1clicked()
        {
            NavigationService.Navigate(new Uri("/patientRiskScoreDummyPage.xaml?patientName="+p1FN.Content+"&riskScore="+p1SC1.Content, UriKind.Relative));
        }

        private void p1SC1_Click(object sender, RoutedEventArgs e)
        {
            p1clicked();
        }

        private void p1T_Click(object sender, RoutedEventArgs e)
        {
            p1clicked();
        }

        private void p1SC2_Click(object sender, RoutedEventArgs e)
        {
            p1clicked();
        }

        private void alerts_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DocNavigation.SelectedItem = notifications;
        }

        private void monitor_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DocNavigation.SelectedItem = patientList;
        }

        private void P2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            p2clicked();
        }

        private void p2FN_Click(object sender, RoutedEventArgs e)
        {
            p2clicked();
        }

        private void p2clicked()
        {
            NavigationService.Navigate(new Uri("/patientRiskScoreDummyPage.xaml?patientName=" + p2FN.Content + "&riskScore=" + p2SC1.Content, UriKind.Relative));
        }

        private void p4FN_Click(object sender, RoutedEventArgs e)
        {
            p4Clicked();
        }

        private void p4Clicked()
        {
            NavigationService.Navigate(new Uri("/patientRiskScoreDummyPage.xaml?patientName=" + p4FN.Content + "&riskScore=" + p4SC1.Content, UriKind.Relative));
        }

        private void p4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            p4Clicked();
        }

        private void p3T_Click(object sender, RoutedEventArgs e)
        {
            p3Clicked();
        }

        private void p3Clicked()
        {
            NavigationService.Navigate(new Uri("/patientRiskScoreDummyPage.xaml?patientName=" + p3FN.Content + "&riskScore=" + p3SC1.Content, UriKind.Relative));
        }

        private void p3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            p3Clicked();
        }

        private void John_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/notificationPatientDummyPage.xaml?id=" + 1 + "&name=" + John.Text + "&s1=" + JS1.Text + "&s2=" + JS2.Text, UriKind.Relative));
        }

        private void Mitchel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/notificationPatientDummyPage.xaml?id=" + 2 + "&name=" + Mitchel.Text + "&s1=" + MS1.Text + "&s2=" + MS2.Text, UriKind.Relative));
        }

        private void Prashanth_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/notificationPatientDummyPage.xaml?id="+3+"&name=" + Prashanth.Text + "&s1=" + PS1.Text + "&s2=" + PS2.Text, UriKind.Relative));
        }

      
          

        }
}