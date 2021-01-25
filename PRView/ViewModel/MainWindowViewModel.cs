using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Microsoft.Win32;
using PRView.Model;

namespace PRView.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _Location = "Location：";
        private string _Device = "Device：";
        private string _StartData = "開始日期：";
        private string _TriggerData = "觸發日期：";
        private string _StartTime = "開始時間：";
        private string _TriggerTime = "觸發時間：";
        public MainWindowViewModel()
        {            
            btn_ReZoom = new RelayCommand<object>(() => test_messagebox());
            btn_OpenFile = new RelayCommand<object>(() => OpenFile());
        }
        private void test_messagebox()
        {
            System.Windows.MessageBox.Show("123");
            Locastion = "123";
            ButtonBlock = new string[] { "123", "456", "789" };
            //ButtonBlock = 1;
            //this.AnalogBlack.c

        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DR-files(*.zip;*.cfg)|*.zip;*.cfg";
            if (openFileDialog.ShowDialog() == true)
                System.Windows.MessageBox.Show(openFileDialog.SafeFileName);
                
                //txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }
        public System.Windows.Controls.Grid AnalogBlack { set; get; }
        

        public string Locastion { set { _Location = "Location：" + value; } get { return _Location; } }
        public string Device { set { _Device = "Device：" + value; } get { return _Device; } }
        public string StartData { set { _StartData = "開始日期：" + value; } get { return _Device; } }
        public string TriggerData { set { _TriggerData = "觸發日期：" + value; } get { return _TriggerData; } }
        public string StartTime { set { _StartTime = "開始時間：" + value; } get { return _StartTime; } }
        public string TriggerTime { set { _TriggerTime = "觸發時間：" + value; } get { return _TriggerTime; } }

        public string[] ButtonBlock { get; set; } = new string[0];

        public bool btn_Enabled { set; get; } = true;

        public ICommand buttondown { get; }
        public ICommand btn_XZoomIn { get; }
        public ICommand btn_XZoomOut { get; }
        public ICommand btn_YZoomIn { get; }
        public ICommand btn_YZoomOut { get; }
        public ICommand btn_ReZoom { get; }
        public ICommand btn_OpenFile { get; }
        public ICommand bnt_DowloadFile { get; }
        public ICommand bnt_Setup { get; }
        public ICommand btn_VS { get; }
        public ICommand btn_Screenshot { get; }
        public ICommand btn_ReomveBlack { get; }
        public ICommand btn_Extremum { get; }
    }
}
