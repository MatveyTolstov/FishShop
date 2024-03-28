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
using System.Windows.Shapes;
using gh.SHOPHUNTERANDFISHMANDataSetTableAdapters;
using static MaterialDesignThemes.Wpf.Theme;

namespace gh
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        private static RolesTableAdapter roles = new RolesTableAdapter();
        private static UsersTableAdapter users = new UsersTableAdapter();
        private static EmployeesTableAdapter employees = new EmployeesTableAdapter();

        private static System.Collections.IEnumerable rol;
        private static System.Collections.IEnumerable user;
        private static System.Collections.IEnumerable emplo;

        static Admin()
        {
             rol = roles.GetData();
             user = users.GetData();
             emplo = employees.GetData();
        }
        public Admin()
        {
            InitializeComponent();
            FirstText_Box.PreviewTextInput += FirstTextBox_PreviewTextInput;
            SecondText_Box.PreviewTextInput += SecondTextBox_PreviewTextInput;
            ThirdText_Box.PreviewTextInput += ThirdTextBox_PreviewTextInput;
            FirstText_Box.MaxLength = 20;
            SecondText_Box.MaxLength = 20;
            ThirdText_Box.MaxLength = 20;
            FirstPswd.MaxLength = 20;
            RolesGr.ItemsSource = rol;
            SecondText_Box.Visibility = Visibility.Collapsed;
            FirstPswd.Visibility = Visibility.Collapsed;
            ThirdText_Box.Visibility = Visibility.Collapsed;
            Fourth_Combobox.Visibility = Visibility.Collapsed;
        } 
        private void RolesGr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowTextBox();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RolesGr.ItemsSource = emplo;
            SecondText_Box.Visibility = Visibility.Visible;
            ThirdText_Box.Visibility = Visibility.Visible;
            Fourth_Combobox.Visibility = Visibility.Visible;
            FirstPswd.Visibility = Visibility.Collapsed;
            FirstPswd.Password = null;
            Fourth_Combobox.ItemsSource = rol;
            Fourth_Combobox.DisplayMemberPath = "RoleName";
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            RolesGr.ItemsSource = user;
            FirstText_Box.Text = null;
            
            SecondText_Box.Visibility = Visibility.Collapsed;
            ThirdText_Box.Visibility = Visibility.Collapsed;
            Fourth_Combobox.Visibility = Visibility.Visible;
            FirstPswd.Visibility = Visibility.Visible;
            Fourth_Combobox.ItemsSource = rol;
            Fourth_Combobox.DisplayMemberPath = "RoleName";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RolesGr.ItemsSource = rol;

            FirstPswd.Visibility = Visibility.Collapsed;
            SecondText_Box.Visibility = Visibility.Collapsed;
            ThirdText_Box.Visibility = Visibility.Collapsed;
            Fourth_Combobox.Visibility = Visibility.Collapsed;


        }
        
        private void FirstTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Zа-яА-Я]+$"))
            {
                MessageBox.Show("Строка должна содержать только буквы.");
                e.Handled = true;

                FirstText_Box.Text = "";
            }
        }
        private void ThirdTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Zа-яА-Я]+$"))
            {
                MessageBox.Show("Строка должна содержать только буквы.");

                e.Handled = true;

                ThirdText_Box.Text = "";
            }
        }
        private void SecondTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            if (!Regex.IsMatch(e.Text, @"^[a-zA-Zа-яА-Я]+$"))
            {
                MessageBox.Show("Строка должна содержать только буквы.");
                
                e.Handled = true;

                SecondText_Box.Text = "";
            }
        }


        private void Create_Button_Click(object sender, RoutedEventArgs e)
        {
            if(RolesGr.ItemsSource == rol)
            {
                if (FirstText_Box.Text != "")
                {
                    
                    roles.InsertQuery(FirstText_Box.Text);

                    rol = roles.GetData();

                    RolesGr.ItemsSource = rol;
                }
                else
                {
                    MessageBox.Show("Строка не должна быть пустой", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (RolesGr.ItemsSource == user)
            {
                if (FirstText_Box.Text != "" && FirstPswd.Password != "" && Fourth_Combobox.Text != "")
                {
                    users.InsertQuery(FirstText_Box.Text, FirstPswd.Password, SelectId());

                    user = users.GetData();

                    RolesGr.ItemsSource = user;
                }
                else
                {
                    MessageBox.Show("Строка не должна быть пустой", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else if (RolesGr.ItemsSource == emplo) {
                if (FirstText_Box.Text != "" && SecondText_Box.Text != "" && ThirdText_Box.Text != "" && Fourth_Combobox.Text != "")
                {
                    employees.InsertQuery(FirstText_Box.Text, SecondText_Box.Text, ThirdText_Box.Text, SelectId());

                    emplo = employees.GetData();

                    RolesGr.ItemsSource = emplo;
                }
                else
                {
                    MessageBox.Show("Строка не должна быть пустой", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }


            }

            

            
        }
        private void ShowTextBox()
        {
            if (RolesGr.ItemsSource == rol)
            {
                if (RolesGr.SelectedItem as DataRowView != null)
                {
                    object name = (RolesGr.SelectedItem as DataRowView).Row[1];
                    FirstText_Box.Text = name.ToString();
                }

            }
            else if (RolesGr.ItemsSource == emplo)
            {
                if (RolesGr.SelectedItem as DataRowView != null)
                {
                    object name = (RolesGr.SelectedItem as DataRowView).Row[1];
                    object midname = (RolesGr.SelectedItem as DataRowView).Row[2];
                    object surname = (RolesGr.SelectedItem as DataRowView).Row[3];
                    FirstText_Box.Text = name.ToString();
                    SecondText_Box.Text = midname.ToString();
                    ThirdText_Box.Text = surname.ToString();

                }
            }
            else if (RolesGr.ItemsSource == user)
            {
                if (RolesGr.SelectedItem as DataRowView != null)
                {
                    object name = (RolesGr.SelectedItem as DataRowView).Row[1];
                    object password = (RolesGr.SelectedItem as DataRowView).Row[2];
                    FirstText_Box.Text = name.ToString();
                    FirstPswd.Password = password.ToString();
                    

                }
            }


        }
        private int SelectId()
        {
            if (Fourth_Combobox.SelectedItem != null)
            {
                var id = (int)(Fourth_Combobox.SelectedItem as DataRowView).Row[0];

                return id;

            }
            return 0;
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            
            

                if (RolesGr.ItemsSource == rol)
                {
                    try
                    {
                        object id_del = (RolesGr.SelectedItem as DataRowView).Row[0];

                        roles.DeleteQuery(Convert.ToInt32(id_del));

                        rol = roles.GetData();

                        RolesGr.ItemsSource = rol;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка,нельзя удалить Роль когда она есть у кого то  ", "Ошибка" + ex.Message , MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    
                    

                }
                else if (RolesGr.ItemsSource == user)
                {
                    object id_del = (RolesGr.SelectedItem as DataRowView).Row[0];

                    users.DeleteQuery(Convert.ToInt32(id_del));
                    
                    user = users.GetData();
                    RolesGr.ItemsSource = user;
                }
                else if (RolesGr.ItemsSource == emplo)
                {
                    object id_del = (RolesGr.SelectedItem as DataRowView).Row[0];

                    employees.DeleteQuery(Convert.ToInt32(id_del));
                    emplo = employees.GetData();

                    RolesGr.ItemsSource = emplo;
                }
            


        }

        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            if (RolesGr.ItemsSource == rol)
            {
                if (FirstText_Box.Text != "")
                {
                    object id_update = (RolesGr.SelectedItem as DataRowView).Row[0];
                    roles.UpdateQuery(FirstText_Box.Text, Convert.ToInt32(id_update));

                    rol = roles.GetData();

                    RolesGr.ItemsSource = rol;
                }
                else
                {
                    MessageBox.Show("Нельзя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (RolesGr.ItemsSource == user)
            {
                if (FirstText_Box.Text != "" || FirstPswd.Password != "" || Fourth_Combobox.Text != "") {
                    object id_update = (RolesGr.SelectedItem as DataRowView).Row[0];

                    users.UpdateQuery(FirstText_Box.Text, FirstPswd.Password, SelectId(), Convert.ToInt32(id_update));

                        user = users.GetData();

                        RolesGr.ItemsSource = user;
                    }
                else
                {
                    MessageBox.Show("Нельзя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (RolesGr.ItemsSource == emplo)
            {
                if (FirstText_Box.Text != "" && SecondText_Box.Text != "" && ThirdText_Box.Text != "")
                {

                    object id_update = (RolesGr.SelectedItem as DataRowView).Row[0];

                    employees.UpdateQuery(FirstText_Box.Text, SecondText_Box.Text, ThirdText_Box.Text, SelectId(), Convert.ToInt32(id_update));

                    emplo = employees.GetData();

                    RolesGr.ItemsSource = emplo;
                }
                else
                {
                    MessageBox.Show("Нельзя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();

            Close();
        }
    }
}
