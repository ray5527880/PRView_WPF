using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;


namespace PRView.ViewMode
{
    public class MainWindowViewMode :ViewModelBase
    {
        public MainWindowViewMode()
        {
            buttondown = new RelayCommand(()=>Locastion="123");
        }
        //public RelayCommand(Action action, Func<bool> canExecute)
        //{
        //    return true;
        //}
        public string Locastion { set; get; } = "Location：";
        public string Device { set; get; } = "Device：";
        public string StartData { set; get; } = "開始日期：";
        public string TriggerData { set; get; } = "觸發日期：";
        public string StartTime { set; get; } = "開始時間：";
        public string TriggerTime { set; get; } = "觸發時間：";

        public ICommand buttondown {  get; }
    }
}
