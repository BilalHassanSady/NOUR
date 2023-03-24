using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Nour.model;
using Nour.view;
using Nour.viewmodel.Commands.signIn;

namespace Nour.viewmodel
{
    internal class SignInViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public object context { get; set; } 


        public Account Account { get; set; }
        public Account _Account
        {
            get { return Account; }
            set
            {
                if (value == null)
                    return;
                Account = value;
                RaisePropertyChangedEvent();
            }
        }
        
        public signinBTN SigninBTNG { get;set; }

        public SignInViewModel()
        {
            this.SigninBTNG = new signinBTN(this);
            this._Account = new Account("","");
        }

        public void setContext(object context)
        {
            this.context = context;
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
