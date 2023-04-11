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
using MaterialDesignThemes.Wpf;

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для RolePage.xaml
    /// </summary>
    public partial class RolePage : Page
    {
        roleTableAdapter roleTable = new roleTableAdapter();
        public RolePage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = roleTable.GetData();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                if (name.Text == "")
                {
                    MessageBox.Show("Роль не должна быть пустой!");
                }
                for (int i = 0; i < name.Text.Length; i++)
                {
                    if (char.IsNumber(name.Text[i]))
                    {
                        MessageBox.Show("Роль не должна содержать цифры!");
                        return;
                    }
                }
                Regex hohma = new Regex("[А-Яа-я]");
                if (!hohma.IsMatch(name.Text))
                {
                    MessageBox.Show("В полях не должно быть хохмы!");
                    return;
                }
                roleTable.UpdateQuery(name.Text, Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                DataGrid.ItemsSource = roleTable.GetData();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
            roleTable.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = roleTable.GetData();
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Роль не должна быть пустой!");
            }
            Regex hohma = new Regex("[А-Яа-я]");
            if (!hohma.IsMatch(name.Text))
            {
                MessageBox.Show("В полях не должно быть хохмы!");
                return;
            }
            for (int i = 0; i < name.Text.Length; i++)
            {
                if (char.IsNumber(name.Text[i]))
                {
                    MessageBox.Show("Роль не должна содержать цифры!");
                    return;
                }
            }
            roleTable.InsertQuery(name.Text);
            DataGrid.ItemsSource = roleTable.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
            name.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[1]);

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
