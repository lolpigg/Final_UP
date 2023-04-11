using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using Final_Project_UP.UPDataSetTableAdapters;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для LogsPage.xaml
    /// </summary>
    public partial class LogsPage : Page
    {
        logsTableAdapter logsTable = new logsTableAdapter();
        roleTableAdapter roleTable = new roleTableAdapter();
        public LogsPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = logsTable.GetData();
            role_id.ItemsSource = roleTable.GetData();
            role_id.DisplayMemberPath = "name";
            role_id.SelectedValuePath = "id";
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {

                if (role_id.SelectedIndex == -1 || login.Text == "" || password.Password == "")
                {
                    MessageBox.Show("Поля для ввода данных не могут быть пустыми");
                    return;
                }
                Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
                if (!validateGuidRegex.IsMatch(password.Password))
                {
                    MessageBox.Show("Пароль неверного формата! Правила для пароля: • Содержит минимум 8 символов в длину.\r\n• По крайней мере, одна заглавная английская буква.\r\n• По крайней мере одна строчная  английская буква.\r\n• По крайней мере, одна цифра. \r\n• По крайней мере, один специальный символ.");
                }
                Regex hohma = new Regex("[А-Яа-я]");
                if (!hohma.IsMatch(login.Text))
                {
                    MessageBox.Show("В полях не должно быть хохмы!");
                    return;
                }
                if (!hohma.IsMatch(password.Password))
                {
                    MessageBox.Show("В полях не должно быть хохмы!");
                    return;
                }
                logsTable.InsertQuery(Convert.ToInt32((role_id.SelectedItem as DataRowView).Row[0]), login.Text, password.Password);
                DataGrid.ItemsSource = logsTable.GetData();
                role_id.ItemsSource = roleTable.GetData();
                role_id.DisplayMemberPath = "name";
                DataGrid.Columns[-1].Visibility = Visibility.Hidden;

            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                logsTable.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                DataGrid.ItemsSource = logsTable.GetData();
                role_id.ItemsSource = roleTable.GetData();
                role_id.DisplayMemberPath = "name";
                DataGrid.Columns[-1].Visibility = Visibility.Hidden;

            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (role_id.SelectedIndex == -1 || login.Text == "" || password.Password == "")
            {
                MessageBox.Show("Поля для ввода данных не могут быть пустыми");
                return;
            }
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (!validateGuidRegex.IsMatch(password.Password))
            {
                MessageBox.Show("Пароль неверного формата! Правила для пароля: • Содержит минимум 8 символов в длину.\r\n• По крайней мере, одна заглавная английская буква.\r\n• По крайней мере одна строчная  английская буква.\r\n• По крайней мере, одна цифра. \r\n• По крайней мере, один специальный символ.");
                return;
            }
            Regex hohma = new Regex("[А-Яа-я]");
            if (!hohma.IsMatch(login.Text))
            {
                MessageBox.Show("В полях не должно быть хохмы!");
                return;
            }
            if (!hohma.IsMatch(password.Password))
            {
                MessageBox.Show("В полях не должно быть хохмы!");
                return;
            }
            logsTable.InsertQuery(Convert.ToInt32((role_id.SelectedItem as DataRowView).Row[0]), login.Text, password.Password);
            DataGrid.ItemsSource = logsTable.GetData();
            role_id.ItemsSource = roleTable.GetData();
            role_id.DisplayMemberPath = "name";
            DataGrid.Columns[-1].Visibility = Visibility.Hidden;

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
                    role_id.SelectedValue = Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[1]);
                    login.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[2]);
                    password.Password = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[3]);

                }
                catch (Exception)
                {
                    MessageBox.Show("Выбран неверный элемент!");
                    return;
                }
            }
        }


        private void FromJson_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функционал все еще в работе.");
            /*
   OpenFileDialog dialog = new OpenFileDialog();
   if (dialog.ShowDialog() == true)
   {
       string json = File.ReadAllText(dialog.FileName);
       LogsClass obj = Json.Convert
   }
            */
        }

        private void DataGrid_LayoutUpdated(object sender, EventArgs e)
        {

            DataGrid.Columns[3].Visibility = Visibility.Hidden;
        }
    }
}
