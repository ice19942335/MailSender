using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace MVVM_DevExpressMvvm_NuGet.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public int Clicks { get; set; }

        public ICommand ClickAdd
        {
            get {return new DelegateCommand(() => { Clicks++;});}
        }
    }
}
