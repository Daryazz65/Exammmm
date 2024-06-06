using System;
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

namespace Exammmm.Практика
{
    /// <summary>
    /// Логика взаимодействия для _2.xaml
    /// </summary>
    public partial class _2 : Window
    {
        public _2()
        {
            InitializeComponent();
            //Это для страничной навигации!!!
            //MainFrame.Navigate(new _2_list());

            //А это для оконной навигации.

        }

        private void OpenListBtn_Click(object sender, RoutedEventArgs e)
        {
            //Это для страничной навигации!!!
            //MainFrame.Navigate(new _2_list());

            //А это для оконной навигации.
            _33_list list = new _33_list();
            list.Show();
        }

        private void AddItemBtn_Click(object sender, RoutedEventArgs e)
        {
            //Это для страничной навигации!!!
            //MainFrame.Navigate(new _3_add_item());

            //А это для оконной навигации.
            _33_add_item addItem = new _33_add_item();
            addItem.Show();

        }
    }
}
