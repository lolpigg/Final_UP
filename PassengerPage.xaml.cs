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
using Final_Project_UP.UPDataSetTableAdapters;

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для PassengerPage.xaml
    /// </summary>
    public partial class PassengerPage : Page
    {
        passengerTableAdapter passengerTable = new passengerTableAdapter();
        public PassengerPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = passengerTable.GetData();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                if (fio.Text == "" || age.Text == "" || sex.Text == "" || passport_data.Text == "")
                {
                    MessageBox.Show("Поля не могут быть пустыми.");
                    return;
                }
                try
                {
                    Convert.ToInt32(age.Text);
                    Convert.ToInt32(passport_data.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Возраст и паспортные данные должны содержать лишь цифры.");
                    return;
                }
                if (Convert.ToInt32(age.Text) < 0)
                {
                    MessageBox.Show("Возраст не может быть отрицательным!");
                    return;
                }
                if (fio.Text.Split(' ').Length < 2)
                {
                    MessageBox.Show("ФИО слишком короткое.");
                    return;
                }
                if (fio.Text.Split(' ').Length > 3)
                {
                    MessageBox.Show("ФИО слишком длинное.");
                }
                for (int i = 0; i < fio.Text.Length; i++)
                {
                    if (char.IsNumber(fio.Text[i]))
                    {
                        MessageBox.Show("ФИО не должно содержать цифры!");
                        return;
                    }
                }
                passport_data.Text.Replace(" ", "");
                if (passport_data.Text.Length > 10)
                {
                    MessageBox.Show("Паспортные данные слишком длинные.");
                }
                else if (passport_data.Text.Length < 10)
                {
                    MessageBox.Show("Паспортные данные слишком короткие.");
                }
                Regex hohma = new Regex("[А-Яа-я/s]");
                Regex hohma1 = new Regex("[А-Яа-я]");
                if (!hohma.IsMatch(fio.Text))
                {
                    MessageBox.Show("В полях не должно быть хохмы!");
                    return;
                }
                if (!hohma1.IsMatch(sex.Text))
                {
                    MessageBox.Show("В полях не должно быть хохмы!");
                    return;
                }
                passengerTable.UpdateQuery(fio.Text, Convert.ToInt32(age.Text), sex.Text, Convert.ToInt32(passport_data), Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = passengerTable.GetData();

            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
            passengerTable.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = passengerTable.GetData();
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (fio.Text == "" || age.Text == "" || sex.Text == "" || passport_data.Text == "")
            {
                MessageBox.Show("Поля не могут быть пустыми.");
                return;
            }
            try
            {
                Convert.ToInt32(age.Text);
                Convert.ToInt32(passport_data.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Возраст и паспортные данные должны содержать лишь цифры.");
                return;
            }
            if (Convert.ToInt32(age.Text) < 0)
            {
                MessageBox.Show("Возраст не может быть отрицательным!");
                return;
            }
            if (fio.Text.Split(' ').Length < 2)
            {
                MessageBox.Show("ФИО слишком короткое.");
                return;
            }
            if (fio.Text.Split(' ').Length > 3)
            {
                MessageBox.Show("ФИО слишком длинное.");
            }
            for (int i = 0; i < fio.Text.Length; i++)
            {
                if (char.IsNumber(fio.Text[i]))
                {
                    MessageBox.Show("ФИО не должно содержать цифры!");
                    return;
                }
            }
            passport_data.Text.Replace(" ", "");
            if (passport_data.Text.Length > 10)
            {
                MessageBox.Show("Паспортные данные слишком длинные.");
            }
            else if (passport_data.Text.Length < 10)
            {
                MessageBox.Show("Паспортные данные слишком короткие.");
            }
            Regex hohma = new Regex("[А-Яа-я/s]");
            Regex hohma1 = new Regex("[А-Яа-я]");
            if (!hohma.IsMatch(fio.Text))
            {
                MessageBox.Show("В полях не должно быть хохмы!");
                return;
            }
            if (!hohma1.IsMatch(sex.Text))
            {
                MessageBox.Show("В полях не должно быть хохмы!");
                return;
            }
            passengerTable.InsertQuery(fio.Text, Convert.ToInt32(age.Text), sex.Text, Convert.ToInt32(passport_data.Text));
            DataGrid.ItemsSource = passengerTable.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
            fio.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[1]);
            age.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[2]);
            sex.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[3]);
            passport_data.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[4]);

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
