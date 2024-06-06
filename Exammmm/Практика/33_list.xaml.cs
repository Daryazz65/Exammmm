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
    /// Логика взаимодействия для _33_list.xaml
    /// </summary>
    public partial class _33_list : Window
    {
        public _33_list()
        {
            InitializeComponent();

            EventsLv.ItemsSource = App.context.Event.ToList();
        }
    }
}
