using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;


namespace PhoneApp1
{
    public partial class patientRiskScoreDummyPage : PhoneApplicationPage
    {
        String riskScore;
        String patientName;
        public patientRiskScoreDummyPage()
        {
            InitializeComponent();

         
        }

        private void Pivot_Loaded(object sender, RoutedEventArgs e)
        {
         
        }


        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            patientName = NavigationContext.QueryString["patientName"];
            patientNameInHeading.Header = patientName.ToString().ToLower();
            riskScore = NavigationContext.QueryString["riskScore"].ToString();
            riskScore = riskScore.Replace("%", "");
            riskScoreDisplay(riskScore);
            Score.Text = riskScore.ToString() + "%";
            monitorPatient.Content ="Monitor "+patientName.ToString();

        }

        private void riskScoreDisplay(string riskScore)
        {
            Double riskScoreInDouble = Double.Parse(riskScore);

            if (riskScoreInDouble < 50)
            {
                Score.Foreground = new SolidColorBrush(Colors.Green);
            }

            else if (riskScoreInDouble > 50 && riskScoreInDouble < 75)
            {
                Score.Foreground = new SolidColorBrush(Colors.Yellow);

            }
            else
            {

                Score.Foreground = new SolidColorBrush(Colors.Red);

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/doctorDashboard.xaml", UriKind.Relative));
        }

        private void monitorPatient_Checked(object sender, RoutedEventArgs e)
        {
          
          monitorPatient.Content = "Monitoring " +  patientName.ToString();
        }

        private void monitorPatient_Unchecked(object sender, RoutedEventArgs e)
        {
               monitorPatient.Content = "Monitor " + patientName.ToString();
        }

        private void anemia_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            resultsPatient.SelectedItem = anemiaPivot;
        }

        private void cardio_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            resultsPatient.SelectedItem = cardioPivot;
        }

        private void dialysis_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            resultsPatient.SelectedItem = dialysisPivot;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          //  NavigationService.Navigate(new Uri("/interventionRecommendation.xaml?patient="+patientName, UriKind.Relative));
            NavigationService.Navigate(new Uri("/Page2.xaml?patient=" + patientName, UriKind.Relative));
        }


        

    }
}