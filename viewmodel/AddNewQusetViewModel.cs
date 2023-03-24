using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nour.viewmodel.Commands.addQuest;
using Nour.model;

namespace Nour.viewmodel
{
    internal class AddNewQusetViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Question Question { get; set; }

        public openFileBTN OpenFileBTN { get; set; }
        public uploadBTN UploadBTN { get; set; }

        public AddNewQusetViewModel()
        {
            Question = new Question();
            this.OpenFileBTN = new openFileBTN(this);
            this.UploadBTN = new uploadBTN(this);
        }
    }
}
