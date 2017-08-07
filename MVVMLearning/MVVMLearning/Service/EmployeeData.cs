using MVVMLearning.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLearning.Service
{
    public class EmployeeData
    {

        public ObservableCollection<Employee> GetCollectionEmployees()
        {
            var employee = new ObservableCollection<Employee>
            {
                new Employee{ID =1, Name="Redar", Age=32},
                new Employee{ID =2, Name="Zana", Age=32},
                new Employee{ID =3, Name="Aka", Age=32},
                new Employee{ID =4, Name="Zhera", Age=32},
                new Employee{ID =5, Name="Salar", Age=32},
                new Employee{ID =6, Name="Ahmed", Age=32},
                new Employee{ID =7, Name="Zakria", Age=32},
                new Employee{ID =8, Name="Jwamer", Age=32},
                new Employee{ID =9, Name="Hewa", Age=32},
                new Employee{ID =10, Name="Imad", Age=32},
                new Employee{ID =11, Name="Srood", Age=32},
                new Employee{ID =12, Name="Dana", Age=32},
            };

            return employee;
        }
    }
}
