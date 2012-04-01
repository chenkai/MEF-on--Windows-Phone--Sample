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

using MEFSampleDemo.ViewModels;
namespace MEFSampleDemo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        private AppCatalog_ViewModel appcatalog_ViewModel = null;
        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.appcatalog_ViewModel == null)
                this.appcatalog_ViewModel = new AppCatalog_ViewModel();
            this.appcatalog_ViewModel.LoadAppCatalogData();
            this.DataContext = appcatalog_ViewModel;
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/AddAppCatalog.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}