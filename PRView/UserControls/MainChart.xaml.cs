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
        //public double UserControlWidth
        //{
        //    get => (double)GetValue(UserControlWidthProperty);
        //    set => SetValue(UserControlWidthProperty, value);
        //}
        //public static readonly DependencyProperty UserControlWidthProperty = DependencyProperty.Register(
        //    nameof(UserControlWidth), typeof(double), typeof(Chart_Line), new PropertyMetadata());

        //public double UserControlHeight
        //{
        //    get => (double)GetValue(userControlHeight);
        //    set => SetValue(userControlHeight, value);
        //}
        //public static readonly DependencyProperty userControlHeight = DependencyProperty.Register(
        //    nameof(UserControlHeight), typeof(double), typeof(Chart_Line), new PropertyMetadata());

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
            _data.Canvas_1.Visibility = _data.Canvas1_Enable ? Visibility.Visible : Visibility.Collapsed;
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
            _data.Canvas_2.Visibility = _data.Canvas2_Enable ? Visibility.Visible : Visibility.Collapsed;
        }
        private static object CoerceCanvas2_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Canvas3_Enable
        public bool Canvas3_Enable
        {
            get => (bool)GetValue(Canvase3_EnableProperty);
            set => SetValue(Canvase3_EnableProperty, value);
        }
        public static readonly DependencyProperty Canvase3_EnableProperty = DependencyProperty.Register(
            nameof(Canvas3_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnCanvas3_EnableChanged, CoerceCanvas3_EnableValue));
        private static void OnCanvas3_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_3.Visibility = _data.Canvas3_Enable ? Visibility.Visible : Visibility.Collapsed;
        }
        private static object CoerceCanvas3_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Canvas4_Enable
        public bool Canvas4_Enable
        {
            get => (bool)GetValue(Canvase4_EnableProperty);
            set => SetValue(Canvase4_EnableProperty, value);
        }
        public static readonly DependencyProperty Canvase4_EnableProperty = DependencyProperty.Register(
            nameof(Canvas4_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnCanvas4_EnableChanged, CoerceCanvas4_EnableValue));
        private static void OnCanvas4_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_4.Visibility = _data.Canvas4_Enable ? Visibility.Visible : Visibility.Collapsed;
        }
        private static object CoerceCanvas4_EnableValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        #endregion

        #region Canvas5_Enable
        public bool Canvas5_Enable
        {
            get => (bool)GetValue(Canvase5_EnableProperty);
            set => SetValue(Canvase5_EnableProperty, value);
        }
        public static readonly DependencyProperty Canvase5_EnableProperty = DependencyProperty.Register(
            nameof(Canvas5_Enable), typeof(bool), typeof(MainChart),
            new PropertyMetadata(default(bool), OnCanvas5_EnableChanged, CoerceCanvas5_EnableValue));
        private static void OnCanvas5_EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as MainChart;
            _data.Canvas_5.Visibility = _data.Canvas5_Enable ? Visibility.Visible : Visibility.Collapsed;
        }
        private static object CoerceCanvas5_EnableValue(DependencyObject d, object baseValue)
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
            Canvas1_Enable = true;
           
            //Canvas2_Enable = false;
            //var _path = new Path();
            //var str = string.Format("M 0,0");
            //for (int i = 0; i < 19200; i++)
            //{
            //    if (i == 0) str = string.Format("M 0,100");
            //    else str += string.Format(" {0},{1}", i, Math.Round(Math.Sin(Math.PI * i / 180 * 100)) + 100);
            //}
            //_path.Data = Geometry.Parse(str);

            //// Create a SolidColorBrush and use it to
            //// paint the rectangle.
            //SolidColorBrush myBrush = new SolidColorBrush(Colors.Red);

            //_path.Stroke = myBrush;
            //Canvas_2.Children.Add(_path);
            ////Canvas_2.Background = Color.FromArgb(100, 0, 0, 0);

        }


    }
}
