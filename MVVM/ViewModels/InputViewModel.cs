using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class InputViewModel : BaseViewModel
    {
        private ObservableCollection<Input> _List;
        public ObservableCollection<Input> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        public InputViewModel()
        {
            int _2h = 100;
            List = new ObservableCollection<Input>(DataContext.ins.Inputs.Where(x => x.Price < _2h));
        }
    }
}
