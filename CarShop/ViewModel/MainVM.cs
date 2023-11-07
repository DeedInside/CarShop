using CarShop.DataContext;
using CarShop.Model.BaseModels;
using CarShop.Model.Car;
using CarShop.View.CarWindow;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarShop.ViewModel
{
    public class MainVM
    {
        ApplicationContext db = new ApplicationContext();
        public ObservableCollection<Car> Cars { get; set; }
        public MainVM() 
        {
            db.Database.EnsureCreated();
            db.Cars.Load();
            Cars = db.Cars.Local.ToObservableCollection();
        }

        private RelayCommand addCar;
        public RelayCommand AddCar
        {
            get
            {
                return addCar ?? (
                    addCar = new RelayCommand(obj =>
                    {
                        AddCarView addCarView = new AddCarView(new Car());

                        if (addCarView.ShowDialog() == true)
                        {
                            db.Cars.Add(addCarView.car);
                            db.SaveChanges();
                        }
                    }));
            }
        }

        private RelayCommand removeCar;
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
                                db.Cars.Remove(select);
                                db.SaveChanges();
                            }
                            catch (Exception ex)
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
        public RelayCommand UpdateCar
        {
            get
            {
                return updateCar ?? (
                    updateCar = new RelayCommand(obj =>
                    {
                        if (obj != null)
                        {
                            Car select = (obj as Car);
                            UpdateCarView upCar = new UpdateCarView(select);

                            if (upCar.ShowDialog() == true)
                            {

                                db.Entry(select).State = EntityState.Modified;
                                db.SaveChanges();
                            }

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
