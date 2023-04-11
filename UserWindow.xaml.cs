using Final_Project_UP.UPDataSetTableAdapters;
using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        tripTableAdapter tripTable = new tripTableAdapter();
        routeTableAdapter routeTable = new routeTableAdapter();
        ticketTableAdapter ticketTable = new ticketTableAdapter();
        passengerTableAdapter passengerTable = new passengerTableAdapter();
        benefitTableAdapter benefitTable = new benefitTableAdapter();
        public UserWindow()
        {
            InitializeComponent();
            benefit_id.ItemsSource = benefitTable.GetData();
            benefit_id.DisplayMemberPath = "id";
            passenger_id.ItemsSource = passengerTable.GetData();
            passenger_id.DisplayMemberPath = "fio";
            trip_id.ItemsSource = tripTable.GetData();
            trip_id.DisplayMemberPath = "end_date";
            trip_id.SelectedValuePath = "id";
            benefit_id.SelectedValuePath = "id";
            passenger_id.SelectedValuePath = "id";
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            if (passenger_id.SelectedIndex == -1 || benefit_id.SelectedIndex == -1 || trip_id.SelectedIndex == -1 || payment.Text == "")
            {
                MessageBox.Show("ID и поля не могут быть пустыми");
                return;
            }
            try
            {
                Convert.ToInt32(payment.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Сумма платежа должна быть в цифрах!");
                return;
            }
            DataRow passenger_data2 = passengerTable.GetPassengerById(Convert.ToInt32((passenger_id.SelectedItem as DataRowView).Row[0])).Rows[0];
            DataRow benefit_data2 = benefitTable.GetBenefitById(Convert.ToInt32((benefit_id.SelectedItem as DataRowView).Row[0])).Rows[0];
            int passenger_age = Convert.ToInt32(passenger_data2[2]);
            int benefit_min = Convert.ToInt32(benefit_data2[1]);
            int benefit_max = Convert.ToInt32(benefit_data2[2]);
            if (passenger_age < benefit_min || passenger_age > benefit_max)
            {
                MessageBox.Show("Ваш возраст не подходит для выбранной льготы!");
                return;
            }
            ticketTable.InsertQuery(Convert.ToInt32((passenger_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((benefit_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((trip_id.SelectedItem as DataRowView).Row[0]), Convert.ToInt32(payment.Text));
            benefit_id.ItemsSource = benefitTable.GetData();
            passenger_id.ItemsSource = passengerTable.GetData();
            passenger_id.DisplayMemberPath = "fio";
            trip_id.ItemsSource = tripTable.GetData();
            trip_id.DisplayMemberPath = "end_date";
            int last_id = (int)ticketTable.ScalarQuery();
            DataRow route_data = ticketTable.GetRouteByTicket(last_id).Rows[0];
            int price = Convert.ToInt32(route_data[5]);
            string start_station = Convert.ToString(route_data[6]);
            string end_station = Convert.ToString(route_data[7]);
            int id = last_id;
            DataRow trip_data = ticketTable.GetTripByTicket(last_id).Rows[0];
            DateTime start_date = Convert.ToDateTime(trip_data[5]);
            DateTime end_date = Convert.ToDateTime(trip_data[6]);
            DataRow worker_data = ticketTable.GetWorkerByTicket(last_id).Rows[0];
            string worker = Convert.ToString(worker_data[5]);
            DataRow passenger_data = ticketTable.GetPassengerByTicket(last_id).Rows[0];
            string passenger = Convert.ToString(passenger_data[5]);
            DataRow benefit_data = ticketTable.GetBenefitByTicket(last_id).Rows[0];
            int min_age = Convert.ToInt32(benefit_data[5]);
            int max_age = Convert.ToInt32(benefit_data[6]);
            int size = Convert.ToInt32(benefit_data[7]);
            DataRow ticket_data = ticketTable.GetTicketById(last_id).Rows[0];
            int payment2 = Convert.ToInt32(ticket_data[4]);
            string content = Convert.ToString("\tРЖД\n\tКассовый чек №" + id + "\n\tНачальная станция: " + start_station + "\n\tКонечная станция: " + end_station + "\n\tВремя отбытия: " + start_date + "\n\tВремя прибытия: " + end_date + "\n\tПассажир: " + passenger + "\nПолная цена: " + price + "\nЛьгота: " + size + "%\nИтоговая цена: " + ((double)price - ((double)price * ((double)size / 100))) + "\nВнесено: " + payment2 + "\nСдача: " + (payment2 - ((double)price - ((double)price * ((double)size / 100)))));
            string path = Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Билет номер " + Convert.ToString(id) + ".txt");
            File.WriteAllText(path, content);
        }
    }
}
