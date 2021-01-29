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

        #region ChartDatas        
        public List<double[]> ChartDatas
        {
            get => (List<double[]>)GetValue(ChartDatasProperty);
            set => SetValue(ChartDatasProperty, value);
        }
        public static readonly DependencyProperty ChartDatasProperty = DependencyProperty.Register(
           nameof(ChartDatas), typeof(List<double[]>), typeof(Chart_Line),
           new PropertyMetadata(default(int), OnChartDatasChanged, CoerceChartDatasValue));
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
            nameof(ViewMinValueX), typeof(int), typeof(Chart_Line),
            new PropertyMetadata(default(int), OnViewMaxValueYChanged, CoerceViewMaxValueYValue));
        private static void OnViewMaxValueYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

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
           nameof(ViewMinValueX), typeof(int), typeof(Chart_Line),
           new PropertyMetadata(default(int), OnViewMinValueYChanged, CoerceViewMinValueYValue));
        private static void OnViewMinValueYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
        private static object CoerceViewMinValueYValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region IsSingleFile
        public bool IsSingleFile;
        public static readonly DependencyProperty IsSingleFileProperty = DependencyProperty.Register(
          nameof(IsSingleFile), typeof(bool), typeof(Chart_Line),
          new PropertyMetadata(default(int), OnIsSingleFileChanged, CoerceIsSingleFileValue));
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

        public double MaxValueX;
        public double MinValueX;
        public double MaxValueY;
        public double MinValueY;

        public Chart_Line()
        {
            InitializeComponent();
        }

        private static Canvas GridBlock(Chart_Line chart_Line)
        {
            var reCanvas = new Canvas();

            return reCanvas;
        }
        private static Canvas AddMainChart(List<double[]> _ChartDatas)
        {
            var reCanvas = new Canvas();

            var _data = new string[_ChartDatas[0].Length - 1];
            
            for (int i = 0; i < _ChartDatas.Count; i++)
            {
               for(int j = 0; j < _ChartDatas[i].Length; j++)
                {
                    if (i == 0)
                        _data[j] += string.Format("M {0},{1}",0, _ChartDatas[i][j + 1]);
                    else
                        _data[j] += string.Format(" {0},{1}", _ChartDatas[i][0], _ChartDatas[i][j + 1]);
                }
            }
            for(int i = 0; i < _ChartDatas[0].Length - 1; i++)
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
