using System;

namespace vehiclelot
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.doorCount();
            myCar.wheelCount();

            Semi mySemi = new Semi();
            mySemi.doorCount();
            mySemi.wheelCount();
        }
    }

    public class Vehicle
    {
        protected int wheels(int wheels)
        {
            return 2;
        }

        protected int doors(int doors)
        {
            return 2;
        }
        
    }

    public class Car : Vehicle
    {
        public void doorCount()
        {
            doors(4);
        }
        
        public void wheelCount()
        {
            wheels(4);
        }
        
    }

    public class Semi : Vehicle
    {
        public void wheelCount()
        {
            wheels(18);
        }

        public void doorCount()
        {

        }
        
    }
}
