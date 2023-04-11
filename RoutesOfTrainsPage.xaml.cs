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
    /// Логика взаимодействия для RoutesOfTrainsPage.xaml
    /// </summary>
    public partial class RoutesOfTrainsPage : Page
    {
        routes_of_trainsTableAdapter routes_Of_TrainsTable = new routes_of_trainsTableAdapter();
        routeTableAdapter routeTable = new routeTableAdapter();
        trainTableAdapter trainTable = new trainTableAdapter();
        public RoutesOfTrainsPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = routes_Of_TrainsTable.GetData();
            train_id.ItemsSource = trainTable.GetData();
            route_id.ItemsSource = routeTable.GetData();
            route_id.DisplayMemberPath = "id";
            train_id.DisplayMemberPath = "id";
            route_id.SelectedValuePath = "id";
            train_id.SelectedValuePath = "id";
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                if (route_id.SelectedIndex == -1 || train_id.SelectedIndex == -1)
                {
                    MessageBox.Show("ID не могут быть пустыми");
                    return;
                }
                routes_Of_TrainsTable.UpdateQuery(Convert.ToInt32((route_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((train_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                DataGrid.ItemsSource = routes_Of_TrainsTable.GetData();
                train_id.ItemsSource = trainTable.GetData();
                route_id.ItemsSource = routeTable.GetData();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
            routes_Of_TrainsTable.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = routes_Of_TrainsTable.GetData();
            train_id.ItemsSource = trainTable.GetData();
            route_id.ItemsSource = routeTable.GetData();

            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (route_id.SelectedIndex == -1 || train_id.SelectedIndex == -1)
            {
                MessageBox.Show("ID не могут быть пустыми");
                return;
            }
            routes_Of_TrainsTable.InsertQuery(Convert.ToInt32((route_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((train_id.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = routes_Of_TrainsTable.GetData();
            train_id.ItemsSource = trainTable.GetData();
            route_id.ItemsSource = routeTable.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
            route_id.SelectedValue = Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[1]);
            train_id.SelectedValue = Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[2]);

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
