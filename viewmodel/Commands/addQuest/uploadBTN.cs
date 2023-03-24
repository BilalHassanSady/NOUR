using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Nour.model;
using Nour.model.firebase;

namespace Nour.viewmodel.Commands.addQuest
{
    internal class uploadBTN : ICommand
    {
        public event EventHandler CanExecuteChanged;

        AddNewQusetViewModel AddNewQusetViewModel { get; set; }

        public uploadBTN(AddNewQusetViewModel addNewQusetViewModel)
        {
            AddNewQusetViewModel=addNewQusetViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(AddNewQusetViewModel.Question.image != "" && AddNewQusetViewModel.Question.title != "")
            {
                uploadImage uploadImage = new uploadImage(AddNewQusetViewModel.Question.image.ToString(), AddNewQusetViewModel.Question.title,Context.Account);
                uploadImage.Upload();
            }
        }
    }
}
