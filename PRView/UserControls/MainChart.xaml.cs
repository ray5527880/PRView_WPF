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
    /// MainChart.xaml 的互動邏輯
    /// </summary>
    public partial class MainChart : UserControl
    {
        public double PointY_1 { get; set; }
        public double PointX { get; set; }


        public int testInt { get; set; }
        public static readonly DependencyProperty testIntProperty = DependencyProperty.Register(
            nameof(testInt), typeof(int), typeof(MainChart), new PropertyMetadata());

        //public double ChartWidth { get; set; }
        //public double ChartHeight { get; set; }
        private double scale_X { get; set; }

       

        private double scale_Y { get; set; }


        #region Chart1_Enable
        public bool Chart1_Enable
        {
            get => (bool)GetValue(Chart1_EnableProperty);
            set => SetValue(Chart1_EnableProperty, value);
        }
        public static readonly DependencyProperty Chart1_EnableProperty = DependencyProperty.Register(
            nameof(Chart1_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnChart1_EnableChanged, CoerceChart1_EnableValue));
        private static void OnChart1_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_1.Height = _data.Chart1_Enable ? new GridLength(1, GridUnitType.Star) : new GridLength(0, GridUnitType.Pixel); 
        }
        private static object CoerceChart1_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Chart2_Enable
        public bool Chart2_Enable
        {
            get => (bool)GetValue(Chart2_EnableProperty);
            set => SetValue(Chart2_EnableProperty, value);
        }
        public static readonly DependencyProperty Chart2_EnableProperty = DependencyProperty.Register(
            nameof(Chart2_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnChart2_EnableChanged, CoerceChart2_EnableValue));
        private static void OnChart2_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_2.Height = _data.Chart2_Enable ? new GridLength(1, GridUnitType.Star) : new GridLength(0, GridUnitType.Pixel);
        }
        private static object CoerceChart2_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Chart3_Enable
        public bool Chart3_Enable
        {
            get => (bool)GetValue(Chart3_EnableProperty);
            set => SetValue(Chart3_EnableProperty, value);
        }
        public static readonly DependencyProperty Chart3_EnableProperty = DependencyProperty.Register(
            nameof(Chart3_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnChart3_EnableChanged, CoerceChart3_EnableValue));
        private static void OnChart3_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_3.Height = _data.Chart3_Enable ? new GridLength(1, GridUnitType.Star) : new GridLength(0, GridUnitType.Pixel);
        }
        private static object CoerceChart3_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Canvas4_Enable
        public bool Chart4_Enable
        {
            get => (bool)GetValue(Chart4_EnableProperty);
            set => SetValue(Chart4_EnableProperty, value);
        }
        public static readonly DependencyProperty Chart4_EnableProperty = DependencyProperty.Register(
            nameof(Chart4_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnChart4_EnableChanged, CoerceChart4_EnableValue));
        private static void OnChart4_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_4.Height = _data.Chart4_Enable ? new GridLength(1, GridUnitType.Star) : new GridLength(0, GridUnitType.Pixel);
        }
        private static object CoerceChart4_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Chart5_Enable
        public bool Chart5_Enable
        {
            get => (bool)GetValue(Chart5_EnableProperty);
            set => SetValue(Chart5_EnableProperty, value);
        }
        public static readonly DependencyProperty Chart5_EnableProperty = DependencyProperty.Register(
            nameof(Chart5_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnChart5_EnableChanged, CoerceChart5_EnableValue));
        private static void OnChart5_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_5.Height = _data.Chart5_Enable ? new GridLength(120, GridUnitType.Pixel) : new GridLength(0, GridUnitType.Pixel);
        }
        private static object CoerceChart5_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Chart_Line_1

        public List<double[]> Chart_Line_Data_1
        {
            get => (List<double[]>)GetValue(Chart_Line_Data_1Property);
            set => SetValue(Chart_Line_Data_1Property, value);
        }
        public static readonly DependencyProperty Chart_Line_Data_1Property = DependencyProperty.Register(
            nameof(Chart_Line_Data_1), typeof(List<double[]>), typeof(MainChart),
            new PropertyMetadata());

        #endregion

        #region ViewMaxValueX
        public int ViewMaxValueX
        {
            get => (int)GetValue(ViewMaxValueXProperty);
            set => SetValue(ViewMaxValueXProperty, value);
        }
        public static readonly DependencyProperty ViewMaxValueXProperty = DependencyProperty.Register(
            nameof(ViewMaxValueX), typeof(int), typeof(MainChart),
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
            nameof(ViewMinValueX), typeof(int), typeof(MainChart),
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
            nameof(ViewMaxValueY), typeof(int), typeof(MainChart),
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
           nameof(ViewMinValueY), typeof(int), typeof(MainChart),
           new PropertyMetadata(default(int), OnViewMinValueYChanged, CoerceViewMinValueYValue));
        private static void OnViewMinValueYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

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
           nameof(NumberOfGridX), typeof(int), typeof(MainChart),
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
           nameof(NumberOfGridY), typeof(int), typeof(MainChart),
           new PropertyMetadata(default(int), OnNumberOfGridYChanged, CoerceNumberOfGridYValue));
        private static void OnNumberOfGridYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
        private static object CoerceNumberOfGridYValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        
        
        public double ScrollBarValue
        {
            get => (double)GetValue(ScrollBarValueProperty);
            set => SetValue(ScrollBarValueProperty, value);
        }
        public static readonly DependencyProperty ScrollBarValueProperty = DependencyProperty.Register(
        nameof(ScrollBarValue), typeof(double), typeof(MainChart),
        new PropertyMetadata(default(double), OnScrollBarValueChanged, CoerceScrollBarValueValue));
        private static void OnScrollBarValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
        private static object CoerceScrollBarValueValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        public MainChart()
        {
            InitializeComponent();
        }

        public double MaxValueX 
        {
            get => (double)GetValue(MaxValueXProperty);
            set => SetValue(MaxValueXProperty, value);
        }
        public static readonly DependencyProperty MaxValueXProperty = DependencyProperty.Register(
          nameof(MaxValueX), typeof(double), typeof(MainChart),
          new PropertyMetadata(default(double), OnMaxValueXChanged, CoerceMaxValueXValue));
        private static void OnMaxValueXChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
        private static object CoerceMaxValueXValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }

        private void Border_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                this.PointY_1 += 10;
                PointX += 10;
            }
            else if (e.Delta < 0)
            {
                this.PointY_1 -= 10;
                PointX -= 10;
            }
        }
    }
}
