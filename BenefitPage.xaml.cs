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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Final_Project_UP.UPDataSetTableAdapters;

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для BenefitPage.xaml
    /// </summary>
    public partial class BenefitPage : Page
    {
        benefitTableAdapter benefitTable = new benefitTableAdapter();
        public BenefitPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = benefitTable.GetData();
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
                MessageBox.Show("Выберите элемент.");
                return;
            }
                if (min_age.Text == "" || max_age.Text == "" || size.Text == "")
                {
                    MessageBox.Show("Поля ввода данных не могут быть пустыми!");
                    return;
                }
                try
                {
                if (Convert.ToInt32(size.Text) > 100)
                {
                    size.Text = "100";
                }
                if (Convert.ToInt32(size.Text) < 0)
                {
                    size.Text = "0";
                }
                    benefitTable.UpdateQuery(Convert.ToInt32(min_age.Text), Convert.ToInt32(max_age.Text), Convert.ToInt32(size.Text), Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
                }
                catch (Exception)
                {
                    MessageBox.Show("Данные введены в неверном формате.");
                    return;
                }
                DataGrid.ItemsSource = benefitTable.GetData();
           

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedIndex != -1)
            {
            benefitTable.DeleteQuery(Convert.ToInt32((DataGrid.SelectedItem as DataRowView).Row[0]));
            DataGrid.ItemsSource = benefitTable.GetData();

            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (min_age.Text == "" || max_age.Text == "" || size.Text == "")
            {
                MessageBox.Show("Поля ввода данных не могут быть пустыми!");
                return;
            }
            try
                {
                    benefitTable.InsertQuery(Convert.ToInt32(min_age.Text), Convert.ToInt32(max_age.Text), Convert.ToInt32(size.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Данные введены в неверном формате.");
                    return;
                }
                DataGrid.ItemsSource = benefitTable.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                try
                {
                    min_age.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[1]);
                    max_age.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[2]);
                    size.Text = Convert.ToString((DataGrid.SelectedItem as DataRowView).Row[3]);
                }
                catch
                {
                    MessageBox.Show("Выбран неверный элемент!");
                    return;
                }
            }
        }
    }
}
