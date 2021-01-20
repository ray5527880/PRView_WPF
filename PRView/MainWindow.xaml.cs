using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Binding Binding = new Binding();
        private MyData my_Data = new MyData();
        testUserCon frm = new testUserCon();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_PreviewTouchMove(object sender, TouchEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (testGrid.Children.Count == 0)
            {
                
                //NavigationService.Navigate(frm);
                testGrid.Children.Add(frm);
                //testGrid.cont

                //testCanvas.con
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (testGrid.Children.Count != 0)
            {
                this.frm.RenderTransform = new ScaleTransform() { ScaleX = 0.5f, ScaleY = 0.5f };
            }
        }
    }
    public class MyData : INotifyPropertyChanged
    {
        private string m_TextMsg;
        public string TextMsg
        {
            set
            {
                if (m_TextMsg != value)
                {
                    m_TextMsg = value;
                    OnPropertyChanged("TextMsg");
                }
            }
            get
            {
                return m_TextMsg;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
