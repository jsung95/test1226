using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyProject.Model;
using Microsoft.Expression.Interactivity.Core;
using System.Windows.Input;

namespace EasyProject.ViewModel
{
    public class MainViewModel : Notifier
    {
        private int switchView;
        public int SwitchView
        {
            get { return switchView; }
            set {
                switchView = value;
                OnPropertyChanged("SwitchView");
                Console.WriteLine("SwitchView : " + SwitchView);
            }
        }


        public MainViewModel()
        {
            SwitchView = 0;
            SwitchViewCommand = new RelayCommand<object>(p => OnSwitchView(p));
            
        }

        
        public ICommand SwitchViewCommand
        {
            get;
        }

        public void OnSwitchView(object index)
        {
            SwitchView = int.Parse(index.ToString());
            Console.WriteLine("onswitchview : " + index);
        }


    }
}
