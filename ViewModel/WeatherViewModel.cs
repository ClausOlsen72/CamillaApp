using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamillaApp.ViewModel
{
   public class WeatherViewModel : ViewModelBase
    {
        double latitude;
        double longitude;

        public RelayCommand WeatherCommand { get; private set; }

        public double Latitude
        {
            get
            {
                return latitude;
            }

            set
            {
                latitude = value;
                OnPropertyChanged();
            }
        }

        public double Longitude
        {
            get
            {
                return longitude;
            }

            set
            {
                longitude = value;
                OnPropertyChanged();
            }
        }

        bool execute = true;

        public WeatherViewModel()
        {
            WeatherCommand = new RelayCommand(GetWeather,() => execute);
        }

        private void GetWeather()
        {
            throw new NotImplementedException();
        }
    }
}
