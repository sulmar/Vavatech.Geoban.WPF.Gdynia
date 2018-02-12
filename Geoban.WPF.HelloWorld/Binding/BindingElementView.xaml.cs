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

namespace Geoban.WPF.HelloWorld.Binding
{
    /// <summary>
    /// Interaction logic for BindingElementView.xaml
    /// </summary>
    public partial class BindingElementView : Window
    {
        public BindingElementView()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            button1.Width = slider1.Value;
        }
    }
}
