using System;
using System.Windows;

namespace ChessBoardWithCircle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MoveCircle_Click(object sender, RoutedEventArgs e)
        {
            double imageWidth = ChessBoardImage.ActualWidth;
            double imageHeight = ChessBoardImage.ActualHeight;

            double circleWidth = circle.Width;
            double circleHeight = circle.Height;

            if (double.TryParse(txtX.Text, out double x) && double.TryParse(txtY.Text, out double y))
            {
                double cellWidth = imageWidth / 8;
                double cellHeight = imageHeight / 8;

                int column = (int)(x / cellWidth);
                int row = (int)(y / cellHeight);

                double centerX = (column + 0.5) * cellWidth - circleWidth / 2;
                double centerY = (row + 0.5) * cellHeight - circleHeight / 2;

                double minX = 0;
                double minY = 0;
                double maxX = imageWidth - circleWidth;
                double maxY = imageHeight - circleHeight;

                centerX = Math.Max(minX, Math.Min(centerX, maxX));
                centerY = Math.Max(minY, Math.Min(centerY, maxY));

                circle.Margin = new Thickness(centerX, centerY, 0, 0);
            }
        }


    }
}
