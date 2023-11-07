using CarShop.Model.Car;
using System.Collections.ObjectModel;
namespace CarShop.DataContext
{
    public static class CarLocator
    {
        public static ObservableCollection<Car> Cars { get; } =
            new ObservableCollection<Car>()
            {
                new Car("Honda", "Accord", 2002, 400000),
                new Car("Toyota", "Corolla", 2001, 750000),
                new Car("Nisan", "Teana", 2007, 800000)
            };
    }
}
