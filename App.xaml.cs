using Game.WPF.Views;
using Game.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows;

namespace Game.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // TODO: private fields: views, viewmodels timers etc.

        private StartWindow _view = null!;

        public App()
        {
            Startup += new StartupEventHandler(App_Startup);
        }

        private void App_Startup(object? sender, StartupEventArgs e)
        {
            _view = new StartWindow();
            //_view.DataContext = _viewModel; // TODO
            //_view.Closing += new CancelEventHandler(View_Closing); // eseménykezelés a bezáráshoz
            _view.Show();
        }

        // View closing event handler
        private void View_Closing(object? sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        // Timer tick event handler
        private void Timer_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        // TODO: View Model Event Handlers
    }
}
