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

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string FirstArg
        {
            get;set;
        }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            var args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
                FirstArg = args[1];
            else
                FirstArg = args[0];
        }
    }
}
