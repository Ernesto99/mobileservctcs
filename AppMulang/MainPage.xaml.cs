using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AppMulang.Resources;
using AppMulang.Models;

namespace AppMulang
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
           
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        public void login()
        {
           // App.mobileservice.LoginAsync(Microsoft.WindowsAzure.MobileServices.MobileServiceAuthenticationProvider.Google);
          
        }

        //
        public async void AddMulang()
        {
            Person p = new Person() { Age = 16, Name = "Sub. Mulang", Description = "This is a very grummy lecturer" };

            await App.mobileservice.GetTable<Person>().InsertAsync(p);

        }

        private void btnmulang_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("We are almost adding mulang in the database","Subordinate Lecturer", MessageBoxButton.OK);
            AddMulang();
        }


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}