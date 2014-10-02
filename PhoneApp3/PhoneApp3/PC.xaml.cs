using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp3
{
    public partial class PC : PhoneApplicationPage
    {
        public PC()
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
            DataContext = App.ViewModel;
            if (App.BetPlaced == 1)
            {
                PlaceBet.Visibility = System.Windows.Visibility.Collapsed;
                TextBlock tb1 = new TextBlock();
                tb1.Text = "Your bet has been placed.";
                tb1.FontSize = 20;
                tb1.Width = 350;
                tb1.Height = 25;
                tb1.HorizontalAlignment = HorizontalAlignment.Left;
                tb1.VerticalAlignment = VerticalAlignment.Top;
                tb1.Margin = new Thickness(0, 109, 0, 282);
                Grid1.Children.Add(tb1);
                tb1.Visibility = System.Windows.Visibility.Visible;

                Button tb2 = new Button();
                tb2.Content = "Edit Bet";
                tb2.FontSize = 20;
                tb2.Width = 150;
                tb2.Height = 80;
                tb2.HorizontalAlignment = HorizontalAlignment.Left;
                tb2.VerticalAlignment = VerticalAlignment.Top;
                tb2.Margin = new Thickness(0,132,0,0);
                Grid1.Children.Add(tb2);
                tb2.Visibility = System.Windows.Visibility.Visible;
            }
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void LongListSelector_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Panorama_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PlaceBet.xaml", UriKind.Relative));
        }
    }
}