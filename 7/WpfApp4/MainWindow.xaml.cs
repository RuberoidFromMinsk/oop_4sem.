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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void UserControl2_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl2_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }


    //5
    public class WindowCommands
    {
        static WindowCommands()
        {
            Exit = new RoutedUICommand("Exit","Exit", typeof(MainWindow));
        }
        public static RoutedUICommand Exit;
    }
}