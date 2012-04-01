using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

using MEFSampleDemo.ViewModels;
namespace MEFSampleDemo.Services
{
    public class MEFAppCatalogService:IApplicationService
    {
        public MEFAppCatalogService()
        {
            CompositionHost.Initialize
                (new AssemblyCatalog(Application.Current.GetType().Assembly),
                 new AssemblyCatalog(typeof(MEFCommon.Data.IAppCatalog).Assembly));
        }

        public void StartService(ApplicationServiceContext context) {   }

        public void StopService() {  }
    }
}
