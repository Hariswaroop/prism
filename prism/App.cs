using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace prism6_new
{
    class App:Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //Bootstrapper loading
            ApplicationBootStrapper _bootstrapper = new ApplicationBootStrapper();
            _bootstrapper.Run();
        }

        [STAThread]
        static void Main()
        {
            App obj = new App();
            obj.Run();
        }
    }
}
