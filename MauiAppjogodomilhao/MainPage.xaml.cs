using AVFoundation;
using Plugin.Maui.Audio;

namespace MauiAppjogodomilhao
{
    public partial class MainPage : ContentPage
    {
        double premio = 0;
        int pergunta_count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void EasyRoll_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandomperguntafacil();

            lbl_nivel.Text = "FÁCIL";
            lbl_premio.Text = premio.ToString("c");
            lbl_pergunta_numero.Text = pergunta_count.ToString();

            //adiciona o som 
            Stream track = FileSystem.OpenAppPackageFileAsync("0.mp3").Result;
            AudioManager.Current.CreatePlayer(track).Play(); 

        }

        private void toca_som ()
        {
            string track = "";
            switch(pergunta_count) 
            {
                case 1:
                    track = "1.wav";
                    break;
                case 2:
                    track = "2.wav";
                    break;
                case 3:
                    track = "3.wav";
                    break;
                case 4:
                    track = "4.wav";
                    break;
                case 5:
                    track = "4.wav";
                    break;
                case 6:
                    track = "4.wav";
                    break;
                case 7:
                    track = "4.wav";
                    break;
                case 8:
                    track = "4.wav";
                    break;
                case 9:
                    track = "4.wav";
                    break;
                case 10:
                    track = "4.wav";
                    break;
                case 11:
                    track = "4.wav";
                    break;
                case 12:
                    track = "4.wav";
                    break;
                case 13:
                    track = "4.wav";
                    break;
                case 14:
                    track = "4.wav";
                    break;
                case 15:
                    track = "4.wav";
                    break;
                case 16:
                    track = "4.wav";
                    break;
               
            }
            AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync(track).Result).Play();
        }


        private async void proximo_Clicked(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if ((bool)alt0.Value)
                {
                    acertou = true;
                    resp = alt0.Content.ToString();
                }
            }
            if (alt1.IsChecked)
            {
                if ((bool)alt1.Value)
                {
                    acertou = true;
                    resp = alt1.Content.ToString();
                }
            }
            if (alt2.IsChecked)
            {
                if ((bool)alt2.Value)
                {
                    acertou = true;
                    resp = alt2.Content.ToString();
                }
            }
            if (alt3.IsChecked)
            {
                if ((bool)alt3.Value)
                {
                    acertou = true;
                    resp = alt3.Content.ToString();
                }
            }

            if (acertou)
            {
                Stream Track = FileSystem.OpenAppPackageFileAsync("parabens.wav").Result;
                AudioManager.Current.CreatePlayer(Track).Play();

                await DisplayAlert("ACERTOU!", resp, "OK");
                this.BindingContext = App.getRandomperguntafacil();
                pergunta_count++;
                toca_som();
                avanca_pergunta();
            }
            else 
            {
                Stream track = FileSystem.OpenAppPackageFileAsync("errou.wav").Result;
                AudioManager.Current.CreatePlayer(track).Play();

                await DisplayAlert("ERROU!", "VOCÊ perdeu ", "OK ");
                premio = 0;
                pergunta_count = 1;
                avanca_pergunta();
            }


            
        }

    }

}
