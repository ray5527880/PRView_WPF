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


        public MainChart()
        {
            InitializeComponent();
        }
    }
}
