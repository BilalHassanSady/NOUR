using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics;
using Nour.view;


namespace Nour.viewmodel.Commands.chapters
{
    internal class openWeb : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch (parameter)
            {
                case "kinetics":
                    Process.Start("https://drive.google.com/drive/folders/1vDn6vpPBb4Bj8GtROuo7cIiMrd-Nm6IN");
                    break;
                case "kinetics_q":
                    Process.Start("https://drive.google.com/drive/folders/1BcFpYnOMeee_bIOKExv4G-63gGfuwsBB");
                    break;
                case "electro":
                    Process.Start("https://drive.google.com/drive/folders/1ktum0KinpTIP70yGFParUVWLIocRegJy");
                    break;
                case "electro_q":
                    Process.Start("https://drive.google.com/drive/folders/1mVFNEG7LfHtLuDqJEztMQGsuXtSaAZkM");
                    break;
                case "equilibrium":
                    Process.Start("https://drive.google.com/drive/folders/1ZrUlvhQTjycQRlNWFvt6ELr4vEKcYd56");
                    break; 
                case "equilibrium_q":
                    Process.Start("https://drive.google.com/drive/folders/1rEG8zyuAQhvIr4EjjO7Reh9ZICi5BClW");
                    break;
                case "organic":
                    Process.Start("https://drive.google.com/drive/folders/1O0hayjQOjiAG2Q-TFuwz7VpBSW3zq1tN");
                    break; 
                case "organic_q":
                    Process.Start("https://drive.google.com/drive/folders/1SYqnAij7xrIbSrBBfXNpfsRM3VRB1Yix");
                    break;
                case "stoichiometry":
                    Process.Start("https://drive.google.com/drive/folders/1uVeWtLxs2AUrcgG65Zjm9aW0Luj6WQuV");
                    break;
                case "stoichiometry_q":
                    Process.Start("https://drive.google.com/drive/folders/18yP-MEDXGyIL5idsW1MjNb7aeBEX4sM5");
                    break;
                case "TOC":
                    Process.Start("https://drive.google.com/drive/folders/1arAx3oKkGS4cNt31H0xqzOpkczDnDPmR");
                    break;
                case "URT":
                    Process.Start("https://drive.google.com/drive/folders/1mpWiO1m1QWkZ8YTjbekx44JMNUqGNwal");
                    break;
                case "ASK":
                    AskPage askPage = new AskPage();
                    ((MainWindow)Context.context).Frame.NavigationService.Navigate(askPage);
                    break;
            }
        }
    }
}
