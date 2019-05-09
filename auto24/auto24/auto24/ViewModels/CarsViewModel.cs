using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using auto24.Models;
using auto24.MyData;

namespace auto24.ViewModels
{
    public class CarsViewModel
    {
        private ObservableCollection<Cars> cars;
        public ObservableCollection<Cars> Cars
        {
            get { return cars; }
            set
            {
                cars = value;
            }
        }

        public CarsViewModel()
        {
            Cars = new ObservableCollection<Cars>();

            MyData1 _context = new MyData1();

            foreach (var car in _context.Cars)
            {
                Cars.Add(car);
            }
        }
    }
}
