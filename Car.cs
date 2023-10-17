namespace UnitTestsSeminar2
{
    public class Car : Vehicle
    {
        string _company {  get; set; }
        string _model { get; set; }
        int _yearRelease { get; set; }
        public int _numWheels { get; private set; }
        public int _speed { get; private set; }
        public Car(string company, string model, int year)
        {
            _company = company;
            _model = model;
            _yearRelease = year;
            _numWheels = 4;
            _speed = 0;
        }
        public override void park()
        {
           _speed = 0;
        }

        public override void testDrive()
        {
            _speed = 60;
        }      

        public override string ToString()
        {
            return $"This car is a year {_yearRelease} make {_model};";
        }
    }
}
