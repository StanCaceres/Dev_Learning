﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            /*
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}"
                , myOtherCar.Make
                , myOtherCar.Model
                , myOtherCar.Year
                , myOtherCar.Color
                );

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}"
                    , myCar.Make
                    , myCar.Model
                    , myCar.Year
                    , myCar.Color
                    );

            myOtherCar = null;

            Console.WriteLine("{0} {1} {2} {3}"
                , myThirdCar.Make
                , myThirdCar.Model
                , myThirdCar.Year
                , myThirdCar.Color
                );

            myCar = null;

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }
    }
}
