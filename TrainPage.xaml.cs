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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Final_Project_UP.UPDataSetTableAdapters;

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для TrainPage.xaml
    /// </summary>
    public partial class TrainPage : Page
    {
        trainTableAdapter trainTable = new trainTableAdapter();
        train_modelTableAdapter modelTable = new train_modelTableAdapter();
        public TrainPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = trainTable.GetData();
            model_id.ItemsSource = modelTable.GetData();
            model_id.DisplayMemberPath = "mark";
            model_id.SelectedValuePath = "id";
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (model_id.SelectedIndex == -1 || expirience.Text == "")
            {
                MessageBox.Show("Поля не могут быть пустыми!");
                return;
            }
            try
            {
                Convert.ToInt32(expirience.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Стаж должен состоять из цифр!");
                throw;
            }
            if (DataGrid.SelectedIndex != -1)
            {
                trainTable.UpdateQuery(Convert.ToInt32((model_id.SelectedItem as DataRowView).Row[0]), (bool)color.IsChecked, Convert.ToInt32(expirience.Text), Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                DataGrid.ItemsSource = trainTable.GetData();
                model_id.ItemsSource = modelTable.GetData();
                model_id.DisplayMemberPath = "mark";
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                trainTable.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                DataGrid.ItemsSource = trainTable.GetData();
                model_id.ItemsSource = modelTable.GetData();
                model_id.DisplayMemberPath = "mark";
            }

        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (model_id.SelectedIndex == -1 || expirience.Text == "")
            {
                MessageBox.Show("Поля не могут быть пустыми!");
                return;
            }
            try
            {
                Convert.ToInt32(expirience.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Стаж должен состоять из цифр!");
                return;
            }
            trainTable.InsertQuery(Convert.ToInt32((model_id.SelectedItem as DataRowView).Row[0]), Convert.ToBoolean(color.IsChecked), Convert.ToInt32(expirience.Text));
                DataGrid.ItemsSource = trainTable.GetData();
                model_id.ItemsSource = modelTable.GetData();
                model_id.DisplayMemberPath = "mark";
            

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
                    model_id.SelectedValue = Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[1]);
                    if (Convert.ToBoolean((DataGrid.SelectedItem as DataRowView).Row[2]))
                    {
                        color.IsChecked = true;
                    }
                    else
                    {
                        color.IsChecked = false;
                    }
                    expirience.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[3]);
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
