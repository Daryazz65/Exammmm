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
    /// Логика взаимодействия для _4_edit_item.xaml
    /// </summary>
    public partial class _4_edit_item : Window
    {
        public _4_edit_item(Models.Event ev)
        {
            InitializeComponent();
            DataContext = ev;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();
            DialogResult = true;
        }
    }
}
