using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace carousel
{
    public partial class Temperament : CarouselPage
    {
        ImageButton imb_holerik, imb_sangvinik, imb_flegmatik, imb_melanholik;
        Uri uri;
        Button btn;
        public Temperament()
        {

            imb_holerik = new ImageButton
            {
                Source = "holerik.jpg",
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            

            imb_sangvinik = new ImageButton
            {
                Source = "holerik.jpg",
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            

            imb_flegmatik = new ImageButton
            {
                Source = "holerik.jpg",
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            

            imb_melanholik = new ImageButton
            {
                Source = "holerik.jpg",
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            uri = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");

            btn = new Button
            {
                Text = uri.ToString(),
            };
            btn.Clicked += Btn_Clicked;

            var Temp_Test = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Test",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof (Label))
                        },
                        btn
                    }
                }
            };

            var HolerikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Koleerik",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof (Label))
                        },
                        imb_holerik
                    }
                }
            };
            
            var SangvinikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Sangviinik",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof (Label))
                        },
                        imb_sangvinik
                    }
                }
            };
            var FlegmatikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Flegmaatik",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof (Label))
                        },
                        imb_flegmatik
                    }
                }
            };

            var MelanholikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Melanhoolik",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof (Label))
                        },
                        imb_melanholik
                    }
                }
            };

            Children.Add(Temp_Test);
            Children.Add(HolerikPage);
            Children.Add(SangvinikPage);
            Children.Add(FlegmatikPage);
            Children.Add(MelanholikPage);


            imb_holerik.Clicked += Imb_holerik_Clicked;
            imb_sangvinik.Clicked += Imb_sangvinik_Clicked;
            imb_flegmatik.Clicked += Imb_flegmatik_Clicked;
            imb_melanholik.Clicked += Imb_melanholik_Clicked;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            uri = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(uri);
        }

        private void Imb_sangvinik_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sangviinik", "Sangviinik on üks neljast temperamenditüübist teadusliku psühholoogia eelses isiksuseteoorias." +
                "Sangviinik on entusiastlik, aktiivne ja sotsiaalne. Sangviinikud on reeglina ekstravertsed ning nende jaoks on" +
                "sotsiaalsus ja karismaatilisus kergesti saavutatav. Sangviinikutel on raske mitte midagi teha ning tihti on nad" +
                "seotud riskialti käitumisega.", "OK");
        }

        private void Imb_flegmatik_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Flegmaatik", "Flegmaatik on rahulik, alati tasakaalukas, visa ja püüdlik inimene. Oma tegemistes on" +
                "järjekindel ja põhjalik. Ta oskab oodata ja olla kannatlik. Flegmaatik omandab kõike aegamööda, viib alustatu" +
                "alati lõpuni ning oma suhetes ja huvides on püsivad. On vähe altid kiitustele ja laitustele. Tähelepanu" +
                "ümberlülitumine ja uuele tööviisile üleminek on tal vaevaline. Tal on kerge jääda rahulikuks isegi keerukates" +
                "olukordades. Teda on raske naerma ajada, vihastada või kurvastada. Vaheldust ta ei armasta, uues olukorras kohaneb" +
                "väga aeglaselt. Kaaslastega kontakti leidmine ja tutvumine käib tal pikkamööda, kuid sõbrana on ta truu ja ustav. ", "OK");
        }

        private void Imb_melanholik_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Melanhoolik", "Melanhoolsed inimesed on analüütilised, detailidele orienteeritud ning sügava mõtte- ja tundeeluga. Nad" +
                "on introvertsed ja neile ei meeldi seltskonnast eristuda. Melanhoolne inimene on mõtlik, tagasihoidlik ja tihti ärev." +
                "Tihti püüdlevad nad täiuslikkuse poole nii sisemiselt kui ka neid ümbritsevas keskkonnas, mis väljendub ülimas puhtuses" +
                "ja detailsuses. ", "OK");
        }

        private void Imb_holerik_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Koleerik", "Koleerik on üks neljast temperamenditüübist teadusliku psühholoogia eelses isiksuseteoorias." +
                "Koleerilised inimesed on iseseisvad, otsustavad ning eesmärgile orienteeritud. Nende liidriomadused ja ambitsioonikus" +
                "toetavad neid teiste juhtimisel. Lisaks on neil loogiline maailmavaade ning otsustes faktidele tuginemine.", "OK");
        }
    }
}