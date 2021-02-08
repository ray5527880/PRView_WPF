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

        public int testInt { get; set; }
        public static readonly DependencyProperty testIntProperty = DependencyProperty.Register(
            nameof(testInt), typeof(int), typeof(MainChart), new PropertyMetadata());

        //public double ChartWidth { get; set; }
        //public double ChartHeight { get; set; }
        private double scale_X { get; set; }

       

        private double scale_Y { get; set; }


        //private static void WidthChanged(MainChart mainChart)
        //{
        //    mainChart.ChartWidth = mainChart.MainChartWidth-120;
        //}
        //private static void HeightChanged(MainChart mainChart)
        //{
        //    var _height = mainChart.MainChartHeight - 120;
        //    if (mainChart.Canvas5_Enable)
        //        _height -= 120;
        //    int EnableCount = 0;
        //    if (mainChart.Canvas1_Enable)
        //        EnableCount++;
        //    if (mainChart.Canvas2_Enable)
        //        EnableCount++;
        //    if (mainChart.Canvas3_Enable)
        //        EnableCount++;
        //    if (mainChart.Canvas4_Enable)
        //        EnableCount++;
            
        //    mainChart.ChartHeight = _height;
        //}

        #region MainChartWidthAndHeight
        public double MainChartWidth
        {
            get => (double)GetValue(MainChartWidthProperty);
            set => SetValue(MainChartWidthProperty, value);
        }
        public static readonly DependencyProperty MainChartWidthProperty = DependencyProperty.Register(
            nameof(MainChartWidth), typeof(double), typeof(MainChart),
            new PropertyMetadata(default(double), OnMainChartWidthChanged, CoerceMainChartWidthValue));
        private static void OnMainChartWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            //WidthChanged(_data);
        }
        private static object CoerceMainChartWidthValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }


        public double MainChartHeight
        {
            get => (double)GetValue(MainChartHeightProperty);
            set => SetValue(MainChartHeightProperty, value);
        }
        public static readonly DependencyProperty MainChartHeightProperty = DependencyProperty.Register(
            nameof(MainChartHeight), typeof(double), typeof(MainChart), 
            new PropertyMetadata(default(double), OnMainChartHeightChanged, CoerceMainChartHeightValue));
        private static void OnMainChartHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            
            //HeightChanged(_data);
        }
        private static object CoerceMainChartHeightValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion
      
        #region Canvas1_Enable
        public bool Canvas1_Enable
        {
            get => (bool)GetValue(Canvas1_EnableProperty);
            set => SetValue(Canvas1_EnableProperty, value);
        }
        public static readonly DependencyProperty Canvas1_EnableProperty = DependencyProperty.Register(
            nameof(Canvas1_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnCanvas1_EnableChanged, CoerceCanvas1_EnableValue));
        private static void OnCanvas1_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_1.Height = _data.Canvas1_Enable ? new GridLength(1, GridUnitType.Star) : new GridLength(0, GridUnitType.Pixel); 
        }
        private static object CoerceCanvas1_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Canvas2_Enable
        public bool Canvas2_Enable
        {
            get => (bool)GetValue(Canvas2_EnableProperty);
            set => SetValue(Canvas2_EnableProperty, value);
        }
        public static readonly DependencyProperty Canvas2_EnableProperty = DependencyProperty.Register(
            nameof(Canvas2_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnCanvas2_EnableChanged, CoerceCanvas2_EnableValue));
        private static void OnCanvas2_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_2.Height = _data.Canvas2_Enable ? new GridLength(1, GridUnitType.Star) : new GridLength(0, GridUnitType.Pixel);
        }
        private static object CoerceCanvas2_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Canvas3_Enable
        public bool Canvas3_Enable
        {
            get => (bool)GetValue(Canvas3_EnableProperty);
            set => SetValue(Canvas3_EnableProperty, value);
        }
        public static readonly DependencyProperty Canvas3_EnableProperty = DependencyProperty.Register(
            nameof(Canvas3_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnCanvas3_EnableChanged, CoerceCanvas3_EnableValue));
        private static void OnCanvas3_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_3.Height = _data.Canvas3_Enable ? new GridLength(1, GridUnitType.Star) : new GridLength(0, GridUnitType.Pixel);
        }
        private static object CoerceCanvas3_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Canvas4_Enable
        public bool Canvas4_Enable
        {
            get => (bool)GetValue(Canvas4_EnableProperty);
            set => SetValue(Canvas4_EnableProperty, value);
        }
        public static readonly DependencyProperty Canvas4_EnableProperty = DependencyProperty.Register(
            nameof(Canvas4_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnCanvas4_EnableChanged, CoerceCanvas4_EnableValue));
        private static void OnCanvas4_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_4.Height = _data.Canvas4_Enable ? new GridLength(1, GridUnitType.Star) : new GridLength(0, GridUnitType.Pixel);
        }
        private static object CoerceCanvas4_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Canvas5_Enable
        public bool Canvas5_Enable
        {
            get => (bool)GetValue(Canvas5_EnableProperty);
            set => SetValue(Canvas5_EnableProperty, value);
        }
        public static readonly DependencyProperty Canvas5_EnableProperty = DependencyProperty.Register(
            nameof(Canvas5_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnCanvas5_EnableChanged, CoerceCanvas5_EnableValue));
        private static void OnCanvas5_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_5.Height = _data.Canvas5_Enable ? new GridLength(120, GridUnitType.Pixel) : new GridLength(0, GridUnitType.Pixel);
        }
        private static object CoerceCanvas5_EnableValue(DependencyObject d, object baseValue)
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


        public MainChart()
        {
            InitializeComponent();           
        }

    }
}
