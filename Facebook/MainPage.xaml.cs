using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Facebook.Resources;
using Newtonsoft.Json;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Tasks;
using System.Device.Location;

namespace Facebook
{
    public partial class MainPage : PhoneApplicationPage
    {

        //LocationDeclaration
        double Lat;
        double Lon;

        public MainPage()
        {
            InitializeComponent();
           
        }

        void getJson(string username) 
        {
            WebClient webclient = new WebClient();
           
            //In async you put the url of api 
            //It is basically when you download the data from internet
            webclient.DownloadStringAsync(new Uri("http://graph.facebook.com/"+username));
            
            //This very line would be executed when the data would be downloaded and serialized
            //it has the method attached webclient_DownloadStringCompleted();
            webclient.DownloadStringCompleted += webclient_DownloadStringCompleted;
        }

        void webclient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            var rootObject = JsonConvert.DeserializeObject<RootObject>(e.Result);
            
            
            CoverImage.Source = new BitmapImage(new Uri(rootObject.cover.source));
            City.Text = rootObject.location.city;
            Country.Text = rootObject.location.country;
            Ablut.Text = rootObject.about;
            likes.Text = rootObject.likes.ToString();
            Checkins.Text = rootObject.checkins.ToString();
            website.Text = rootObject.website;
            link.Text = rootObject.link;
            Lat = rootObject.location.latitude;
            Lon = rootObject.location.longitude;




                
        }



        
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            getJson(input.Text);
            
        }

        private void naviagte_Click(object sender, RoutedEventArgs e)
        {
             

            BingMapsTask bindmapTask = new BingMapsTask();
            bindmapTask.Center = new GeoCoordinate
            {
             Latitude = Lat, Longitude = Lon
            };
            bindmapTask.Show();
        }
    }
}