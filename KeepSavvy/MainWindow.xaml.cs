using System;
using System.Windows;
using System.Windows.Input;

namespace KeepSavvy
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void ExitApp(object sender, MouseButtonEventArgs e)
        {
                Application.Current.Shutdown();
        }
    }
}
