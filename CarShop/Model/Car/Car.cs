using CarShop.Model.BaseModels;
using System;

namespace CarShop.Model.Car
{
    public class Car : PropertyAuto
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        private string brand;
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
                OnPropertyChanged(nameof(Brand));
            }
        }
        private string model;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
                OnPropertyChanged(nameof(Model));
            }
        }
        private short ageProduction;
        public short AgeProduction
        {
            get
            {
                return ageProduction;
            }
            set
            {
                ageProduction = value;
                OnPropertyChanged(nameof(AgeProduction));
            }
        }
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged(nameof(price));
            }
        }

        public Car() { }
        public Car(string brand, string model, short ageProduction, int price)
        {
            this.brand = brand;
            this.model = model;
            this.ageProduction = ageProduction;
            this.price = price;
        }
    }
}
