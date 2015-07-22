using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSelectComboBox.XAMLWay
{
    class DataSource : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        //Sample data for MultiSelectComboBox

        private ObservableCollection<string> _cities = new ObservableCollection<string> { "Bangalore","Chennai", "Delhi", "Mumbai", "Kolkata", "California", "Newyark", "Phoenix", "Hyderabad", "Islamabad", "Singapore", "Atlanta", "London", "Melbourne", "Tokyo", "Jaipur", "Hong Kong", "Beijing", "Patna", "Ahmedabad", "Srinagar", "Agra", "Pune", "Adelide", "Dhaka" };

        public ObservableCollection<string> Cities
        {
            get { return _cities; }
        }

        private string _selectedCity = "Bangalore";
        public string SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                _selectedCity = value;
                OnPropertyChanged("SelectedCity");
            }
        }

        private ObservableCollection<string> _countries = new ObservableCollection<string> { "India", "Pakistan", "Bangladesh", "China", "Srilanka", "Malaysia", "Maldives", "Japan", "Singapore", "Italy", "Russia", "Korea", "United States of America", "United Kingdom", "France"};

        public ObservableCollection<string> Countries
        {
            get { return _countries; }
        }

        private string _selectedCountry = "India";
        public string SelectedCountry
        {
            get { return _selectedCountry; }
            set
            {
                _selectedCity = value;
                OnPropertyChanged("SelectedCountry");
            }
        }
    }
}
