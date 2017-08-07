using MVVMLearning.Models;
using MVVMLearning.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLearning.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Employee> _employeeCollection;
        EmployeeData emp = new EmployeeData();
        public event PropertyChangedEventHandler PropertyChanged;
        public BaseViewModel()
        {
            _employeeCollection = emp.GetCollectionEmployees();

        }

        public ObservableCollection<Employee> GetEmployeeCollection
        {
            get { return _employeeCollection; }
            set
            {
                _employeeCollection = value;

                OnPropertyChanged();
            }
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
