﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kreta1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fooldal.Width = Width / 5 - 5;
            orarend.Width = Width / 5 - 5;
            ertesitesek.Width = Width / 5 - 5;
            mulasztas.Width = Width / 5 - 5;
            egyeb.Width = Width / 5 - 5;
        }
    }
}