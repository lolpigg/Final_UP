using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            PageFrame.Content = new RolePage();
        }

        private void role_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new RolePage();
        }

        private void train_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new TrainPage();
        }

        private void logs_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new LogsPage();
        }

        private void route_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new RoutePage();
        }

        private void worker_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new WorkerPage();
        }

        private void routes_of_trains_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new RoutesOfTrainsPage();
        }

        private void passenger_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new PassengerPage();
        }

        private void trip_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new TripPage();
        }

        private void benefit_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new BenefitPage();
        }

        private void list_of_passengeres_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ListOfPassengeresPage();
        }

        private void model_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ModelPage();
        }

        private void ticket_but_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new TicketPage();
        }
    }
}
