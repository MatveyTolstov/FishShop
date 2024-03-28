using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
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
using gh.SHOPHUNTERANDFISHMANDataSetTableAdapters;
using Newtonsoft.Json;

namespace gh
{
    /// <summary>
    /// Логика взаимодействия для Buy.xaml
    /// </summary>
    public partial class Buy : Window
    {
        static private ProductsTableAdapter productsTableAdapter = new ProductsTableAdapter();
        OrderDetailsTableAdapter order = new OrderDetailsTableAdapter();
        static private int OrderID = 0;
        private int totalPrice;
        public Buy()
        {
            InitializeComponent();

            ProductGr.ItemsSource = productsTableAdapter.GetData();

            BuyGr.ItemsSource =  null; ;

            
           

        }
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProductGr.Columns[0].Visibility = Visibility.Collapsed;

        }
        private void Role_Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private int PlusOrderId()
        {
            return ++OrderID;
        }
        private void Minus_Button_Click(object sender, RoutedEventArgs e)
        {
            object product = (ProductGr.SelectedItem as DataRowView).Row[0];
            
            order.InsertQuery(PlusOrderId(), Convert.ToInt32(product));
            
            BuyGr.ItemsSource = null;
            DataRowView selectedRow = ProductGr.SelectedItem as DataRowView;

            int Price = (int)selectedRow.Row["Price"];

            


            totalPrice += Price;

            Money_Label.Content = "Товары в чеке, общая цена" + totalPrice;
            BuyGr.ItemsSource = order.GetDataFUllBy();
            BuyGr.Columns[0].Visibility = Visibility.Collapsed;
            BuyGr.Columns[1].Visibility = Visibility.Collapsed;
            BuyGr.Columns[2].Visibility = Visibility.Collapsed;
            BuyGr.Columns[3].Visibility = Visibility.Collapsed;
        }

        private void Plus_Button_Click(object sender, RoutedEventArgs e)
        {
            object product = (BuyGr.SelectedItem as DataRowView).Row[0];

            order.DeleteQuery(Convert.ToInt32(product));


            BuyGr.ItemsSource = order.GetDataFUllBy();
            BuyGr.Columns[0].Visibility = Visibility.Collapsed;
            BuyGr.Columns[1].Visibility = Visibility.Collapsed;
            BuyGr.Columns[2].Visibility = Visibility.Collapsed;
            BuyGr.Columns[3].Visibility = Visibility.Collapsed;
        }

        private void Load_Button_Click(object sender, RoutedEventArgs e)
        {
           Microsoft.Win32.SaveFileDialog saveFile = new Microsoft.Win32.SaveFileDialog();

            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            //saveFile.Filter = $"чек_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}";


            if (saveFile.ShowDialog() == true)
            {
                string filename = saveFile.FileName;

                List<Dictionary<string, object>> itemlist = new List<Dictionary<string, object>>();

                foreach (var item in BuyGr.Items)
                {
                    if (item is DataRowView rowView )
                    {
                        string name = rowView.Row["ProductName"].ToString();

                        int price = (int) rowView.Row["Price"];


                        Dictionary<string, object> objects = new Dictionary<string, object>()
                        {
                            {"ProductName", name }, 
                            {"Price", price}
                        };
                        itemlist.Add(objects);

                    }

                    
                }

                string json = JsonConvert.SerializeObject(itemlist, Formatting.Indented);


                File.WriteAllText(System.IO.Path.ChangeExtension(filename, "json"), json);

                using(System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
                {
                    
                    if (BuyGr.Items[0] is DataRowView firstRow)
                    {
                        int chekId = (int)firstRow.Row["ID_OrderDetail"];
                        file.WriteLine($"                          Магазин рыбалки");
                        file.WriteLine($"                          Кассовый чек - {chekId}");

                        file.WriteLine();
                        file.WriteLine();

                        foreach (var item in itemlist)
                        {
                            string name = item["ProductName"].ToString();

                            int price = (int)item["Price"];

                            file.WriteLine($"                          {name} - {price} руб");

                        }
                        file.WriteLine();
                        file.WriteLine();


                        file.WriteLine($"Итого к оплате  {totalPrice}") ;

                        int totalPay = 0;

                        if (int.TryParse(Money_Box.Text, out int amount) && amount >= 0)
                        {
                            totalPay = amount;
                        }
                        else
                        {
                            MessageBox.Show("Ошибка не хватает денег( или вы вор!");
                        }


                        file.WriteLine($"Внесено денег {totalPay}");

                        int chmoney = totalPay - totalPrice;

                        file.WriteLine($"Ваша сдача: {chmoney}");

                        
                    }

                }
                
            }
           

        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();

            Close();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            Chek chek = new Chek();

            chek.Show();

            Close();
        }
    }
}
