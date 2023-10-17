using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsSeminar2
{
    public abstract class Vehicle
    {
        string _company;
        string _model;
        int _yearRelease;
        int numWheels;
        int speed;
        public abstract void testDrive();

        public abstract void park();


    }
}
