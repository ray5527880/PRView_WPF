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
        private string[] _ButtonName;
        public string[] ButtonName { set { _ButtonName = value;AddButton(); }get { return _ButtonName; } }
        public ButtonBlock()
        {
            ButtonName = new string[0];
            InitializeComponent();
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
