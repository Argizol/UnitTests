namespace Seminar3
{
    public class HW3
    {
        int n {  get; set; }
        public HW3() { }
        public bool EvenOddNumber(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool NumberInInterval(int n)
        {
            if(n > 25 && n < 100)
                return true;
            return false;
        }

    }
}
