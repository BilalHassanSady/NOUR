using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Nour.model;
using Nour.view;

namespace Nour.viewmodel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public object context { get; set; }


        public List<chapter> Chapters { get; set; }
        public List<chapter> _Chapters
        {
            get { return Chapters; }
            set
            {
                if (value == null)
                    return;
                Chapters = value;
                RaisePropertyChangedEvent();
            }
        }

        public MainWindowViewModel()
        {

        }

        public void setContext()
        {
            this.context = Context.context;
            SignInPage signInPage = new SignInPage();
            SignInViewModel signInViewModel = new SignInViewModel();
            signInViewModel.setContext(context);
            ((MainWindow)context).Frame.NavigationService.Navigate(signInPage);
        }


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
