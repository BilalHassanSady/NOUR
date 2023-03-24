using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nour.model.firebase;

namespace Nour.viewmodel.Commands.questList
{
    internal class selectItemLIST
    {
        public AskPageViewModel AskPageViewModel { get; set; }

        public selectItemLIST(AskPageViewModel askPageViewModel)
        {
            AskPageViewModel=askPageViewModel;
        }

        public async Task executeAsync()
        {
            downloadQuestion downloadQuestion = new downloadQuestion(AskPageViewModel._selectedQuestion);
            await downloadQuestion.downloadAsync();
        }
    }
}
