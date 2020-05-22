using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace SuaOferta2._0
{
    public partial class PageSetup : PhoneApplicationPage
    {
        public PageSetup()
        {
            InitializeComponent();
        }
        private void txbConfirmar_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var uri = new Uri("MainPage.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }

    }
}