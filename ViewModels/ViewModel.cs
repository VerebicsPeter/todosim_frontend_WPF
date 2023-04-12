using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Game.WPF.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        protected ViewModel() { }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] String? propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
