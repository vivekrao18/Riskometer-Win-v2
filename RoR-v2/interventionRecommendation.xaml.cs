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
    public partial class PivotPage2 : PhoneApplicationPage
    {
        static int count1=0,count2=0,count3=0,count4=0;
        static int ct1 =0, ct2 =0, ct3 =0, ct4 =0, ct5 = 0;
        static int Ict1 = 0, Ict2 = 0, Ict3 = 0, Ict4 = 0, Ict5 = 0, Ict6=0;
        public PivotPage2()
        {
            InitializeComponent();
        }

        String patientName;
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            patientName = NavigationContext.QueryString["patient"];
            populatePatientDetails(patientName);
        }

        private void populatePatientDetails(String patientName)
        {
            TextBlock patient = new TextBlock();
            patient.FontSize = 22;
            patient.Text = "Intervention Recommendation for : " + patientName;
            patientDetailsPivot.Children.Add(patient); 
            

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            but1.BorderBrush = changeBorderColor(++count1);
        }

        public SolidColorBrush changeBorderColor(int count)
        {
            if(count%2!=0)
            {
                return new SolidColorBrush(Color.FromArgb(0xFF, 0x1A, 0xB9, 0x2E));
            }
            else
            {
                return new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
            }
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            but2.BorderBrush = changeBorderColor(++count2);
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            but3.BorderBrush = changeBorderColor(++count3);
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            but4.BorderBrush = changeBorderColor(++count4);
        }

        private void nextButtonPatientDetails_Click(object sender, RoutedEventArgs e)
        {
            IRNavigation.SelectedItem = diagnosis;
        }

        private void nextButtonDiagnosis_Click(object sender, RoutedEventArgs e)
        {
            IRNavigation.SelectedItem = procedure;
        }

        private void nextButtonProcedure_Click(object sender, RoutedEventArgs e)
        {
            IRNavigation.SelectedItem = intervention;
        }


        private void butn1_Click(object sender, RoutedEventArgs e)
        {
            butn1.BorderBrush = changeBorderColorProcedure(++ct1);
        }
        private void butn2_Click(object sender, RoutedEventArgs e)
        {
            butn2.BorderBrush = changeBorderColorProcedure(++ct2);
        }
        private void butn3_Click(object sender, RoutedEventArgs e)
        {
            butn3.BorderBrush = changeBorderColorProcedure(++ct3);
        }
        private void butn4_Click(object sender, RoutedEventArgs e)
        {
            butn4.BorderBrush = changeBorderColorProcedure(++ct4);
        }
        private void butn5_Click(object sender, RoutedEventArgs e)
        {
            butn5.BorderBrush = changeBorderColorProcedure(++ct5);
        }

        public SolidColorBrush changeBorderColorProcedure(int count)
        {
            if (count % 2 != 0)
            {
                return new SolidColorBrush(Color.FromArgb(0xFF, 0xD8, 0xE1, 0x44));
            }
            else
            {
                return new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
            }
        }

        private void Ibtn1_Click(object sender, RoutedEventArgs e)
        {
            Ibtn1.BorderBrush = changeBorderColorIntervention(++Ict1);
        }
        private void Ibtn2_Click(object sender, RoutedEventArgs e)
        {
            Ibtn2.BorderBrush = changeBorderColorIntervention(++Ict2);
        }
        private void Ibtn3_Click(object sender, RoutedEventArgs e)
        {
            Ibtn3.BorderBrush = changeBorderColorIntervention(++Ict3);
        }
        private void Ibtn4_Click(object sender, RoutedEventArgs e)
        {
            Ibtn4.BorderBrush = changeBorderColorIntervention(++Ict4);
        }
        private void Ibtn5_Click(object sender, RoutedEventArgs e)
        {
            Ibtn5.BorderBrush = changeBorderColorIntervention(++Ict5);
        }
        private void Ibtn6_Click(object sender, RoutedEventArgs e)
        {
            Ibtn6.BorderBrush = changeBorderColorIntervention(++Ict6);
        }

        public SolidColorBrush changeBorderColorIntervention(int count)
        {
            if (count % 2 != 0) 
            {
                return new SolidColorBrush(Color.FromArgb(0xFF, 0x12, 0x12, 0x12));
            }
            else
            {
                return new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
            }
        }

        private void nextButtonIntervention_Click(object sender, RoutedEventArgs e)
        {
            IRNavigation.SelectedItem = result;
        }


        //public void updateResult(object sender, RoutedEventArgs e)
        //{
        //    double prob = 55.78;
        //    TextBlock t1 = new TextBlock();
        //    t1.FontSize = 26;
        //    t1.Text = "Risk score for selected pathway is : 55.78%";
        //    stackPanel.Children.Add(t1);
        //    graphCanvas1.Visibility = System.Windows.Visibility.Visible;
        //    Canvas.SetLeft(graphStack, prob);
        //}
    }
 
}