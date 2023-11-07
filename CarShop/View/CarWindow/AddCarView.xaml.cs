using CarShop.DataContext;
using CarShop.Model.BaseModels;
using CarShop.Model.Car;
using CarShop.ViewModel.Command;
using System;
using System.Windows;

namespace CarShop.View.CarWindow
{
    public partial class AddCarView : Window
    {
        public AddCarView()
        {
            InitializeComponent();
        }
        private void CloseWin(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddCar(object sender, RoutedEventArgs e)
        {
            if (TextBrand.Text != "" && TextPrice.Text != "" 
                && TextModel.Text != "" && TextAge.Text != "")
            {
                CarLocator.Cars.Add(
                    new Car(
                        TextBrand.Text,
                        TextModel.Text,
                        Convert.ToInt16(TextAge.Text),
                        Convert.ToInt32(TextPrice.Text)
                        ));
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }
    }
}
