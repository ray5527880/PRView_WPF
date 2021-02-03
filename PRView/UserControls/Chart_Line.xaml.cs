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

namespace PRView.UserControls
{
    /// <summary>
    /// Chart_Line.xaml 的互動邏輯
    /// </summary>
    public partial class Chart_Line : UserControl
    {
        public double UserControlWidth
        {
            get => (double)GetValue(UserControlWidthProperty);
            set => SetValue(UserControlWidthProperty, value);
        }
        public static readonly DependencyProperty UserControlWidthProperty = DependencyProperty.Register(
            nameof(UserControlWidth), typeof(double), typeof(Chart_Line),
            new PropertyMetadata(default(double), OnUserControlWidthChanged, CoerceUserControlWidthValue));
        private static void OnUserControlWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as Chart_Line; 
            
        }
        private static object CoerceUserControlWidthValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }


        public double UserControlHeight
        {
            get => (double)GetValue(UserControlHeightProperty);
            set => SetValue(UserControlHeightProperty, value);
        }
        public static readonly DependencyProperty UserControlHeightProperty = DependencyProperty.Register(
            nameof(UserControlHeight), typeof(double), typeof(Chart_Line), 
            new PropertyMetadata(default(double), OnUserControlHeightChanged, CoerceUserControlHeightValue));
        private static void OnUserControlHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as Chart_Line;

        }
        private static object CoerceUserControlHeightValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
      
        #region ChartDatas        
        public List<double[]> ChartDatas
        {
            get => (List<double[]>)GetValue(ChartDatasProperty);
            set => SetValue(ChartDatasProperty, value);
        }
        public static readonly DependencyProperty ChartDatasProperty = DependencyProperty.Register(
           nameof(ChartDatas), typeof(List<double[]>), typeof(Chart_Line),
           new PropertyMetadata(default(List<double[]>), OnChartDatasChanged, CoerceChartDatasValue));
        private static void OnChartDatasChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as Chart_Line;
            _data.MahtChartCanvas = AddMainChart(_data.ChartDatas);
        }
        private static object CoerceChartDatasValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region ViewMaxValueX
        public int ViewMaxValueX
        {
            get => (int)GetValue(ViewMaxValueXProperty);
            set => SetValue(ViewMaxValueXProperty, value);
        }
        public static readonly DependencyProperty ViewMaxValueXProperty = DependencyProperty.Register(
            nameof(ViewMaxValueX), typeof(int), typeof(Chart_Line),
            new PropertyMetadata(default(int), OnViewMaxValueXChanged, CoerceViewMaxValueXValue));
        private static void OnViewMaxValueXChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _View = d as Chart_Line;
            GridBlock(_View, _View.NumberOfGridX, _View.NumberOfGridY);
        }
        private static object CoerceViewMaxValueXValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region ViewMinValueX
        public int ViewMinValueX
        {
            get => (int)GetValue(ViewMinValueXProperty);
            set => SetValue(ViewMinValueXProperty, value);
        }
        public static readonly DependencyProperty ViewMinValueXProperty = DependencyProperty.Register(
            nameof(ViewMinValueX), typeof(int), typeof(Chart_Line),
            new PropertyMetadata(default(int), OnViewMinValueXChanged, CoerceViewMinValueXValue));
        private static void OnViewMinValueXChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _View = d as Chart_Line;
            GridBlock(_View, _View.NumberOfGridX, _View.NumberOfGridY);
        }
        private static object CoerceViewMinValueXValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region ViewMaxValueY
        public int ViewMaxValueY
        {
            get => (int)GetValue(ViewMaxValueYProperty);
            set => SetValue(ViewMaxValueYProperty, value);
        }
        public static readonly DependencyProperty ViewMaxValueYProperty = DependencyProperty.Register(
            nameof(ViewMaxValueY), typeof(int), typeof(Chart_Line),
            new PropertyMetadata(default(int), OnViewMaxValueYChanged, CoerceViewMaxValueYValue));
        private static void OnViewMaxValueYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _View = d as Chart_Line;
            GridBlock(_View, _View.NumberOfGridX, _View.NumberOfGridY);
        }
        private static object CoerceViewMaxValueYValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region ViewMinValueY
        public int ViewMinValueY
        {
            get => (int)GetValue(ViewMinValueYProperty);
            set => SetValue(ViewMinValueYProperty, value);
        }
        public static readonly DependencyProperty ViewMinValueYProperty = DependencyProperty.Register(
           nameof(ViewMinValueY), typeof(int), typeof(Chart_Line),
           new PropertyMetadata(default(int), OnViewMinValueYChanged, CoerceViewMinValueYValue));
        private static void OnViewMinValueYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _View = d as Chart_Line;
            GridBlock(_View, _View.NumberOfGridX, _View.NumberOfGridY);
        }
        private static object CoerceViewMinValueYValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region NumberOfGridX
        public int NumberOfGridX
        {
            get => (int)GetValue(NumberOfGridXProperty);
            set => SetValue(NumberOfGridXProperty, value);
        }
        public static readonly DependencyProperty NumberOfGridXProperty = DependencyProperty.Register(
           nameof(NumberOfGridX), typeof(int), typeof(Chart_Line),
           new PropertyMetadata(default(int), OnNumberOfGridXChanged, CoerceNumberOfGridXValue));
        private static void OnNumberOfGridXChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
        private static object CoerceNumberOfGridXValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region NumberOfGridY
        public int NumberOfGridY
        {
            get => (int)GetValue(NumberOfGridYProperty);
            set => SetValue(NumberOfGridYProperty, value);
        }
        public static readonly DependencyProperty NumberOfGridYProperty = DependencyProperty.Register(
           nameof(NumberOfGridY), typeof(int), typeof(Chart_Line),
           new PropertyMetadata(default(int), OnNumberOfGridYChanged, CoerceNumberOfGridYValue));
        private static void OnNumberOfGridYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
        private static object CoerceNumberOfGridYValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region IsSingleFile
        public bool IsSingleFile
        {
            get => (bool)GetValue(IsSingleFileProperty);
            set => SetValue(IsSingleFileProperty, value);
        }
        public static readonly DependencyProperty IsSingleFileProperty = DependencyProperty.Register(
          nameof(IsSingleFile), typeof(bool), typeof(Chart_Line),
          new PropertyMetadata(default(bool), OnIsSingleFileChanged, CoerceIsSingleFileValue));
        private static void OnIsSingleFileChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as Chart_Line;
            _data.MaxValueX = 60 * 1000;
        }
        private static object CoerceIsSingleFileValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }

        #endregion

        #region IsViewVisible
        public bool IsViewVisible
        {
            get => (bool)GetValue(IsViewVisibleProperty);
            set => SetValue(IsViewVisibleProperty, value);
        }
        public static readonly DependencyProperty IsViewVisibleProperty = DependencyProperty.Register(
            nameof(IsViewVisible), typeof(bool), typeof(Chart_Line), new PropertyMetadata());

        #endregion
        public double MaxValueX;
        public double MinValueX;
        public double MaxValueY;
        public double MinValueY;

        public Chart_Line()
        {
            InitializeComponent();
        }

        private static void GridBlock(Chart_Line chart_Line, int _NumberOfGridX, int _NumberOfGridY)
        {
            var NumberOfGridY_Height = (chart_Line.UserControlHeight - 80) / _NumberOfGridY;
            var NumberOfGridX_Width = (chart_Line.UserControlWidth - 70) / _NumberOfGridX;
                        
            chart_Line.ViewGridBlock.Children.Clear();
            ///-------------
            chart_Line.ViewGridBlock.Children.Add(SetGridBlockLine(70, 50, chart_Line.UserControlWidth, 0));

            for (int i = 1; i < _NumberOfGridY; i++)
            {
                chart_Line.ViewGridBlock.Children.Add(SetGridBlockLine(70, 50 + NumberOfGridY_Height * i, chart_Line.UserControlWidth, 0));
            }

            chart_Line.ViewGridBlock.Children.Add(SetGridBlockLine(70, chart_Line.UserControlHeight - 30, chart_Line.UserControlWidth, 0));
            //-------------
            chart_Line.ViewGridBlock.Children.Add(SetGridBlockLine(70, 50, 0, chart_Line.UserControlHeight - 80));

            for (int i = 1; i < _NumberOfGridX; i++)
            {
                chart_Line.ViewGridBlock.Children.Add(SetGridBlockLine(70 + NumberOfGridX_Width * i, 50, 0, chart_Line.UserControlHeight - 80));
            }

            chart_Line.ViewGridBlock.Children.Add(SetGridBlockLine(70, chart_Line.UserControlWidth, 0, chart_Line.UserControlHeight - 80));

            chart_Line.ViewGridBlock.Background = Brushes.White;          
        }

        private static Path SetGridBlockLine(double startX, double startY, double width, double height)
        {
            var rePath = new Path();
            string str = string.Format("M {0},{1} l {2},{3}", startX, startY, width, height);
            rePath.Data = Geometry.Parse(str);
            SolidColorBrush myBrush = new SolidColorBrush(Colors.Black);
            rePath.Stroke = myBrush;
            return rePath;
        }

        private static Canvas AddMainChart(List<double[]> _ChartDatas)
        {
            var reCanvas = new Canvas();

            var _data = new string[_ChartDatas[0].Length - 1];

            for (int i = 0; i < _ChartDatas.Count; i++)
            {
                for (int j = 0; j < _ChartDatas[i].Length; j++)
                {
                    if (i == 0)
                        _data[j] += string.Format("M {0},{1}", 0, _ChartDatas[i][j + 1]);
                    else
                        _data[j] += string.Format(" {0},{1}", _ChartDatas[i][0], _ChartDatas[i][j + 1]);
                }
            }
            for (int i = 0; i < _ChartDatas[0].Length - 1; i++)
            {
                var _path = new Path();
                _path.Data = Geometry.Parse(_data[i]);
                reCanvas.Children.Add(_path);
            }

            return reCanvas;
        }
        private static Canvas TextBlock()
        {
            var reCanvas = new Canvas();



            return reCanvas;
        }
    }
}
