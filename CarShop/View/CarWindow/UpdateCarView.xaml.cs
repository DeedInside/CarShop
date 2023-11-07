using CarShop.DataContext;
using CarShop.Model.Car;
using CarShop.ViewModel.Command;
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

namespace CarShop.View.CarWindow
{
    public partial class UpdateCarView : Window
    {
        public UpdateCarView(Car selectCar)
        {
            InitializeComponent();
            this.DataContext = selectCar;
        }
        private void CloseWin(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
