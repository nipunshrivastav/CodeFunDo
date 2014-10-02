using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp3.Resources;

namespace PhoneApp3
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            NavigationInTransition navigateInTransition = new NavigationInTransition();
            navigateInTransition.Backward = new SlideTransition { Mode = SlideTransitionMode.SlideLeftFadeIn };
            navigateInTransition.Forward = new SlideTransition { Mode = SlideTransitionMode.SlideRightFadeIn };

            NavigationOutTransition navigateOutTransition = new NavigationOutTransition();
            navigateOutTransition.Backward = new SlideTransition { Mode = SlideTransitionMode.SlideLeftFadeOut };
            navigateOutTransition.Forward = new SlideTransition { Mode = SlideTransitionMode.SlideRightFadeOut };
            TransitionService.SetNavigationInTransition(this, navigateInTransition);
            TransitionService.SetNavigationOutTransition(this, navigateOutTransition);
            
            if (App.LoggedIn == 1)
            {
                Button1.Visibility = System.Windows.Visibility.Collapsed;
                Button2.Visibility = System.Windows.Visibility.Collapsed;
                Button back = new Button();
                back.Content = "Logout";
                back.Width = 140;
                back.Height = 80;
            
                back.HorizontalAlignment = HorizontalAlignment.Right;
                back.VerticalAlignment = VerticalAlignment.Top;
                back.Margin = new Thickness(0, 60, 20, 0);
                ContentPanel.Children.Add(back);
                back.Click += new RoutedEventHandler(back_Click);
                back.Visibility = System.Windows.Visibility.Visible;

                TextBlock tb1 = new TextBlock();
                tb1.Text = "Hi, Amit !";
                tb1.FontSize = 40;
                tb1.Width = 200;
                tb1.Height = 80;
                tb1.HorizontalAlignment = HorizontalAlignment.Left;
                tb1.VerticalAlignment = VerticalAlignment.Top;
                tb1.Margin = new Thickness(30, 70, 0, 0);
                ContentPanel.Children.Add(tb1);
                tb1.Visibility = System.Windows.Visibility.Visible;

                TextBlock tb2 = new TextBlock();
                tb2.Text = "Coins: 550";
                tb2.FontSize = 40;
                tb2.Width = 200;
                tb2.Height = 80;
                tb2.HorizontalAlignment = HorizontalAlignment.Left;
                tb2.VerticalAlignment = VerticalAlignment.Top;
                tb2.Margin = new Thickness(30, 130, 0, 0);
                ContentPanel.Children.Add(tb2);
                tb2.Visibility = System.Windows.Visibility.Visible;

            }
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedIn = 0;
            NavigationService.Navigate(new Uri("/MainPage.xaml?Refresh=true", UriKind.Relative));
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.Relative));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LeaderBoard.xaml", UriKind.Relative));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Options.xaml", UriKind.Relative));
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HowTo.xaml", UriKind.Relative));
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