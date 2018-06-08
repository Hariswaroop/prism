using Prism.Mef;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace prism6_new
{
    public class ApplicationBootStrapper:MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();

        }

        protected override void ConfigureAggregateCatalog()
        {
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Shell).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(FirstRegionModule.FirstRegionModuleMVVM).Assembly));
        }
    }
}
