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

namespace pr
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button_sphere_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Sphere());
        }

        private void button_cone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cone());
        }

        private void button_cylinder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cylinder());
        }

        private void button_truncated_cone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TruncatedCone());
        }
    }
}
