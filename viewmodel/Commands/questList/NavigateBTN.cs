using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Nour.view;
namespace Nour.viewmodel.Commands.questList
{
    internal class NavigateBTN : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            AddNewQuest addNewQuest = new AddNewQuest();
            ((MainWindow)Context.context).Frame.NavigationService.Navigate(addNewQuest);
        }
    }
}
