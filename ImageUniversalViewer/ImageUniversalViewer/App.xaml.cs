using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ImageUniversalViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var splash = new SplashWindow();
            splash.Show();

            Thread t = new Thread(new ThreadStart( delegate {

                Dispatcher.Invoke(new Action(delegate { splash.Status = "Start! .."; }));
                
                Thread.Sleep(1000);

                Dispatcher.Invoke(new Action(delegate { 
                    var main = new MainWindow();
                    splash.Close();
                    main.Show();
                }));
            }));

            t.Start();
        }
    }
}
