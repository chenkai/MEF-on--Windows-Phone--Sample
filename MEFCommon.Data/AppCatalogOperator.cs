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
using System.Collections.Generic;

using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MEFCommon.Data
{
    [Export(typeof(IAppCatalog))]
    public class AppCatalogOperator:IAppCatalog
    {
        public List<AppCatalog> OperatorCatalogList = new List<AppCatalog>();

        public bool AddCatalog(AppCatalog newAppCatalog)
        {
            //No Check Reply
            if(newAppCatalog!=null)
               this.OperatorCatalogList.Add(newAppCatalog);
            return true;
        }

        public List<AppCatalog> GetAllAppCatalogList()
        {
            this.OperatorCatalogList.Clear();
            this.OperatorCatalogList.Add(new AppCatalog() { CatalogName = "Music+Video", CatalogNote = "Important for Common User" });
            this.OperatorCatalogList.Add(new AppCatalog() { CatalogName = "Game", CatalogNote = "Different Kind of Game platform" });
            this.OperatorCatalogList.Add(new AppCatalog() { CatalogName = "Book", CatalogNote = "Reader" });

            return this.OperatorCatalogList;

        }
    }

    public class AppCatalog
    {
        public string CatalogName { get; set; }
        public string CatalogNote { get; set; }
    }
}
