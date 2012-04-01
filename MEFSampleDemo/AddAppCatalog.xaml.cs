using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

using MEFCommon.Data;

namespace MEFSampleDemo
{
    public partial class AddAppCatalog : PhoneApplicationPage
    {
        public AddAppCatalog()
        {
            InitializeComponent();
            CompositionInitializer.SatisfyImports(this);
        }

        [Import(typeof(IAppCatalog))]
        public IAppCatalog currentAppCatalog { get; set; }

        private void AddCatalog_AI_Click(object sender, EventArgs e)
        {
            if (currentAppCatalog != null)
            {
                AppCatalog newCatalog = new AppCatalog() 
                {
                    CatalogName=this.CatalogName_TB.Text.Trim(),
                    CatalogNote=this.CatalogNote_TB.Text.Trim()
                };
                currentAppCatalog.AddCatalog(newCatalog);
                if (this.NavigationService.CanGoBack)
                    this.NavigationService.GoBack();     
            }
        }

        private void CancelOperator_AI_Click(object sender, EventArgs e)
        {
            if (this.NavigationService.CanGoBack)
                this.NavigationService.GoBack();           
        }
    }
}