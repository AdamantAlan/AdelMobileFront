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

namespace AdelMobileFront
{
    public partial class MainPage : ContentPage
    {
        public  MainPage()
        {
            InitializeComponent();
            GetInfoAboutBooks();
        }
        internal async void GetInfoAboutBooks()
        {
            Spiner.IsRunning = true;
            await getInfoAboutBooks();
            Spiner.IsRunning = false;
        }
            private async Task getInfoAboutBooks()
        {
            var all = await  BooksService.GetAllBookAsync();
            if (all == null)
                await DisplayAlert( "Ошибка", "Не могу получить информацию о книгах!",  "Закрыть");
            else
            foreach (var i in all)
            {
                if(i.Key == "Rubin")
                {
                    rubinInfoTitle.Text += " " + i.Value.Title;
                    rubinInfoComments.Text += " " + i.Value.Comments;
                    rubinInfoLikes.Text += " " + i.Value.Likes;
                }
                if (i.Key == "Wool")
                {
                    woolInfoTitle.Text += " " + i.Value.Title;
                    woolInfoComments.Text += " " + i.Value.Comments;
                    woolInfoLikes.Text += " " + i.Value.Likes;
                }
                if (i.Key == "Prayer")
                {
                    prayerInfoTitle.Text += " " + i.Value.Title;
                    prayerInfoComments.Text += " " + i.Value.Comments;
                    prayerInfoLikes.Text += " " + i.Value.Likes;
                }
                if (i.Key == "Portrait")
                {
                    portraitInfoTitle.Text += " " + i.Value.Title;
                    portraitInfoComments.Text += " " + i.Value.Comments;
                    portraitInfoLikes.Text += " " + i.Value.Likes;
                }
            }
        }

        private void UpdateMainPage(object sender, EventArgs e)
        {
            Refresh();
            Spiner.IsRunning = true;
            GetInfoAboutBooks();
            Spiner.IsRunning = false;
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
    }
}
