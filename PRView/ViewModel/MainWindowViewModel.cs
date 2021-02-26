using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Microsoft.Win32;
using PRView.Model;
using PRView.UserControls;
using System.Threading.Tasks;

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
            btn_XZoomOut = new RelayCommand<object>(() => test_messagebox2());
            btn_YZoomIn = new RelayCommand<object>(() => test_ZoomIn());
            btn_YZoomOut = new RelayCommand<object>(() => test_ZoomOut());
            //WindowsSizeChanged = new RelayCommand<object>(() => _WindowsSizeChanged());

        }
        private void test_messagebox()
        {
            Locastion = "123";
            Chart1Enable = false;
            Chart2Enable = false;
            Chart3Enable = false;
            Chart4Enable = false;
            Chart5Enable = false;

            AnalogBlockName = new string[] { "qwe" };
        }
        private void test_MessageBox_1()
        {
            ChartMaxValueX = 5000;
            ChartMinValueX = 0;

            Chart1Enable = true;
            var _data = new List<double[]>();
            NumberOfGridX = 6;
            NumberOfGridY = 10;
            ViewMaxValueX = 10;
            ViewMinValueX = -10;
            Task.Run(() =>
            {
                for (int i = 0; i < 19200; i++)
                {
                    var _datas = new double[6]
                    {
                    i,(Math.Sin(Math.PI * i / 180) * 50 + 100),i+50,200,300,400
                    };
                    _data.Add(_datas);
                }
                datas = _data;
            });
        }
        private void test_messagebox2()
        {
            Chart2Enable = true;
        }
        private void test_ZoomIn()
        {

        }
        private void test_ZoomOut()
        {

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

        public double ScrollBarValue { get; set; }

        #region ButtonBlock

        public string[] AnalogBlockName { get; set; }
        public string[] DigitalBlockName { get; set; }

        #endregion

        #region MainView Value
        public double MainViewHeight { get; set; }
        public double MainViewWidth { get; set; }

        public List<double[]> datas { get; set; }

        public double ChartMaxValueX { get; set; }
        public double ChartMinValueX { get; set; }

        public double ViewMaxValueX { get; set; }
        public double ViewMinValueX { get; set; }
        public double ViewMaxValueY { get; set; }
        public double ViewMinValueY { get; set; }

        public int NumberOfGridX { get; set; }
        public int NumberOfGridY { get; set; }

        public bool Chart1Enable { get; set; }
        public bool Chart2Enable { get; set; }
        public bool Chart3Enable { get; set; }
        public bool Chart4Enable { get; set; }
        public bool Chart5Enable { get; set; }

        #endregion
        #region MainView Controls

        #endregion

        public bool btn_Enabled { set; get; } = true;

        public void WindowsSizeChanged()
        {
            //System.Windows.MessageBox.Show(string.Format("{0},{1}", MainViewHeight, MainViewWidth));
        }

        #region ButtonControls

        public ICommand buttondown { get; }
        public ICommand btn_XZoomIn { get; }
        public ICommand btn_XZoomOut { get; }
        public ICommand btn_YZoomIn { get; }
        public ICommand btn_YZoomOut { get; }
        public ICommand btn_ReZoom { get; }
        public ICommand btn_OpenFile { get; }
        public ICommand btn_DowloadFile { get; }
        public ICommand btn_Setup { get; }
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
