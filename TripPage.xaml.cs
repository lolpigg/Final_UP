using Final_Project_UP.UPDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для TripPage.xaml
    /// </summary>
    public partial class TripPage : Page
    {
        tripTableAdapter tripTable = new tripTableAdapter();
        routeTableAdapter routeTable = new routeTableAdapter();
        trainTableAdapter trainTable = new trainTableAdapter();
        workerTableAdapter workerTable = new workerTableAdapter();
        public TripPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = tripTable.GetData();
            worker_id.ItemsSource = workerTable.GetData();
            worker_id.DisplayMemberPath = "fio";
            train_id.ItemsSource = trainTable.GetData();
            train_id.DisplayMemberPath = "id";
            route_id.ItemsSource = routeTable.GetData();
            route_id.DisplayMemberPath = "id";
            train_id.SelectedValuePath = "id";
            route_id.SelectedValuePath = "id";
            worker_id.SelectedValuePath = "id";
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                if (worker_id.SelectedIndex == -1 || route_id.SelectedIndex == -1 || train_id.SelectedIndex == -1 || end.Text == "" || start.Text == "")
                {
                    MessageBox.Show("Поля не могут быть пустыми.");
                    return;
                }
                try
                {
                    Convert.ToDateTime(end.Text);
                    Convert.ToDateTime(start.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Дата имеет неверный формат.");
                    return;
                }
                DateTime one = Convert.ToDateTime(start.Text);
                DateTime two = Convert.ToDateTime(end.Text);
                if (one.Date > two.Date)
                {
                    MessageBox.Show("Дата прибытия не может быть раньше даты отбытия.");
                    return;
                }
                if (one.Date == two.Date)
                {
                    MessageBox.Show("Дата прибытия не может быть равна дате отбытия.");
                    return;
                }
                if (one.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Нельзя создавать пути в прошлом!");
                    return;
                }
                tripTable.UpdateQuery(Convert.ToInt32((worker_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((route_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((train_id.SelectedItem as DataRowView).Row[0]), Convert.ToDateTime(start.Text), Convert.ToDateTime(end.Text), Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                DataGrid.ItemsSource = tripTable.GetData();
                worker_id.ItemsSource = workerTable.GetData();
                worker_id.DisplayMemberPath = "fio";
                train_id.ItemsSource = trainTable.GetData();
                route_id.ItemsSource = routeTable.GetData();
            }

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                tripTable.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                DataGrid.ItemsSource = tripTable.GetData();
                worker_id.ItemsSource = workerTable.GetData();
                worker_id.DisplayMemberPath = "fio";
                train_id.ItemsSource = trainTable.GetData();
                route_id.ItemsSource = routeTable.GetData();
            }

        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (worker_id.SelectedIndex == -1 || route_id.SelectedIndex == -1 || train_id.SelectedIndex == -1 || end.Text == "" || start.Text == "")
            {
                MessageBox.Show("Поля не могут быть пустыми.");
                return;
            }
            try
            {
                Convert.ToDateTime(end.Text);
                Convert.ToDateTime(start.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Дата имеет неверный формат.");
                return;
            }
            tripTable.InsertQuery(Convert.ToInt32((worker_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((route_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((train_id.SelectedItem as DataRowView).Row[0]), Convert.ToDateTime(start.Text), Convert.ToDateTime(end.Text));
            DataGrid.ItemsSource = tripTable.GetData();
            worker_id.ItemsSource = workerTable.GetData();
            worker_id.DisplayMemberPath = "fio";
            train_id.ItemsSource = trainTable.GetData();
            route_id.ItemsSource = routeTable.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
                    worker_id.SelectedValue = Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[1]);
                    route_id.SelectedValue = Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[2]);
                    train_id.SelectedValue = Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[3]);
                    start.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[4]);
                    end.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[5]); 
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
