// TODO: this with MVVM
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
using System.Windows.Shapes;
using Game.WPF.ViewModels;

namespace Game.WPF.Views
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void Click_start(object sender, RoutedEventArgs e)
        {
            GameViewModel gameViewModel = new();
            MainWindow window = new();
            window.DataContext = gameViewModel;
            window.Show();
            //Close();
        }
    }
}
