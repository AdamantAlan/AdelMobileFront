using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AdelMobileFront.services;
using AdelMobileFront.Dtos;
using Xamarin.Forms;
using AdelMobileFront.services.ViewModel;
using Xamarin.Essentials;

namespace AdelMobileFront
{
   

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            InitAsync();
        }
        private async Task InitAsync()
        {
            Spiner.IsRunning = true;
            Spiner.IsVisible = true;
            this.BindingContext = new MainPageViewModel(await BooksService.GetAllBookAsync());
            Spiner.IsRunning = false;
            Spiner.IsVisible =false;
        }
        private void Refresh()
        {
            rubinInfoTitle.Text = " ";
            rubinInfoComments.Text = "Коменты: ";
            rubinInfoLikes.Text = "Лайки: ";
            woolInfoTitle.Text = " ";
            woolInfoComments.Text = "Коменты: ";
            woolInfoLikes.Text = "Лайки: ";
            prayerInfoTitle.Text = " ";
            prayerInfoComments.Text = "Коменты: ";
            prayerInfoLikes.Text = "Лайки: ";
            portraitInfoTitle.Text = " ";
            portraitInfoComments.Text = "Коменты: ";
            portraitInfoLikes.Text = "Лайки: ";
        }
        public async void RedirectToSite(object sender, EventArgs e)
        {
            try
            {
                if(sender == woolInfoTitle)
                await Browser.OpenAsync("https://ficbook.net/readfic/10463740", BrowserLaunchMode.SystemPreferred);
                if (sender == prayerInfoTitle)
                    await Browser.OpenAsync("https://ficbook.net/readfic/10063965", BrowserLaunchMode.SystemPreferred);
                if (sender == portraitInfoTitle)
                    await Browser.OpenAsync("https://ficbook.net/readfic/10340100", BrowserLaunchMode.SystemPreferred);
                if (sender == rubinInfoTitle)
                    await Browser.OpenAsync("https://ficbook.net/readfic/9838377", BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }
        }
        
        private void Exit(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

    }
}
