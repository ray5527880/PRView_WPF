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
    /// testUserCon.xaml 的互動邏輯
    /// </summary>
    public partial class testUserCon : UserControl
    {
        PolyLineSegment[] vs;
        public testUserCon()
        {
            InitializeComponent();
            vs = new PolyLineSegment[4];
            //Panel panel = new Panel();

            //bitmapImage.
            //this.testCanvas.zomm
            for (int j = 0; j < 4; j++)
            {
                vs[j] = new PolyLineSegment();
                for (int i = 0; i < 19200; i++)
                {
                    vs[j].Points.Add(new Point(i, (Math.Sin(Math.PI * i / 180 * (j + 1)) * 100) + 200));
                }
                //vs[j].Stroke = b;
                //this.testCanvas.sc
                //if (j != 0)
                //    this.testCanvas.Children.Add(vs[j]);
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var b = new SolidColorBrush();
            b.Color = Colors.Yellow;

            var p = new Pen();
            p.Brush = b;

            LineGeometry lineGeometry = new LineGeometry();
            DrawingGroup drawingGroup = new DrawingGroup();

            PathSegmentCollection pathSegments = new PathSegmentCollection();

            pathSegments.Add(vs[0]);
            pathSegments.Add(vs[1]);
            pathSegments.Add(vs[2]);
            pathSegments.Add(vs[3]);

            PathFigure pathFigure = new PathFigure();
            pathFigure.Segments = pathSegments;
            PathFigureCollection pathFigures = new PathFigureCollection();
            pathFigures.Add(pathFigure);
            PathGeometry pthGeometry = new PathGeometry();
            pthGeometry.Figures = pathFigures;

            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Pen = p;
            geometryDrawing.Geometry = pthGeometry;

            DrawingImage drawingImage = new DrawingImage(geometryDrawing);
          
            GeometryGroup ellipses = new GeometryGroup();
            ellipses.Children.Add(new EllipseGeometry(new Point(50, 50), 45, 20));
            ellipses.Children.Add(new EllipseGeometry(new Point(50, 50), 20, 45));

            GeometryDrawing aGeometryDrawing = new GeometryDrawing();
            aGeometryDrawing.Geometry = ellipses;

            // Paint the drawing with a gradient.
            aGeometryDrawing.Brush =
                new LinearGradientBrush(
                    Colors.Blue,
                    Color.FromRgb(204, 204, 255),
                    new Point(0, 0),
                    new Point(1, 1));


            aGeometryDrawing.Pen = new Pen(Brushes.Black, 10);

            //
            // Use a DrawingImage and an Image control
            // to display the drawing.
            //
            DrawingImage geometryImage = new DrawingImage(aGeometryDrawing);

            // Freeze the DrawingImage for performance benefits.
            geometryImage.Freeze();

            Image anImage = new Image();
            anImage.Source = geometryImage;
            anImage.HorizontalAlignment = HorizontalAlignment.Left;

            //
            // Place the image inside a border and
            // add it to the page.
            //
            Border exampleBorder = new Border();
            exampleBorder.Child = anImage;
            exampleBorder.BorderBrush = Brushes.Red;
            exampleBorder.BorderThickness = new Thickness(1);
            exampleBorder.HorizontalAlignment = HorizontalAlignment.Left;
            exampleBorder.VerticalAlignment = VerticalAlignment.Top;
            exampleBorder.Margin = new Thickness(10);

            //this.Margin = new Thickness(20);
            //this.Background = Brushes.White;
            //this.Content = exampleBorder;
            //ad.Background=b
            //ad = exampleBorder;

            //this.image.Source = anImage.Source;
            //this.testimage.Source = drawingImage;

            //asd = anImage;

            var _path = new Path();
            //_path.Data
            


            //this.canvas.Children)

        }
        public void testReMoveLine(int index)
        {

        }

    }
}
