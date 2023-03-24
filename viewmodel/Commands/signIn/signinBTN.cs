using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Nour.viewmodel;
using Nour.model.firebase;
using Nour.view;
using Nour.model;

namespace Nour.viewmodel.Commands.signIn
{
    internal class signinBTN : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public SignInViewModel SignInViewModel { get; set; }
        public signinBTN(SignInViewModel signInView) 
        { 
            this.SignInViewModel = signInView;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            LogIn logIn = new LogIn();
            bool state = await logIn.checkAccount(SignInViewModel._Account);
            if (state)
            {
                Chapters chapters = new Chapters();
                ((MainWindow)Context.context).Frame.NavigationService.Navigate(chapters);
                Context.Account = SignInViewModel._Account;
            }
        } 
    }
}
