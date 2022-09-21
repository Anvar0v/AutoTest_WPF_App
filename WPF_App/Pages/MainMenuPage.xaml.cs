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
using WPF_App.EPages;

namespace WPF_App.Pages
{
    /// <summary>
    /// Interaction logic for MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }
        
        private void TicketButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.MainWindowFrame.Navigate(new TicketPage());
        }

        private void ExaminationButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.DisplayPage(EPage.Examination);
        }

    }
}
