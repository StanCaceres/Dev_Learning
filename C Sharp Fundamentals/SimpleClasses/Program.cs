﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "silver";

            Console.Write("{0} {1} {2} {3}"
                        , myCar.make
                        , myCar.Model
                        , myCar.Year
                        , myCar.Color
                        );
            Console.ReadLine();
        }
    }

    class Car
    {
        public string make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    }
