using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nour.model
{
    internal class chapter
    {
        public string name { get; set; }
        public string chapter_pdf { get; set; }
        public string homework_pdf { get; set; }
        public chapter(string name,string chapter_pdf,string homework_pdf) 
        {
            this.name = name;
            this.chapter_pdf = chapter_pdf;
            this.homework_pdf = homework_pdf;
        }
    }
}
