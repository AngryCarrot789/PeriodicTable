using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PeriodicTable.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //CallerMemberName makes calling this easier
        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            //This basically tells the UI to refresh anything binded with the property name given to update
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
