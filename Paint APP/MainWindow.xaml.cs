using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Paint_APP
{
    /// Jeremy Gordon
    /// PaintApp
    /// 2/3/2022
    /// Assignment for grade: provide functionality to change pen size, color and reset the pen
    /// back to original settings. Needed the ability to clear the canvas.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }//

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Canv.Strokes.Clear();
           
        }

        private void ColorGrn_Click(object sender, RoutedEventArgs e)
        {
            Canv.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void ColorBlu_Click(object sender, RoutedEventArgs e)
        {
            Canv.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void ColorRed_Click(object sender, RoutedEventArgs e)
        {
            Canv.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void ColorPurp_Click(object sender, RoutedEventArgs e)
        {
            Canv.DefaultDrawingAttributes.Color = Colors.Purple;
        }

        private void Thickness_Click(object sender, RoutedEventArgs e)
        {
            Canv.DefaultDrawingAttributes.Width = 10;
            Canv.DefaultDrawingAttributes.Height = 10;
        }

        private void thinPen_Click(object sender, RoutedEventArgs e)
        {
            Canv.DefaultDrawingAttributes.Width = 1;
            Canv.DefaultDrawingAttributes.Height = 1;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Canv.DefaultDrawingAttributes.Color = Colors.Black;
            Canv.DefaultDrawingAttributes.Width = 2;
            Canv.DefaultDrawingAttributes.Height = 2;
        }
    }  
}
