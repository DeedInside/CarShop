using CarShop.Model.Car;
using System.Windows;

namespace CarShop.View.CarWindow
{
    public partial class AddCarView : Window
    {
        public Car car { get; set; }
        public AddCarView(Car carSelect)
        {
            InitializeComponent();
            car = carSelect;
            DataContext = car;
        }
        void AddCar(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
