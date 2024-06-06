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
    /// Логика взаимодействия для _33_add_item.xaml
    /// </summary>
    public partial class _33_add_item : Window
    {
        public _33_add_item()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Event newEvent = new Event()
                {
                    Name = NameTb.Text,
                    Date = DateDp.SelectedDate.Value,
                    Logo = Phototb.Text,
                    DirectionId = Convert.ToInt32(DirectionTb.Text)
                };

                App.context.Event.Add(newEvent);
                App.context.SaveChanges();

                MessageBox.Show("Мероприятие успешно добавлено!");
            }
            catch
            {

            }
        }
    }
}
