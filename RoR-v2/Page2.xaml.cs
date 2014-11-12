using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Media;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Web.Http;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

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

            sendTestAPICall();
                       
            
        }

        private void sendTestAPICall()
        {
            System.Uri myUri = new System.Uri("http://intervention.cloudapp.net:8080/PathwayFinderAPI-0.0.1-SNAPSHOT/getpathway");
            HttpWebRequest myRequest = (HttpWebRequest)HttpWebRequest.Create(myUri);
            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.BeginGetRequestStream(new AsyncCallback(GetRequestStreamCallback), myRequest);

        }

        void GetRequestStreamCallback(IAsyncResult callbackResult)
        {
            HttpWebRequest myRequest = (HttpWebRequest)callbackResult.AsyncState;
            Stream postStream = myRequest.EndGetRequestStream(callbackResult);

            // Create the post data
            string postData = "[{\"DM\":\"AGE_0, FEMALE_1\", \"PR\":\"PR_0388,PR_0345\",\"DX\":\"DX_22,DX_0954\",\"DEL\":\"CM_RENLFAIL_1\"}]";

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            
            // Add the post data to the web request
            postStream.Write(byteArray, 0, byteArray.Length);
            postStream.Dispose();

            // Start the web request
            myRequest.BeginGetResponse(new AsyncCallback(GetResponsetStreamCallback), myRequest);
        }

        void GetResponsetStreamCallback(IAsyncResult callbackResult)
        {
            Debug.WriteLine("hi");

            HttpWebRequest request = (HttpWebRequest)callbackResult.AsyncState;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(callbackResult);
            using (StreamReader httpWebStreamReader = new StreamReader(response.GetResponseStream()))
            {


                string result = httpWebStreamReader.ReadToEnd();
              
                JArray results = (JArray)JArray.Parse(result);

                CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    for (int i = 0; i < 15; i++)
                    {
                        Button temp = new Button();
                        temp.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x44, 0xAE, 0xCF));
                        temp.Content = results[i]["icd9Code"] + ":" + results[i]["wt"];
                        //Debug.WriteLine(results[i]["icd9Code"] + ":" + results[i]["wt"]);
                        stackPanelComor.Children.Add(temp);
                    }
                 
                    //foreach (JObject singleEntry in results)
                    //{
                    //    TextBlock temp = new TextBlock();
                    //    // temp.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x44, 0xAE, 0xCF));
                    //    temp.Text = singleEntry["icd9Code"] + ":" + singleEntry["wt"];
                    // //   Debug.WriteLine(singleEntry["icd9Code"] + ":" + singleEntry["wt"]);
                    //    stackPanelComor.Children.Add(temp);
                    //   // Button temp = new Button();
                    //   //// temp.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x44, 0xAE, 0xCF));
                    //   // temp.Content = singleEntry["icd9Code"] + ":" + singleEntry["wt"];
                    //   // Debug.WriteLine(singleEntry["icd9Code"] + ":" + singleEntry["wt"]);
                    //   // stackPanelComor.Children.Add(temp);

                    //}
                    //   testTextBox.Text = result;      
                });

                ///   Debug.WriteLine(result);
                // testTextBox.Text = result;                
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