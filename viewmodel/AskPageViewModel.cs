using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Nour.viewmodel.Commands.questList;
using Nour.model.firebase;

namespace Nour.viewmodel
{
    internal class AskPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public NavigateBTN NavigateBTN { get; set; }

        public List<string> Questions { get; set; }
        public List<string> _Questions
        {
            get { return Questions; }
            set
            {
                if (value == null)
                    return;
                Questions = value;
                RaisePropertyChangedEvent();
            }
        }

        public string selectedQuestion { get; set; }
        public string _selectedQuestion { get { return selectedQuestion; }
            set
            {
                if (value == null)
                    return;
                selectedQuestion = value;
                RaisePropertyChangedEvent();
                selectItemLIST selectItemLIST = new selectItemLIST(this);
                selectItemLIST.executeAsync();
            }
        }

        public AskPageViewModel()
        {
            this.NavigateBTN = new NavigateBTN();
            getListUser getListUser = new getListUser(Context.Account);
            var result = getListUser.getListAsync();
            Task.Delay(3000).Wait();
            _Questions = result.Result;
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
