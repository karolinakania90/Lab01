﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxImie_LostFocus(object sender, RoutedEventArgs e)
        {
            LabelKomunikat1.Content = "Witaj, " + TextBoxImie.Text + " " + TextBoxNazwisko.Text;

        }

        private void TextBoxNazwisko_LostFocus(object sender, RoutedEventArgs e)
        {
            LabelKomunikat1.Content = "Witaj, " + TextBoxImie.Text + " " + TextBoxNazwisko.Text;
        }

        private void TextBoxWiek_LostFocus(object sender, RoutedEventArgs e)
        {
            int wiek = Convert.ToInt32(TextBoxWiek.Text);
            if(wiek < 67)
            {
                LabelKomunikat2.Content = string.Format("Do emerytury zostało Ci {0} lat", 67 - wiek);
            }
            else
            {
                LabelKomunikat2.Content = "jesteś emerytem";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LabelKomunikat1.Content = "";
        }
    }
}