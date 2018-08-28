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

namespace MVVMDemo
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MVVMDemo.ViewModel.StudentViewModel();
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.StudentViewModel studentViewModelObject = new ViewModel.StudentViewModel();
            // studentViewModelObject.LoadStudents(); // Cet appel n'est pas nécessaire si la méthode est comprise dans le constructeur de la classe

            StudentViewControl.DataContext = studentViewModelObject;
        }
    }
}