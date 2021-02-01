using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Microsoft.Win32;
using PRView.Model;
using PRView.UserControls;

namespace PRView.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private MainWindowData _MainWindowData;


        private string _Location = "Location：";
        private string _Device = "Device：";
        private string _StartData = "開始日期：";
        private string _TriggerData = "觸發日期：";
        private string _StartTime = "開始時間：";
        private string _TriggerTime = "觸發時間：";
        public MainWindowViewModel()
        {
            _MainWindowData = new MainWindowData();
             btn_ReZoom = new RelayCommand<object>(() => test_messagebox());
            btn_XZoomIn = new RelayCommand<object>(() => test_MessageBox_1());
            btn_OpenFile = new RelayCommand<object>(() => OpenFile());
        }
        private void test_messagebox()
        {            
            Locastion = "123";
            Chart1Enable = true;
           
            AnalogBlockName = new string[] { "qwe" };
        }
        private void test_MessageBox_1()
        {
            NumberOfGridX = 6;
            NumberOfGridY = 10;
            ViewMaxValueX = 10;
            ViewMinValueX = -10;
        }


        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DR-files(*.zip;*.cfg)|*.zip;*.cfg";
            if (openFileDialog.ShowDialog() == true)
                System.Windows.MessageBox.Show(openFileDialog.SafeFileName);
                
                //txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }

        #region General Information
        public string Locastion { set { _Location = "Location：" + value; } get { return _Location; } }
        public string Device { set { _Device = "Device：" + value; } get { return _Device; } }
        public string StartData { set { _StartData = "開始日期：" + value; } get { return _StartData; } }
        public string TriggerData { set { _TriggerData = "觸發日期：" + value; } get { return _TriggerData; } }
        public string StartTime { set { _StartTime = "開始時間：" + value; } get { return _StartTime; } }
        public string TriggerTime { set { _TriggerTime = "觸發時間：" + value; } get { return _TriggerTime; } }
        #endregion

        #region ButtonBlock

        public string[] AnalogBlockName { get; set; }
        public string [] DigitalBlockName { get; set; }

        #endregion

        public double ViewMaxValueX { get; set; }
        public double ViewMinValueX { get; set; }
        public double ViewMaxValueY { get; set; }
        public double ViewMinValueY { get; set; }

        public int NumberOfGridX { get; set; }
        public int NumberOfGridY { get; set; }

        public bool Chart1Enable { get; set; }

        public bool btn_Enabled { set; get; } = true;

        #region ButtonControls

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
        #endregion

        private void Set_GeneralInformation()
        {
            Locastion = _MainWindowData.Location;
            Device = _MainWindowData.Device;
            StartData = _MainWindowData.StartData;
            TriggerData = _MainWindowData.TriggerData;
            StartTime = _MainWindowData.StartTime;
            TriggerTime = _MainWindowData.TriggerTime;
        }
    }
}
