using Exammmm.Models;
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
    /// Логика взаимодействия для _4.xaml
    /// </summary>
    public partial class _4 : Window
    {
        public _4()
        {
            InitializeComponent();
        }

        private void EditItemBtn_Click(object sender, RoutedEventArgs e)
        {
            _4_edit_item editWindow = new _4_edit_item
                (EventsLv.SelectedItem as Event);

            editWindow.Show();
        }
    }
}
