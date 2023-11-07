using CarShop.DataContext;
using CarShop.Model.BaseModels;
using CarShop.Model.Car;
using CarShop.View.CarWindow;
using System;
using System.Windows;

namespace CarShop.ViewModel.Command
{
    public class MainWinCommand
    {
        private RelayCommand addCar;
        /// <summary>
        /// Добавление машины
        /// </summary>
        public RelayCommand AddCar
        {
            get
            {
                return addCar ??(
                    addCar = new RelayCommand(obj =>
                    {
                        AddCarView addCarView = new AddCarView();
                        addCarView.Show();
                    }));
            }
        }
        private RelayCommand removeCar;
        /// <summary>
        /// Удаление машины
        /// </summary>
        public RelayCommand RemoveCar
        {
            get
            {
                return removeCar ?? (
                    removeCar = new RelayCommand(obj =>
                    {
                        if (obj != null)
                        {
                            Car select = obj as Car;
                            try
                            {
                                CarLocator.Cars.Remove(select);
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            MessageBox.Show($"Remove {select.Brand}");
                        }
                        else
                        {
                            MessageBox.Show("Выберите машину");
                        }

                    }));
            }
        }
        private RelayCommand updateCar;
        /// <summary>
        /// изменение машины
        /// </summary>
        public RelayCommand UpdateCar
        {
            get
            {
                return updateCar ?? (
                    updateCar = new RelayCommand(obj =>
                    {
                        if(obj != null)
                        {
                            UpdateCarView upCar = new UpdateCarView(obj as Car);
                            upCar.Show();
                        }
                        else
                        {
                            MessageBox.Show("Выберите машину");
                        }
                    }));
            }
        }
    }
}
