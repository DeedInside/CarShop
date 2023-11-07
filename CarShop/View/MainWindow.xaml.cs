using CarShop.DataContext;
using CarShop.ViewModel;
using CarShop.ViewModel.Command;
using System.Windows;

namespace CarShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainVM();
            ListCar.ItemsSource = CarLocator.Cars;
            Groupbatton.DataContext = new MainWinCommand();
        }
    }
}
