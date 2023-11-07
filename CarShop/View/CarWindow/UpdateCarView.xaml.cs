using CarShop.Model.Car;
using System.Windows;

namespace CarShop.View.CarWindow
{
    public partial class UpdateCarView : Window
    {
        public Car car { get; set; }
        public UpdateCarView(Car selectCar)
        {
            InitializeComponent();
            car = selectCar;
            DataContext = car;
        }
        void updateCar(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
