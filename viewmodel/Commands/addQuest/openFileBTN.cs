using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Nour.viewmodel.Commands.addQuest
{
    internal class openFileBTN : ICommand
    {
        public event EventHandler CanExecuteChanged;

        AddNewQusetViewModel AddNewQusetViewModel { get; set; }

        public openFileBTN(AddNewQusetViewModel addNewQusetViewModel)
        {
            AddNewQusetViewModel=addNewQusetViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                AddNewQusetViewModel.Question._image = openFileDialog.FileName;
            }
        }
    }
}
