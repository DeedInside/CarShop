using CarShop.DataContext;
using CarShop.ViewModel;
using System.Windows;

namespace CarShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainVM();
        }
    }
}
