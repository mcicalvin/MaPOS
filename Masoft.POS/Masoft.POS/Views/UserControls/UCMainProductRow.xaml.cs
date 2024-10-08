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

namespace Masoft.POS.Views.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlMain.xaml
    /// </summary>
    public partial class UCMainProductRow : UserControl
    {
        public UCMainProductRow()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            List<Item> items = new List<Item>
            {
                new Item { Description = "Item 1", Qty = 7, Price = 19.99, Total = 19.99, ActionImage = "pack://application:,,,/Resources/Images/pos_delete.png"},
                new Item { Description = "Item 2", Qty = 5, Price = 29.99, Total = 19.99, ActionImage = "pack://application:,,,/Resources/Images/pos_delete.png"}
            };
           // ListViewInput.ItemsSource = items;
        }
    }

    public class Item
    {
        public string? Description { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string? ActionImage { get; set; }
       
    }

}
