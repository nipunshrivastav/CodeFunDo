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
    public partial class PlaceBet : PhoneApplicationPage
    {
        public PlaceBet()
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

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.BetPlaced = 1;
            NavigationService.Navigate(new Uri("/PC.xaml", UriKind.Relative));
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.BetPlaced = 1;
            NavigationService.Navigate(new Uri("/PC.xaml", UriKind.Relative));
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            int a = 550-Convert.ToInt32(tb4.Text);
            tb5.Text = "Coins left: " + a.ToString();
        }
    }
}