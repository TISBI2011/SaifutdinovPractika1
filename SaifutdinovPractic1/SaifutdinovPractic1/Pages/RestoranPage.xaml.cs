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

namespace SaifutdinovPractic1.Pages
{
    /// <summary>
    /// Логика взаимодействия для RestoranPage.xaml
    /// </summary>
    public partial class RestoranPage : Page
    {
        public RestoranPage()
        {
            InitializeComponent();
            DGRestoran.ItemsSource = App.DB.Dish.ToList();
        }
    }
}
