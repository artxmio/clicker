using System.ComponentModel;

namespace clicker.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanched(string property_name)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property_name));
    }
}