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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}