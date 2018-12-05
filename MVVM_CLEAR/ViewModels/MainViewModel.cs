using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_CLEAR.Annotations;
using MVVM_CLEAR.Command;

namespace MVVM_CLEAR.ViewModels
{
    class MainViewModel : BaseVm
    {
        private int _clicks;

        public int Clicks
        {
            get => _clicks;
            set
            {
                _clicks = value;
                OnPropertyChanged(nameof(Clicks));
            }
        }

        public ICommand ClickAdd
        {
            get
            {
                return new DelegateCommand(
                    obj => {Clicks++;},
                    obj => Clicks < 10
                ); 
            }
        }


        ////При инициализации запускает счетчик в другом потоке
        //public MainViewModel()
        //{
        //    Task.Factory.StartNew(() =>
        //    {
        //        while (true)
        //        {
        //            Task.Delay(1000).Wait();

        //            Clicks++;
        //        }
        //    });
        //}

    }
}
