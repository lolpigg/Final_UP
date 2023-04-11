using Final_Project_UP.UPDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для ListOfPassengeresPage.xaml
    /// </summary>
    public partial class ListOfPassengeresPage : Page
    {
        list_of_passengeresTableAdapter list_Of_PassengeresTable = new list_of_passengeresTableAdapter();
        tripTableAdapter tripTable = new tripTableAdapter();
        passengerTableAdapter passengerTable = new passengerTableAdapter();
        public ListOfPassengeresPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = list_Of_PassengeresTable.GetData();
            trip_id.ItemsSource = tripTable.GetData();
            trip_id.DisplayMemberPath = "id";
            passenger_id.ItemsSource = passengerTable.GetData();
            passenger_id.DisplayMemberPath = "fio";
            passenger_id.SelectedValuePath = "id";
            trip_id.SelectedValuePath = "id";
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                if (passenger_id.SelectedItem == null || trip_id.SelectedItem == null)
                {
                    MessageBox.Show("Поля ввода данных не могут быть пустыми!");
                    return;
                }
                try
                {
                    list_Of_PassengeresTable.UpdateQuery(Convert.ToInt32((passenger_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((trip_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                    DataGrid.ItemsSource = list_Of_PassengeresTable.GetData();
                    trip_id.ItemsSource = tripTable.GetData();
                    passenger_id.ItemsSource = passengerTable.GetData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Данные введены в неверном формате.");
                    return;
                }
            }

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list_Of_PassengeresTable.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = list_Of_PassengeresTable.GetData();
            trip_id.ItemsSource = tripTable.GetData();
            passenger_id.ItemsSource = passengerTable.GetData();

        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (passenger_id.SelectedItem == null || trip_id.SelectedItem == null)
            {
                MessageBox.Show("Поля ввода данных не могут быть пустыми!");
                return;
            }
            try
            {
                list_Of_PassengeresTable.UpdateQuery(Convert.ToInt32((passenger_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((trip_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                DataGrid.ItemsSource = list_Of_PassengeresTable.GetData();
                trip_id.ItemsSource = tripTable.GetData();
                passenger_id.ItemsSource = passengerTable.GetData();
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены в неверном формате.");
                return;
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
                    passenger_id.SelectedValue = Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[1]);
                    trip_id.SelectedValue = Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[2]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Выбран неверный элемент!");
                    return;
                }
            }
        }
    }
}
