﻿using System;
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
        public double Scale_X { get; set; }
        public static readonly DependencyProperty Scale_XProperty = DependencyProperty.Register(
            nameof(Scale_X), typeof(double), typeof(Chart_Line),
            new PropertyMetadata(default(double),OnScale_XChanged,CoerceScale_XValue));
        private static void OnScale_XChanged(DependencyObject d,DependencyPropertyChangedEventArgs e)
        {
            var _data = d as Chart_Line;
            ScaleTransform scaleTransform = new ScaleTransform();
            scaleTransform.ScaleX = _data.Scale_X;
            scaleTransform.ScaleY = _data.Scale_Y;
            _data.MainChartCanvas.LayoutTransform = scaleTransform;
        }
        private static object CoerceScale_XValue(DependencyObject d,object baseValue)
        {
            return baseValue;
        }

        public double Scale_Y { get; set; }
        public static readonly DependencyProperty Scale_YProperty = DependencyProperty.Register(
            nameof(Scale_Y), typeof(double), typeof(Chart_Line), 
            new PropertyMetadata(default(double),OnScale_YChanged,CoerceScale_YValue));
        private static void OnScale_YChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as Chart_Line;
            ScaleTransform scaleTransform = new ScaleTransform();
            scaleTransform.ScaleX = _data.Scale_X;
            scaleTransform.ScaleY = _data.Scale_Y;
            _data.MainChartCanvas.LayoutTransform = scaleTransform;
        }
        private static object CoerceScale_YValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }


        public int testInt { get; set; }
        public static readonly DependencyProperty testIntProperty = DependencyProperty.Register(
            nameof(testInt), typeof(int), typeof(Chart_Line), 
            new PropertyMetadata(default(int), OntestIntChanged, CoercetestIntValue));
        private static void OntestIntChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _data = d as Chart_Line;
            //_data.MainChartCanvas.LayoutTransform=new Transform(ScaleTransform )
            ScaleTransform scaleTransform = new ScaleTransform();
            _data.MainChartCanvas.LayoutTransform = scaleTransform;

        }
        private static object CoercetestIntValue(DependencyObject d, object baseValue)
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
            AddMainChart(_data, _data.ChartDatas);
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
            //GridBlock(_View, _View.NumberOfGridX, _View.NumberOfGridY);
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
            //GridBlock(_View, _View.NumberOfGridX, _View.NumberOfGridY);
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
            //GridBlock(_View, _View.NumberOfGridX, _View.NumberOfGridY);
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
            //GridBlock(_View, _View.NumberOfGridX, _View.NumberOfGridY);
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
            var _View = d as Chart_Line;
            GridBlock(_View, _View.NumberOfGridX, _View.NumberOfGridY);
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
            var _View = d as Chart_Line;
            GridBlock(_View, _View.NumberOfGridX, _View.NumberOfGridY);
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
            chart_Line.ViewGridBlock.Children.Clear();
            chart_Line.ViewGridBlock.RowDefinitions.Clear();
            chart_Line.ViewGridBlock.ColumnDefinitions.Clear();
            for (int i = 0; i < _NumberOfGridY + 1; i++)
            {
                var _rows = new RowDefinition();
                if (i == 0)
                    _rows.Height = new GridLength(50, GridUnitType.Pixel);
                else if (i == _NumberOfGridY)
                    _rows.Height = new GridLength(30, GridUnitType.Pixel);
                else
                    _rows.Height = new GridLength(1, GridUnitType.Star);
                chart_Line.ViewGridBlock.RowDefinitions.Add(_rows);
            }

            for (int i = 0; i < _NumberOfGridX + 2; i++)
            {
                var _column = new ColumnDefinition();
                if (i == 0)
                    _column.Width = new GridLength(70, GridUnitType.Pixel);
                else
                    _column.Width = new GridLength(1, GridUnitType.Star);
                chart_Line.ViewGridBlock.ColumnDefinitions.Add(_column);
            }
            for (int i = 0; i < _NumberOfGridX + 2; i++)
            {
                for (int j = 0; j < _NumberOfGridY; j++)
                {
                    var _border = new Border();
                    if (i == 0 && j == 0)
                        continue;
                    if (i == 0 && j != 0)
                        _border.BorderThickness = new Thickness(0, 0, 1, 0);
                    else if (j == 0 && i != 0)
                        _border.BorderThickness = new Thickness(0, 0, 0, 1);
                    else
                        _border.BorderThickness = new Thickness(0, 0, 1, 1);
                    _border.BorderBrush = new SolidColorBrush(Colors.Black);

                    var _TextBox = new TextBlock();
                    _TextBox.Text = string.Format("I={0},J={1}", i, j);
                    _TextBox.Foreground = new SolidColorBrush(Colors.Black);
                    _TextBox.HorizontalAlignment = HorizontalAlignment.Right;
                    _TextBox.VerticalAlignment = VerticalAlignment.Bottom;
                    _TextBox.FontSize = 12;
                    Grid.SetRow(_border, j);
                    Grid.SetColumn(_border, i);
                    Grid.SetRow(_TextBox, j);
                    Grid.SetColumn(_TextBox, i);
                    chart_Line.ViewGridBlock.Children.Add(_border);
                    //chart_Line.ViewGridBlock.Children.Add(_TextBox);
                }
            }
        }
        


        private static void AddMainChart(Chart_Line chart_Lines, List<double[]> _ChartDatas)
        {
            chart_Lines.MainChartCanvas.Children.Clear();
            var _data = new string[_ChartDatas[0].Length - 1];

            for (int i = 0; i < _ChartDatas.Count; i++)
            {
                for (int j = 0; j < _ChartDatas[i].Length-1; j++)
                {
                    if (i == 0)
                        _data[j] += string.Format("M {0},{1}", 0, _ChartDatas[i][j +1]);
                    else
                        _data[j] += string.Format(" {0},{1}", _ChartDatas[i][0], _ChartDatas[i][j +1]);
                }
            }
            for (int i = 0; i < _ChartDatas[0].Length - 1; i++)
            {
                var _path = new Path();
                _path.Data = Geometry.Parse(_data[i]);
                _path.Stroke=new SolidColorBrush(Colors.Black);
                //_path.Stretch = Stretch.Uniform;
                chart_Lines.MainChartCanvas.Children.Add(_path);
            }
            
        }
        private static void TextBlock()
        {

        }
    }
}
