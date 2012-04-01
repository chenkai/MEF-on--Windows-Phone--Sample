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

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

using MEFCommon.Data;

namespace MEFSampleDemo.ViewModels
{
    public class AppCatalog_ViewModel:BasicViewModel
    {
        public AppCatalog_ViewModel()
        {
            CompositionInitializer.SatisfyImports(this);

            //AggregateCatalog mefCatalog = new AggregateCatalog();
            //mefCatalog.Catalogs.Add(new AssemblyCatalog(Application.Current.GetType().Assembly));
            //mefCatalog.Catalogs.Add(new AssemblyCatalog(typeof(MEFCommon.Data.IAppCatalog).Assembly));

            //CompositionContainer mefContainer = new CompositionContainer(mefCatalog);
            //mefContainer.ComposeParts(this);
        }

        public ObservableCollection<AppCatalog> appCatalogCollection = new ObservableCollection<AppCatalog>();
        public ObservableCollection<AppCatalog> AppCatalogCollection
        {
            get { return this.appCatalogCollection; }
            set
            {
                this.appCatalogCollection = value;
                base.NotifyPropertyChangedEventHandler("AppCatalogCollection");
            }
        }

        [Import(typeof(IAppCatalog))]
        public IAppCatalog CurrentCatalogData { get; set; }

        public void LoadAppCatalogData()
        {
            if (this.CurrentCatalogData != null)
            {
                if (this.CurrentCatalogData.GetAllAppCatalogList().Count > 0)
                {
                    var catalogList = this.CurrentCatalogData.GetAllAppCatalogList();
                    this.appCatalogCollection.Clear();
                    catalogList.ForEach(x => { this.appCatalogCollection.Add(x); });
                }
            }
        }
    }
}
