using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

namespace PRView.UserControls
{
    /// <summary>
    /// ButtonBlock.xaml 的互動邏輯
    /// </summary>
    public partial class ButtonBlock : UserControl
    {      
        public string[] ButtonName
        {
            get => (string[])GetValue(ButtonNameProperty);
            set => SetValue(ButtonNameProperty, value); 
        }
        public static readonly DependencyProperty ButtonNameProperty = DependencyProperty.Register(
            nameof(ButtonName), typeof(string[]), typeof(ButtonBlock),
            new PropertyMetadata(default(string[]), OnButtonNameValueChanged, CoerceButtonNameValue));

        private static void OnButtonNameValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _usercontrols = d as ButtonBlock;
            if (_usercontrols.ButtonName.Length != 0)
            {                
                _usercontrols.Panel.Children.Clear();
                for (int i = 0; i < _usercontrols.ButtonName.Length; i++)
                {
                    var _button = new Button()
                    {
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Width = 90,
                        Height = 30,
                        Name = string.Format("Button{0}",i+1),
                        Content = _usercontrols.ButtonName[i],
                        FontSize=14
                    };
                    _button.Click += Button_Click;
                    _usercontrols.Panel.Children.Add(_button);
                }                
            }
        }
              
        private static object CoerceButtonNameValue(DependencyObject d, object baseValue)
        {            
            return baseValue;
        }
       
        public ButtonBlock()
        {           
            InitializeComponent();            
        }
        private static void Button_Click(object sender,RoutedEventArgs eventArgs)
        {
            var _obj = sender as Button;
            MessageBox.Show("123");            
        }
    }
}
