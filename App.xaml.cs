/* Name: Seth McCrudden
 * Date: 9/16/2020
 * File: App.xaml.cs.cpp
 * Description: Creates a mainwindow, adds a textbox to it and then runs it
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Project
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /*
         * Description:
         *      Creates a app, mainwindow and a textbox. Then adds the textbox to the mainwindow and runs it.
         */
        [STAThread]
        public static void Main()
        {
            Project.App app = new Project.App();
            app.InitializeComponent();
            MainWindow mainWindow = new MainWindow();

            TextBlock HelloFromMain = new TextBlock();
            HelloFromMain.Text = "Hello from Main!";
            HelloFromMain.FontSize = 18;
            HelloFromMain.HorizontalAlignment = HorizontalAlignment.Center;
            HelloFromMain.SetValue(DockPanel.DockProperty, Dock.Top);
            mainWindow.HelloMainContainer.Children.Add(HelloFromMain);

            app.Run(mainWindow);
        }
    }
}
