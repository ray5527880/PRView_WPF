using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace PRViewViewMode
{
    public class testUserConViewMode
    {
        public testUserConViewMode()
        {
            
        }
        public string path { set; get; } = "M 10,10";

        public ICommand command { set; get; }
    }
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
