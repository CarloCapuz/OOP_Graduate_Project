using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Final_Grad_OOP_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Feature");
            VideoView.Navigate(u);
        }

        // HAMBURGER BUTTON
        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/Main/Index");
            VideoView.Navigate(u);
        }

        // TEXT CHANGED ON SEARCH BOX
        private void SearchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            goBack();
        }

        // AUTO SUGGESTION SEARCH BOX
        private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {

        }

        // BACK BUTTON
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Feature");
            VideoView.Navigate(u);
        }

        // BDO CLASSES
        private void Archer_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=29");
            VideoView.Navigate(u);
        }
        private void Berserker_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=12");
            VideoView.Navigate(u);
        }

        private void DK_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=27");
            VideoView.Navigate(u);
        }

        private void Guardian_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=5");
            VideoView.Navigate(u);
        }

        private void Hashashin_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=1");
            VideoView.Navigate(u);
        }

        private void Kunoichi_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=25");
            VideoView.Navigate(u);
        }
        private void Lahn_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=11");
            VideoView.Navigate(u);
        }
        private void Maehwa_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=21");
            VideoView.Navigate(u);
        }
        private void Musa_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=20");
            VideoView.Navigate(u);
        }
        private void Mystic_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=23");
            VideoView.Navigate(u);
        }
        private void Ninja_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=26");
            VideoView.Navigate(u);
        }
        private void Nova_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=9");
            VideoView.Navigate(u);
        }
        private void Ranger_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=4");
            VideoView.Navigate(u);
        }
        private void Shai_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=17");
            VideoView.Navigate(u);
        }
        private void Sorceress_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=8");
            VideoView.Navigate(u);
        }
        private void Striker_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=19");
            VideoView.Navigate(u);
        }
        private void Tamer_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=16");
            VideoView.Navigate(u);
        }
        private void Valkyrie_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=24");
            VideoView.Navigate(u);
        }
        private void Warrior_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=0");
            VideoView.Navigate(u);
        }
        private void Witch_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=31");
            VideoView.Navigate(u);
        }
        private void Wizard_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=28");
            VideoView.Navigate(u);
        }
        private void Sage_btn_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.naeu.playblackdesert.com/en-US/GameInfo/Class?classType=2");
            VideoView.Navigate(u);
        }
    }
}
