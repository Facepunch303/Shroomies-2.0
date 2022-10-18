using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Xamarin.Forms.PlatformConfiguration;

namespace Shroomies_2._0
{
    
    public partial class MainPage : ContentPage
    {
        // variables
        int readButtonValue = 30;

        public MainPage()
        {
            InitializeComponent();
            imageLoader();
        }

        public void imageLoader()
        {
            // add x:name for image
            // img1.Source = "ShroomiesLogo.png";
        }

        public void BtnClicked(object sender, EventArgs args)
        {
            string readButtonValueString = readButtonValue.ToString();
            Button2.Text = readButtonValueString;
        }
    }
}
