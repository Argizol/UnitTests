using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsSeminar2
{
    public class Motorcycle : Vehicle
    {
        string _company { get; set; }
        string _model { get; set; }
        int _yearRelease { get; set; }
       public int _numWheels { get; private set; }
        public int _speed { get; private set; }
        public Motorcycle(string company, string model, int year)
        {
            _company = company;
            _model = model;
            _yearRelease = year;
            _numWheels = 2;
            _speed = 0;
        }

        public override void testDrive()
        {
            _speed = 75;
        }

        public override void park()
        {
            _speed = 0;
        }

        public override string ToString()
        {
            return $"This motorcycle is a year {_yearRelease} make {_model};";
        }
    }
}
