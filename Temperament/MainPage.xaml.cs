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
            await DisplayAlert("Описание", "Спокойный, сдержанный. Он плохо приспосабливается к новой обстановке и в неблагоприятных условиях может стать пассивным и вялым, при этом отличается самообладанием, терпеливостью, предприимчивостью. В обществе флегматик в меру общителен, не любит пустословия и не подвержен панике в стрессовых ситуациях.", "OK");

        }
        private async void ImageButton_Clicked1(object sender, EventArgs e)
        {
            await DisplayAlert("Описание", "Горячий, несдержанный, смелый, задорный. Такие люди инициативны, с азартом берутся за любую работу (кроме рутинной) и с легкостью преодолевают трудности. Они способны схватывать информацию на лету, обладают лидерскими качествами, однако нетерпеливы, вспыльчивы и подвержены эмоциональным срывам.", "OK");

        }
        private async void ImageButton_Clicked2(object sender, EventArgs e)
        {
            await DisplayAlert("Описание", "Уравновешенный, оптимистичный, жизнерадостный. Сангвинический темперамент характеризует человека веселого, эмоционального, общительного, живущего настроением. Он легко переживает неудачи, создает приятный микроклимат в любом коллективе, но не всегда выполняет свои обещания, порой слишком поспешен в делах и суждениях и излишне самоуверен.", "OK");

        }
        private async void ImageButton_Clicked3(object sender, EventArgs e)
        {
            await DisplayAlert("Описание", "Чувствительный, неэнергичный, болезненно реагирующий на неприятности, склонный к унынию. Люди с меланхолическим темпераментом подвержены пессимизму, излишне подозрительны и ревнивы, но обладают аналитическим мышлением, творчески подходят к работе, тонко чувствуют и доводят дело до завершения.", "OK");

        }
    }
}
