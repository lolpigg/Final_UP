using Final_Project_UP.UPDataSetTableAdapters;
using System;
using System.Collections;
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
    /// Логика взаимодействия для WorkerPage.xaml
    /// </summary>
    public partial class WorkerPage : Page
    {
        logsTableAdapter logsTable = new logsTableAdapter();
        workerTableAdapter workerTable = new workerTableAdapter();
        public WorkerPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = workerTable.GetData();
            logs_id.ItemsSource = logsTable.GetData();
            logs_id.DisplayMemberPath = "login";
            logs_id.SelectedValuePath = "id";
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                if (logs_id.SelectedIndex == -1 || fio.Text == "" || age.Text == "" || sex.Text == "" || expirience.Text == "" || profession.Text == "")
                {
                    MessageBox.Show("Поля не могут быть пустыми.");
                    return;
                }
                if (Convert.ToInt32(age.Text) < 0)
                {
                    MessageBox.Show("Возраст не может быть отрицательным!");
                    return;
                }
                try
                {
                    Convert.ToInt32(age.Text);
                    Convert.ToInt32(expirience.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Возраст и стаж должны содержать лишь цифры.");
                    return;
                }
                if (Convert.ToInt32(age.Text) < 18)
                {
                    MessageBox.Show("Мы не можем принять на работу лица, младше 18 лет!");
                    return;
                }
                if (Convert.ToInt32(age.Text) - 14 < Convert.ToInt32(expirience.Text))
                {
                    MessageBox.Show("Возраст не соответствует стажу.");
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
                for (int i = 0; i < profession.Text.Length; i++)
                {
                    if (char.IsNumber(profession.Text[i]))
                    {
                        MessageBox.Show("Профессия не должна содержать цифры!");
                        return;
                    }
                }
                for (int i = 0; i < sex.Text.Length; i++)
                {
                    if (char.IsNumber(sex.Text[i]))
                    {
                        MessageBox.Show("Пол не должен содержать цифры!");
                        return;
                    }
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
                if (!hohma.IsMatch(profession.Text))
                {
                    MessageBox.Show("В полях не должно быть хохмы!");
                    return;
                }
                workerTable.UpdateQuery(Convert.ToInt32((logs_id.SelectedItem as DataRowView).Row[0]), fio.Text, Convert.ToInt32(age.Text), sex.Text, Convert.ToInt32(expirience.Text), profession.Text, Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = workerTable.GetData();
            logs_id.ItemsSource = logsTable.GetData();
            logs_id.DisplayMemberPath = "login";
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                workerTable.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                DataGrid.ItemsSource = workerTable.GetData();
                logs_id.ItemsSource = logsTable.GetData();
                logs_id.DisplayMemberPath = "login";
            }

        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (logs_id.SelectedIndex == -1 || fio.Text == "" || age.Text == "" || sex.Text == "" || expirience.Text == "" || profession.Text == "")
            {
                MessageBox.Show("Поля не могут быть пустыми.");
                return;
            }
            try
            {
                Convert.ToInt32(age.Text);
                Convert.ToInt32(expirience.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Возраст и стаж должны содержать лишь цифры.");
                return;
            }
            if (fio.Text.Split(' ').Length < 2)
            {
                MessageBox.Show("ФИО слишком короткое.");
                return;
            }
            if (Convert.ToInt32(age.Text) < 0)
            {
                MessageBox.Show("Возраст не может быть отрицательным!");
                return;
            }
            if (Convert.ToInt32(age.Text) < 18)
            {
                MessageBox.Show("Мы не можем принять на работу лица, младше 18 лет!");
                return;
            }
            if (Convert.ToInt32(age.Text) - 14 < Convert.ToInt32(expirience.Text))
            {
                MessageBox.Show("Возраст не соответствует стажу.");
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
            for (int i = 0; i < profession.Text.Length; i++)
            {
                if (char.IsNumber(profession.Text[i]))
                {
                    MessageBox.Show("Профессия не должна содержать цифры!");
                    return;
                }
            }
            for (int i = 0; i < sex.Text.Length; i++)
            {
                if (char.IsNumber(sex.Text[i]))
                {
                    MessageBox.Show("Пол не должен содержать цифры!");
                    return;
                }
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
            if (!hohma.IsMatch(profession.Text))
            {
                MessageBox.Show("В полях не должно быть хохмы!");
                return;
            }
            workerTable.InsertQuery(Convert.ToInt32((logs_id.SelectedItem as DataRowView).Row[0]), fio.Text, Convert.ToInt32(age.Text), sex.Text, Convert.ToInt32(expirience.Text), profession.Text);
            DataGrid.ItemsSource = workerTable.GetData();
            logs_id.ItemsSource = logsTable.GetData();
            logs_id.DisplayMemberPath = "login";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
                    logs_id.SelectedValue = Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[1]);
                    fio.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[2]);
                    sex.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[3]);
                    expirience.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[4]);
                    profession.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[5]);
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
