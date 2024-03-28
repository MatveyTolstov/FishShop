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
using gh.SHOPHUNTERANDFISHMANDataSetTableAdapters;

namespace gh
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UsersTableAdapter usersTable = new UsersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            var data = usersTable.GetData().Rows;
            bool loggedIn = false;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i][1].ToString() == NameBox.Text && data[i][2].ToString() == PasswdBox.Password)
                {
                    int roleid = (int)data[i][3];

                    switch (roleid)
                    {
                        case 1:
                            Admin admin = new Admin();
                            admin.Show();
                            Close();
                            break;
                        case 2:
                            Sklad sklad = new Sklad();
                            sklad.Show();
                            Close();
                            break;
                        case 61:
                            Buy buy = new Buy();
                            buy.Show();
                            Close ();
                            break;
                    }
                    loggedIn = true;
                    break;
                }

            }
            if (!loggedIn)
            {
                MessageBox.Show("Пароль или логин не верный", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Button_Click(Button_Auth, null);
            }
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
