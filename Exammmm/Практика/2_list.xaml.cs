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

namespace Exammmm.Практика
{
    /// <summary>
    /// Логика взаимодействия для _2_list.xaml
    /// </summary>
    public partial class _2_list : Page
    {
        public _2_list()
        {
            InitializeComponent();
            //это для страничной навигации.


            //EventsLv.ItemsSource = App.context.Event.ToList();
        }

        private void EditItemBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
