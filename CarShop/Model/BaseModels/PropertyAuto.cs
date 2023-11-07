using System.ComponentModel;

namespace CarShop.Model.BaseModels
{
    public class PropertyAuto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string str)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(str));
        }
    }
}
