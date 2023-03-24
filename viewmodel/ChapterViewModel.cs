using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nour.viewmodel.Commands.chapters;

namespace Nour.viewmodel
{
    internal class ChapterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public openWeb OpenWeb { get; set; }

        public ChapterViewModel() {
            this.OpenWeb = new openWeb();
        }
    }
}
