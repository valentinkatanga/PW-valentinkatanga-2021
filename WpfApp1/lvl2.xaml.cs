﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for lvl2.xaml
    /// </summary>
    public partial class lvl2 : Window
    {
        public lvl2()
        {
            InitializeComponent();
        }

        private void btnShoot_Click(object sender, RoutedEventArgs e)
        {
            txtboxBewaker.Text = "U hebt de bewaker gedood, u bent vrij!";
            imgDwarden.Opacity = 1;
            imgWarden.Opacity = 0;
        }
    }
}
