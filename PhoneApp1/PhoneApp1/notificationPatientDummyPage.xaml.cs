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
    public partial class notificationPatientDummyPage : PhoneApplicationPage
    {
        String patientName = String.Empty, statement1 = String.Empty, statement2 = String.Empty,ID=String.Empty;
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            patientName = NavigationContext.QueryString["name"];
            ID = NavigationContext.QueryString["id"];
            statement1 = NavigationContext.QueryString["s1"];
            statement2 = NavigationContext.QueryString["s2"];
           
           patientAssignment();
        }

        private void patientAssignment()
        {
            patientNameInHeading.Text = patientName.ToString().ToLower();
            TextBlock t1 = new TextBlock();
            t1.FontSize = 26;
            t1.Text = statement1.ToString();
            TextBlock t2 = new TextBlock();
            t2.FontSize = 26;
            t2.Text = statement2.ToString();
            notificaitons.Children.Add(t1); 
            notificaitons.Children.Add(t2);
            switch (ID)
            {
                case "1":
                    johnCalled();
                    break;
                case "2":
                    mitchelCalled();
                    break;
                case "3":
                    prashanthCalled();
                    break;

                        
                default:
                    break;
            }
        }

        private void prashanthCalled()
        {
            TextBlock t1 = new TextBlock();
            TextBlock t2 = new TextBlock();
            TextBlock t3 = new TextBlock();
            TextBlock t4 = new TextBlock();
            TextBlock t5 = new TextBlock();
            t5.FontSize = 30;
            t5.Text = "";
            t1.FontSize = 26;
            t1.Text="   • Time since last change = 20 min.";
            t2.FontSize = 26;
            t2.Text="   • Changes are:";
                t3.FontSize = 24;
            t3.Text="       • Sodium level is high." ;
            t4.FontSize = 24;
            t4.Text="       • Glucose level is high.";
            notificaitons.Children.Add(t1);
            notificaitons.Children.Add(t5);
            notificaitons.Children.Add(t2);
            notificaitons.Children.Add(t3);
            notificaitons.Children.Add(t4);

            

        }

        private void johnCalled()
        {
            TextBlock t1 = new TextBlock();
            TextBlock t2 = new TextBlock();
            TextBlock t3 = new TextBlock();
            TextBlock t4 = new TextBlock();
            TextBlock t5 = new TextBlock();
            t5.FontSize = 30;
            t5.Text = "";
            t1.FontSize = 26;
            t1.Text = "   • Time since last change = 34 min.";
            t2.FontSize = 26;
    
            t2.Text = "   • Changes are:";
            t3.FontSize = 24;
            t3.Text = "       • EFV value is low.";
            t4.FontSize = 24;
            t4.Text = "       • Creatinine level is very high.";
            notificaitons.Children.Add(t1);
            notificaitons.Children.Add(t5);
            notificaitons.Children.Add(t2);
            notificaitons.Children.Add(t3);
            notificaitons.Children.Add(t4);
        }

        private void mitchelCalled()
        {
            TextBlock t1 = new TextBlock();
            TextBlock t2 = new TextBlock();
            TextBlock t3 = new TextBlock();
            TextBlock t4 = new TextBlock();
            TextBlock t5 = new TextBlock();
            t5.FontSize = 30;
            t5.Text = "";
            t1.FontSize = 26;
            t1.Text = "   • Time since last change = 15 min.";
            t2.FontSize = 26;
          
            t2.Text = "   • Changes are:";
            t3.FontSize = 24;
            t3.Text = "       • Heamoglobin level is abnormal.";
            t4.FontSize = 24;
            t4.Text = "       • BUNCr ration is high.";
            notificaitons.Children.Add(t1);
            notificaitons.Children.Add(t5);
            notificaitons.Children.Add(t2);
            notificaitons.Children.Add(t3);
            notificaitons.Children.Add(t4);
        }
        public notificationPatientDummyPage()
        {
            InitializeComponent();
        }
    }
}