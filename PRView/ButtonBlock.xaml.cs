using System;
using System.Collections.Generic;
using System.Text;
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
    /// ButtonBlock.xaml 的互動邏輯
    /// </summary>
    public partial class ButtonBlock : UserControl
    {
        public string[] ButtonName
        {
            //get { return _ButtonName; }
            //set { _ButtonName = value;AddButton(); }
            get { return (string[])GetValue(ButtonNameProperty); }
            set {
                Console.WriteLine("ButtonName Set");
                _ButtonName = value;
                AddButton();
                SetValue(ButtonNameProperty, value); 
               
            }
        }
        public static readonly DependencyProperty ButtonNameProperty = DependencyProperty.Register(
            nameof(ButtonName), typeof(string[]), typeof(ButtonBlock),
            new PropertyMetadata(default(string[]), OnButtonNameValueChanged, CoerceButtonNameValue));

        private string[] _ButtonName;

        private static void OnButtonNameValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
            //Debugger.Break();
        }
        private static object CoerceButtonNameValue(DependencyObject d, object baseValue)
        {
            //Debugger.Break();
            return baseValue;
        }
        //public string[] ButtonName { set { _ButtonName = value; AddButton(); } get { return _ButtonName; } }
        public ButtonBlock()
        {
            this.DataContext = this;
            InitializeComponent();
            //ButtonName = new string[0];
            //_ButtonName = new string[] { "123", "456" };
            //AddButton();

        }

        private void AddButton()
        {
            if (_ButtonName.Length != 0)
            {
                this.Panel.Children.Clear();
                for (int i = 0; i < _ButtonName.Length; i++)
                {
                    var _button = new Button()
                    {
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Width = 90,
                        Height = 30,
                        Name = string.Format("Button{0}", i + 1),
                        Content = _ButtonName[i]
                    };
                    this.Panel.Children.Add(_button);

                }
            }
        }
    }
}
