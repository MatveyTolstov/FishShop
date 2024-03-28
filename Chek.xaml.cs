using System;
using System.Collections.Generic;
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

namespace gh
{
    /// <summary>
    /// Логика взаимодействия для Chek.xaml
    /// </summary>
    public partial class Chek : Window
    {
        Chek_ProductTableAdapter adapter = new Chek_ProductTableAdapter();
        public Chek()
        {
            InitializeComponent();
        }

        private void Chek_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string file = Chek_ComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(file))
            {
                FileInfo fileInfo = new FileInfo(file);

                

                string json = File.ReadAllText(fileInfo.Name);


            }


            List<Cheks> forimport = SerialandDeser.Deserisis<List<Cheks>>();

            foreach (var item in forimport)
            {
                adapter.InsertQuery(item.ProductName, item.Price);
            }

            ChekGr.ItemsSource = adapter.GetData();
        }
    }
}
