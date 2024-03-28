using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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

namespace gh
{
    /// <summary>
    /// Логика взаимодействия для Sklad.xaml
    /// </summary>
    public partial class Sklad : Window
    {
        private static ProductsTableAdapter products = new ProductsTableAdapter();

        private static CategoriesTableAdapter categories = new CategoriesTableAdapter();

        private static System.Collections.IEnumerable prod;
        private static System.Collections.IEnumerable categ;

        static Sklad()
        {
            prod = products.GetData();
            categ = categories.GetData();
        }
        public Sklad()
        {
            InitializeComponent();

            this.SecondText_Box.PreviewTextInput += new TextCompositionEventHandler(SecondText_Box_PreviewTextInput);
            FirstText_Box.PreviewTextInput += FirstTextBox_PreviewTextInput;
            FirstText_Box.MaxLength = 20;
            SecondText_Box.MaxLength = 20;

            
            DataGr.ItemsSource = prod;

            Fourth_Combobox.ItemsSource = categ;

            Fourth_Combobox.DisplayMemberPath = "CategoryName";
        }

        private void Product_Button_Click(object sender, RoutedEventArgs e)
        {
            DataGr.ItemsSource = prod;

            SecondText_Box.Visibility = Visibility.Visible;
            Fourth_Combobox.Visibility = Visibility.Visible;
        }

        private void Kategories_Button_Click(object sender, RoutedEventArgs e)
        {
            SecondText_Box.Visibility = Visibility.Collapsed;
            Fourth_Combobox.Visibility = Visibility.Collapsed;
            DataGr.ItemsSource = categ;
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
        private void Create_Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataGr.ItemsSource == prod)
            {
                if (FirstText_Box.Text != "" && Fourth_Combobox.Text != "" && SecondText_Box.Text != "")
                {
                    products.InsertQuery(FirstText_Box.Text, SelectId(), Convert.ToInt32(SecondText_Box.Text));

                    prod = products.GetData();

                    DataGr.ItemsSource = prod;
                }
                else
                {
                    MessageBox.Show("Нельзя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                

            }
            else if (DataGr.ItemsSource == categ)
            {
                if (FirstText_Box.Text != "")
                {
                    categories.InsertQuery(FirstText_Box.Text);

                    categ = categories.GetData();

                    DataGr.ItemsSource = categ;

                }
                else
                {
                    MessageBox.Show("Нельзя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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

        private void SecondText_Box_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataGr.ItemsSource == prod)
            {
                    object id_del = (DataGr.SelectedItem as DataRowView).Row[0];

                    products.DeleteQuery(Convert.ToInt32(id_del));

                    prod = products.GetData();

                    DataGr.ItemsSource = prod;

            }
            else if (DataGr.ItemsSource == categ)
            {
                object id_del = (DataGr.SelectedItem as DataRowView).Row[0];

                categories.DeleteQuery(Convert.ToInt32(id_del));

                categ = categories.GetData();

                DataGr.ItemsSource = categ;
            }
        }

        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataGr.ItemsSource == prod)
            {
                if (FirstText_Box.Text != "" && Fourth_Combobox.Text != "" && SecondText_Box.Text != "")
                {

                    object id_update = (DataGr.SelectedItem as DataRowView).Row[0];

                    products.UpdateQuery(FirstText_Box.Text, SelectId(), Convert.ToInt32(SecondText_Box.Text), Convert.ToInt32(id_update));

                    prod = products.GetData();

                    DataGr.ItemsSource = prod;
                }
                else
                {
                    MessageBox.Show("Нельзя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else if (DataGr.ItemsSource == categ)
            {
                if (FirstText_Box.Text != "")
                {

                    object id_update = (DataGr.SelectedItem as DataRowView).Row[0];

                    categories.UpdateQuery(FirstText_Box.Text, Convert.ToInt32(id_update));

                    categ = categories.GetData();

                    DataGr.ItemsSource = categ;
                }
                else
                {
                    MessageBox.Show("Нельзя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ShowTextBox()
        {
            if (DataGr.ItemsSource == prod)
            {
                if (DataGr.SelectedItem as DataRowView != null)
                {
                    object name = (DataGr.SelectedItem as DataRowView).Row[1];
                    object price = (DataGr.SelectedItem as DataRowView).Row[3];
                    FirstText_Box.Text = name.ToString();
                    SecondText_Box.Text = price.ToString();
                }

            }
            else if (DataGr.ItemsSource == categ)
            {
                if (DataGr.SelectedItem as DataRowView != null)
                {
                    object name = (DataGr.SelectedItem as DataRowView).Row[1];
                   
                    FirstText_Box.Text = name.ToString();
                

                }
            }
        }

        private void DataGr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowTextBox();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DataGr.ItemsSource == prod)
                {
                    List<Product> forimport = SerialandDeser.Deserisis<List<Product>>();

                    foreach (var item in forimport)
                    {
                        products.InsertQuery(item.ProductName, item.Category_ID, item.Price);
                    }

                    prod = products.GetData();
                    DataGr.ItemsSource = prod;
                }
                else if (DataGr.ItemsSource == categ)
                {
                    List<Categoriesss> forimport = SerialandDeser.Deserisis<List<Categoriesss>>();

                    foreach (var item in forimport)
                    {
                        categories.InsertQuery(item.CategoryName);
                    }

                    categ = categories.GetData();
                    DataGr.ItemsSource = categ;
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка, разный импорт таблиц", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
