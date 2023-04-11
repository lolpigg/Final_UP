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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для RoutePage.xaml
    /// </summary>
    public partial class RoutePage : Page
    {
        routeTableAdapter routeTable = new routeTableAdapter();
        public RoutePage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = routeTable.GetData();
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                for (int i = 0; i < start.Text.Length; i++)
                {
                    if (char.IsNumber(start.Text[i]))
                    {
                        MessageBox.Show("Станция не должна содержать цифры!");
                        return;
                    }
                }
                for (int i = 0; i < end.Text.Length; i++)
                {
                    if (char.IsNumber(end.Text[i]))
                    {
                        MessageBox.Show("Станция не должна содержать цифры!");
                        return;
                    }
                }
                try
                {
                    Convert.ToInt32(price.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Цена должна содержать цифры!");
                    return;
                }
                Regex hohma = new Regex("[А-Яа-я/s]");
                if (!hohma.IsMatch(end.Text))
                {
                    MessageBox.Show("В полях не должно быть хохмы!");
                    return;
                }
                if (!hohma.IsMatch(start.Text))
                {
                    MessageBox.Show("В полях не должно быть хохмы!");
                    return;
                }
                routeTable.UpdateQuery(start.Text, end.Text, Convert.ToInt32(price.Text), Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = routeTable.GetData();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {

            routeTable.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = routeTable.GetData();
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < start.Text.Length; i++)
            {
                if (char.IsNumber(start.Text[i]))
                {
                    MessageBox.Show("Станция не должна содержать цифры!");
                    return;
                }
            }
            for (int i = 0; i < end.Text.Length; i++)
            {
                if (char.IsNumber(end.Text[i]))
                {
                    MessageBox.Show("Станция не должна содержать цифры!");
                    return;
                }
            }
            try
            {
                Convert.ToInt32(price.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Цена должна содержать цифры!");
                return;
            }
            Regex hohma = new Regex("[А-Яа-я/s]");
            Regex hohma1 = new Regex("[А-Яа-я]");
            if (!hohma.IsMatch(end.Text))
            {
                MessageBox.Show("В полях не должно быть хохмы!");
                return;
            }
            if (!hohma1.IsMatch(start.Text))
            {
                MessageBox.Show("В полях не должно быть хохмы!");
                return;
            }
            routeTable.InsertQuery(start.Text, end.Text, Convert.ToInt32(price.Text));
            DataGrid.ItemsSource = routeTable.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
            start.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[1]);
            end.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[2]);
            price.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[3]);

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
