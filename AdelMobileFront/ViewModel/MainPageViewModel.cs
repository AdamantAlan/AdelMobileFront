using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using AdelMobileFront.Dtos;
using AdelMobileFront.services;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;
using System.Windows.Input;
using Xamarin.Essentials;

namespace AdelMobileFront.services.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly Rubin _rubin;
        private readonly Wool _wool;
        private readonly Portrait _portrait;
        private readonly Prayer _prayer;
        public  MainPageViewModel(Dictionary<string, BookDto> books)
        {
            _rubin = new Rubin();
            _wool = new Wool();
            _portrait = new Portrait();
            _prayer = new Prayer();

            foreach (var i in books)
            {
                if (i.Key == "Rubin")
                {
                    RubinTitle = i.Value.Title;
                    RubinComments = i.Value.Comments.ToString();
                    RubinLikes = i.Value.Likes.ToString();
                }
                if (i.Key == "Wool")
                {
                    WoolTitle= i.Value.Title;
                    WoolComments = i.Value.Comments.ToString();
                    WoolLikes = i.Value.Likes.ToString();
                }
                if (i.Key == "Prayer")
                {
                    PrayerTitle = i.Value.Title;
                    PrayerComments = i.Value.Comments.ToString();
                    PrayerLikes = i.Value.Likes.ToString();
                }
                if (i.Key == "Portrait")
                {
                   PortraitTitle = i.Value.Title;
                   PortraitComments = i.Value.Comments.ToString();
                   PortraitLikes = i.Value.Likes.ToString();
                }
            }
        }
        private async Task<Dictionary<string, BookDto>> GetBooksAsync()
        {
            return await BooksService.GetAllBookAsync(); 
        }
        //property
        public string RubinTitle
        {
            get { return _rubin.Title; }
            set
            {
                if (_rubin.Title != value)
                {
                    _rubin.Title = value;
                    OnPropertyChanged("RubinTitle");
                }
            }
        }
        public string RubinComments { get { return $"Комментарии {_rubin.Comments}"; }
            set
            {
                if (_rubin.Comments != int.Parse(value))
                {
                    _rubin.Comments = int.Parse(value);
                    OnPropertyChanged("RubinComments");
                }
            }
        }
        public string RubinLikes { get { return $"Лайки {_rubin.Likes}"; } 
            
                set
            {
                    if (_rubin.Likes != int.Parse(value))
                    {
                        _rubin.Likes = int.Parse(value);
                        OnPropertyChanged("RubinLikes");
                    }
                }
            }

        public string WoolTitle { get { return _wool.Title; }
            set
            {
                if (_wool.Title != value)
                {
                    _wool.Title = value;
                    OnPropertyChanged("WoolTitle");
                }
            }
        }
        public string WoolComments { get { return $"Комментарии {_wool.Comments}"; }
            set
            {
                if (_wool.Comments != int.Parse(value))
                {
                    _wool.Comments = int.Parse(value);
                    OnPropertyChanged("WoolComments");
                }
            }
        }
        public string WoolLikes { get { return $"Лайки {_wool.Likes}"; }
            set
            {
                if (_wool.Likes != int.Parse(value))
                {
                    _wool.Likes = int.Parse(value);
                    OnPropertyChanged("WoolLikes");
                }
            }
        }
        public string PortraitTitle { get { return _portrait.Title; }
            set
            {
                if (_portrait.Title != value)
                {
                    _portrait.Title = value;
                    OnPropertyChanged("PortraitTitle");
                }
            }
        }
        public string PortraitComments { get { return $"Комментарии {_portrait.Comments}"; }
            set
            {
                if (_portrait.Comments != int.Parse(value))
                {
                    _portrait.Comments = int.Parse(value);
                    OnPropertyChanged("PortraitComments");
                }
            }
        }
        public string PortraitLikes { get { return $"Лайки {_portrait.Likes}"; }
            set
            {
                if (_portrait.Likes != int.Parse(value))
                {
                    _portrait.Likes= int.Parse(value);
                    OnPropertyChanged("PortraitLikes");
                }
            }
        }
        public string PrayerTitle { get { return _prayer.Title; }
            set
            {
                if (_prayer.Title != value)
                {
                    _prayer.Title = value;
                    OnPropertyChanged("PrayerTitle");
                }
            }
        }
        public string PrayerComments { get { return $"Комментарии {_prayer.Comments}"; }
            set
            {
                if (_prayer.Comments != int.Parse(value))
                {
                    _prayer.Comments = int.Parse(value);
                    OnPropertyChanged("PrayerComments");
                }
            }
        }
        public string PrayerLikes { get { return $"Лайки {_prayer.Likes}"; }
            set
            {
                if (_prayer.Likes != int.Parse(value))
                {
                    _prayer.Likes = int.Parse(value);
                    OnPropertyChanged("PrayerLikes");
                }
            }
        }
        protected void OnPropertyChanged(string propName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
