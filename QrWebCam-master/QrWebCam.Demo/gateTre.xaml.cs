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
using System.Windows.Shapes;

namespace QrWebCam.Demo
{
    /// <summary>
    /// Logica di interazione per gateTre.xaml
    /// </summary>
    public partial class gateTre : Window
    {
        public gateTre()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Hide();
        }
    }
}
