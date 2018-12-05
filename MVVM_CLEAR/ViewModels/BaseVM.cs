using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVM_CLEAR.Annotations;

namespace MVVM_CLEAR.ViewModels
{
    public class BaseVm : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}