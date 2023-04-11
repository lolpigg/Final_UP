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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Final_Project_UP.UPDataSetTableAdapters;
namespace Final_Project_UP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        logsTableAdapter logsTable = new logsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            var allLogins = logsTable.GetData().Rows;
            for (int i = 0; i < allLogins.Count; i++)
            {
                if (allLogins[i][2].ToString() == loginbox.Text && allLogins[i][3].ToString() == passwordbox.Password)
                {
                    int roleid = (int)allLogins[i][1];
                    switch (roleid)
                    {
                        case 7:
                            AdminWindow a = new AdminWindow();
                            a.Show();
                            Close();
                            break;
                        default:
                            MessageBox.Show("Функционал для вашей роли еще не добавлен.");
                            break;
                    }
                }
            }
        }

        private void Enter_User_Click(object sender, RoutedEventArgs e)
        {
            UserWindow a = new UserWindow();
            a.Show();
            Close();
        }
    }
}
