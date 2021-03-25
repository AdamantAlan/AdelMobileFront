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
            progress.Progress = 0.0;
            await getInfoAboutBooks();
        }
            private async Task getInfoAboutBooks()
        {
            progress.Progress = 0.1;
            var all = await new BooksService().GetAllBookAsync();
            progress.Progress = 0.6;
            progress.Progress = 0.05;
            foreach (var i in all)
            {
                if(i.Key == "Rubin")
                {
                    rubinInfoTitle.Text += " " + i.Value.Title;
                    rubinInfoComments.Text += " " + i.Value.Comments;
                    rubinInfoLikes.Text += " " + i.Value.Likes;
                    progress.Progress = 0.7;
                }
                if (i.Key == "Wool")
                {
                    woolInfoTitle.Text += " " + i.Value.Title;
                    woolInfoComments.Text += " " + i.Value.Comments;
                    woolInfoLikes.Text += " " + i.Value.Likes;
                    progress.Progress = 0.8;
                }
                if (i.Key == "Prayer")
                {
                    prayerInfoTitle.Text += " " + i.Value.Title;
                    prayerInfoComments.Text += " " + i.Value.Comments;
                    prayerInfoLikes.Text += " " + i.Value.Likes;
                    progress.Progress = 0.9;
                }
                if (i.Key == "Portrait")
                {
                    portraitInfoTitle.Text += " " + i.Value.Title;
                    portraitInfoComments.Text += " " + i.Value.Comments;
                    portraitInfoLikes.Text += " " + i.Value.Likes;
                    progress.Progress = 1;
                }
            }
        }

        private void UpdateMainPage(object sender, EventArgs e)
        {
            Refresh();
            GetInfoAboutBooks();
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
