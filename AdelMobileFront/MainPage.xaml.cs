using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AdelMobileFront.services;
using AdelMobileFront.model;
using Xamarin.Forms;

namespace AdelMobileFront
{
    public partial class MainPage : ContentPage
    {
        string textValue = "Value";
        public MainPage()
        {
            InitializeComponent();
        }

        private async void UpdateRubin(object sender, EventArgs e)
        {
            IBook r = await new BooksService().GetBookAsync<Rubin>();
            rubinInfoTitle.Text ="Название "+ r.title;
            rubinInfoComments.Text ="Комментарии "+ r.comments.ToString();
            rubinInfoLikes.Text ="Лайки "+ r.likes.ToString();
        }
    }
}
