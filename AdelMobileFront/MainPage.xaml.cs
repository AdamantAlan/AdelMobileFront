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

namespace AdelMobileFront
{
    public partial class MainPage : ContentPage
    {
        public  MainPage()
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

        private void Exit(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
