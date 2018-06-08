using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRegionModule
{
    [ModuleExport(typeof(FirstRegionModuleMVVM))]
    public class FirstRegionModuleMVVM : IModule
    {
        [Import]
        public IRegionManager RegionManager { get; set; }
        public void Initialize()
        {
            //Set  region 
            RegionManager.RequestNavigate("FIRST", "FirstRegionModule.FirstUserControl");


        }
    }
}
