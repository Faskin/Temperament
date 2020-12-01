using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Temperament
{
    
    public partial class MainPage : CarouselPage
    {
        public const string testUrl = "https://testometrika.com/personality-and-temper/questionnaire-eysenck-pen/";
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void TestButton_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync(testUrl);
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание", "", "OK");

        }
    }
}
