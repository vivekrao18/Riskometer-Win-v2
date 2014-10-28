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
    public partial class Page2 : PhoneApplicationPage
    {
        bool demographicFlag = true, comorbidityFlag = false, interventionFlag=false;
        public Page2()
        {
            InitializeComponent();
            //comorScrollView.Content = stackPanelComor;
        }

        private void demographics_Click(object sender, RoutedEventArgs e)
        {
            if (!demographicFlag)
            {
                stackPanelDemographics.Visibility = System.Windows.Visibility.Visible;
                demographicFlag = true;
            }
                
            else
            {
                stackPanelDemographics.Visibility = System.Windows.Visibility.Collapsed;
                demographicFlag = false;
            }

        }

        private void comorbidities_Click(object sender, RoutedEventArgs e)
        {
            if (!comorbidityFlag)
            {
                stackPanelComor.Visibility = System.Windows.Visibility.Visible;
                comorbidityFlag = true;
            }

            else
            {
                stackPanelComor.Visibility = System.Windows.Visibility.Collapsed;
                comorbidityFlag = false;
            }
        }

        private void interventions_Click(object sender, RoutedEventArgs e)
        {
            if (!interventionFlag)
            {
                stackPanelInterventions.Visibility = System.Windows.Visibility.Visible;
                interventionFlag = true;
            }

            else
            {
                stackPanelInterventions.Visibility = System.Windows.Visibility.Collapsed;
                interventionFlag = false;
            }
        }

        private void riskScoreBottomBox_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/interventionResults.xaml",UriKind.Relative));
        }
    }
}