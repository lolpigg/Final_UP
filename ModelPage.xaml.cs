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
using Final_Project_UP.UPDataSetTableAdapters;

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для ModelPage.xaml
    /// </summary>
    public partial class ModelPage : Page
    {
        train_modelTableAdapter modelTableAdapter = new train_modelTableAdapter();
        public ModelPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = modelTableAdapter.GetData();
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                try
                {
                    Convert.ToInt32(max_speed.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Скорость должна быть числовой!");
                    return;
                }
                Regex hohma = new Regex("[А-Яа-я/s]");
                if (!hohma.IsMatch(mark.Text))
                {
                    MessageBox.Show("В полях не должно быть хохмы!");
                    return;
                }
                if (!hohma.IsMatch(producer.Text))
                {
                    MessageBox.Show("В полях не должно быть хохмы!");
                    return;
                }
                modelTableAdapter.UpdateQuery(producer.Text, mark.Text, Convert.ToInt32(max_speed.Text), Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                DataGrid.ItemsSource = modelTableAdapter.GetData();
            }

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
            modelTableAdapter.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = modelTableAdapter.GetData();

            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Convert.ToInt32(max_speed.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Скорость должна быть числовой!");
                return;
            }
            Regex hohma = new Regex("[А-Яа-я/s]");
            if (!hohma.IsMatch(mark.Text))
            {
                MessageBox.Show("В полях не должно быть хохмы!");
                return;
            }
            if (!hohma.IsMatch(producer.Text))
            {
                MessageBox.Show("В полях не должно быть хохмы!");
                return;
            }
            modelTableAdapter.InsertQuery(producer.Text, mark.Text, Convert.ToInt32(max_speed.Text));
            DataGrid.ItemsSource = modelTableAdapter.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
            producer.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[1]);
            mark.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[2]);
            max_speed.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[3]);

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
