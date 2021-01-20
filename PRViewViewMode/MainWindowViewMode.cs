using System;
using System.Windows.Input;

namespace PRViewViewMode
{
    public class MainWindowViewMode
    {
        public MainWindowViewMode()
        {
            
        }
        public string Locastion { set; get; } = "Location：";
        public string Device { set; get; } = "Device：";
        public string StartData { set; get; } = "開始日期：xxxx/xx/xx";
        public string TriggerData { set; get; } = "觸發日期：xxxx/xx/xx";
        public string StartTime { set; get; } = "開始時間：xx:xx:xx";
        public string TriggerTime { set; get; } = "觸發時間：xx:xx:xx";
    }
}
