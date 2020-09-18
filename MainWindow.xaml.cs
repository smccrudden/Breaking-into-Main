/* Name: Seth McCrudden
 * Date: 9/16/2020
 * File: MainWindow.xaml.cs
 * Description: Creates an inkcanvas and handles all user interactions with
 * it including: changing pen color, pen thickness and clearing the canvas
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
         * Description:
         *      The constructer sets the default values for pen thickness and pen color
         */
        public MainWindow()
        {
            InitializeComponent();

            DrawingCanvas.DefaultDrawingAttributes.Width = DrawingCanvas.DefaultDrawingAttributes.Height = 1;
            DrawingCanvas.DefaultDrawingAttributes.Color = Colors.Black;
        }

        /*
         * Description:
         *      An event handler which will be called then the user tries to change the pen size
         */
        private void SetPenSize(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (DrawingCanvas != null)
            {
                DrawingCanvas.DefaultDrawingAttributes.Width = penSize.Value;
                DrawingCanvas.DefaultDrawingAttributes.Height = penSize.Value;
            }
        }

        /*
         * Description:
         *      An event handler which will be called then the user tries to change the pen color
         */
        private void ChangePenColor(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (DrawingCanvas != null)
            {
                Color selectedColor = Color.FromRgb((byte)penColorR.Value, (byte)penColorG.Value, (byte)penColorB.Value);
                DrawingCanvas.DefaultDrawingAttributes.Color = selectedColor;
                ColorPreview.Background = new SolidColorBrush(selectedColor);
            }
        }

        /*
         * Description:
         *      An event handler which will be called then the user tries to clear the canvas
         */
        private void ResetCanvas(object sender, RoutedEventArgs e)
        {
            DrawingCanvas.Strokes.Clear();
        }

        /*
         * Description:
         *      An event handler which will be called then the user tries to reset the pen size
         *      back to the default. The function modifies the slider value for pensize and lets
         *      the event handler handle the actual thickness change
         */
        private void ResetThickness(object sender, RoutedEventArgs e)
        {
            penSize.Value = 1;
        }

        /*
         * Description:
         *      An event handler which will be called then the user tries to reset the pen color
         *      back to the default. The function modifies the slider value for penColorR, penColorG,
         *      penColorB and lets the event handler handle the actual color change
         */
        private void ResetColors(object sender, RoutedEventArgs e)
        {
            penColorR.Value = penColorG.Value = penColorB.Value = 0;
        }
    }
}
