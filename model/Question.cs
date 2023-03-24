using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nour.model
{
    internal class Question : INotifyPropertyChanged
    {
        public string title { get; set; }
        public Account account { get; set; }
        public string Response { get; set; }
        public string image { get; set; }
        public Question(string title, Account account, string response, string image)
        {
            this.title=title;
            this.account=account;
            Response=response;
            this.image=image;
        }
        public Question() { }


        public string _title { get { return title; }
            set
            {
                if (value == null)
                    return;
                title = value;
                RaisePropertyChangedEvent();
            }
        }
        public string _image { get { return image; }
            set
            {
                if (value == null)
                    return;
                image = value; RaisePropertyChangedEvent();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChangedEvent([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
