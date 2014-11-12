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

namespace PhoneApp1
{
    public partial class ResultsPage : PhoneApplicationPage
    {
        public ResultsPage()
        {
            InitializeComponent();

        }

        string age = String.Empty;
        string bp = String.Empty;
        string gender = String.Empty;
        string diabetes = String.Empty;
        string stroke = String.Empty;
        string hospitalization = String.Empty;
        string race = String.Empty;
        string bmi = String.Empty;
        //Hard coding!! cant help, API is crashing and have demo in 30 min so had to make this change
        string efv = String.Empty;
        string lengthOfStay = String.Empty;


        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            bp = NavigationContext.QueryString["bp"];
            age = NavigationContext.QueryString["age"];
            gender = NavigationContext.QueryString["gender"];
            race = NavigationContext.QueryString["race"];
            hospitalization = NavigationContext.QueryString["hospitalization"];
            stroke = NavigationContext.QueryString["stroke"];
            diabetes = NavigationContext.QueryString["diabetes"];
            bmi = NavigationContext.QueryString["BMI"];
            efv = NavigationContext.QueryString["efv"];

            lengthOfStay = NavigationContext.QueryString["Stay"];

        }
        public void ResultPageLoaded(object sender, RoutedEventArgs e)
        {
            System.Uri myUri = new System.Uri("http://cds-raas-dev.cloudapp.net/RoR");
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
            string postData = "age=" + age + "&gender=" + gender + "&ethnicGroup=" + race +
                         "&inpatientBMI=" + bmi + "&diabetes=" + diabetes + "&stroke=" + stroke + "&priorHospitalization=" + hospitalization +
                         "&ejectionFraction=" + efv + "&bloodPressureCategory=" + bp + "&lengthOfStay=" + lengthOfStay.Replace(" ", String.Empty) + "&returnType=JSON&modelID=TenB";
            //"[{\"DM\":\"AGE_0, FEMALE_1\", \"PR\":\"PR_0388,PR_0345\",\"DX\":\"DX_22,DX_0954\",\"DEL\":\"CM_RENLFAIL_1\"}]";

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
            HttpWebResponse result = (HttpWebResponse)request.EndGetResponse(callbackResult);

            using (StreamReader httpWebStreamReader = new StreamReader(result.GetResponseStream()))
            {
                var response = httpWebStreamReader.ReadToEnd();
                int lastIndex = response.LastIndexOf('}');
                string responseString = response.Replace("TRUE", string.Empty);

                JObject objJsonObject = JObject.Parse(responseString);

                string probability = objJsonObject["probability"].ToString();
                JObject riskFactorsObject = (JObject)objJsonObject["riskFactors"];
                JArray riskFactorsArray = (JArray)riskFactorsObject["name"];
                String[] risksStringList = new String[3];

                JObject riskContributorsObject = (JObject)objJsonObject["readmissionContributors"];
                JArray riskContributorsArray = (JArray)riskContributorsObject["name"];
                String[] riskContributorsList = new String[3];


                Deployment.Current.Dispatcher.BeginInvoke(new Action(() =>
                {


                    TextBlock probabilityTextBlock = new TextBlock();
                    //TextBlock probab = new TextBlock();
                    Probability.FontSize = 26;
                    probabilityTextBlock.Text = "Probability of readmission in 30 days is";
                    Probability.Text = probabilityTextBlock.Text.ToString();
                    Double probabilityInDouble = Double.Parse(probability);
                    if (probabilityInDouble < 35)
                    {
                        Prob.Foreground = new SolidColorBrush(Colors.Green);
                        //   graphProbability.Foreground = new SolidColorBrush(Colors.Green);
                    }
                    else if (probabilityInDouble < 65 && probabilityInDouble > 35)
                    {
                        Prob.Foreground = new SolidColorBrush(Colors.Yellow);
                        // graphProbability.Foreground = new SolidColorBrush(Colors.Yellow);
                    }
                    else
                    {
                        Prob.Foreground = new SolidColorBrush(Colors.Red);
                        //graphProbability.Foreground = new SolidColorBrush(Colors.Green);
                    }

                    Prob.Text = probability.ToString();

                    graphCanvas.Visibility = System.Windows.Visibility.Visible;
                    disclaimer.Visibility = System.Windows.Visibility.Visible;

                    // graphProbability.Text = probability.ToString();
                    Canvas.SetLeft(graphStack, probabilityInDouble);


                    TextBlock riskFactorsHeading = new TextBlock();
                    riskFactorsHeading.Text = "Why this score?";
                    riskFactorsHeading.FontSize = 30;
                    riskFactorsHeading.TextAlignment = TextAlignment.Left;
                    riskFactorsHeading.Margin = new Thickness(10, 10, 5, 10);
                    ContentPanel.Children.Add(riskFactorsHeading);

                    int i = 0;
                    foreach (var riskFactors in riskFactorsArray)
                    {
                        TextBlock riskFactorsTextBlock = new TextBlock();
                        risksStringList[i] = riskFactors.ToString();
                        riskFactorsTextBlock.Text = i + 1 + ") " + risksStringList[i].Replace("&lt", " < ");
                        riskFactorsTextBlock.Margin = new Thickness(10, 0, 5, 5);
                        riskFactorsTextBlock.FontSize = 25;
                        riskFactorsTextBlock.TextAlignment = TextAlignment.Left;
                        ContentPanel.Children.Add(riskFactorsTextBlock);
                        i++;

                    }


                    TextBlock spacing = new TextBlock();
                    spacing.Text = "";
                    spacing.FontSize = 10;
                    ContentPanel.Children.Add(spacing);


                    TextBlock riskContributorsHeading = new TextBlock();
                    riskContributorsHeading.Text = "Ask a Physcian about:";
                    riskContributorsHeading.FontSize = 30;
                    riskContributorsHeading.TextAlignment = TextAlignment.Left;
                    riskContributorsHeading.Margin = new Thickness(10, 10, 5, 10);
                    ContentPanel.Children.Add(riskContributorsHeading);

                    int j = 0;
                    foreach (var riskContributors in riskContributorsArray)
                    {
                        TextBlock riskContributorsTextBlock = new TextBlock();
                        riskContributorsList[j] = j + 1 + ") " + riskContributors.ToString();
                        riskContributorsTextBlock.Text = riskContributorsList[j];
                        riskContributorsTextBlock.Margin = new Thickness(10, 0, 5, 5);
                        riskContributorsTextBlock.TextAlignment = TextAlignment.Left;
                        riskContributorsTextBlock.FontSize = 25;
                        ContentPanel.Children.Add(riskContributorsTextBlock);
                        j++;

                    }
                }));
            }



        }
    }
}

    