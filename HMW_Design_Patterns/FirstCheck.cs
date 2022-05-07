﻿using System;
namespace HMW_Design_Patterns
{
    public class FirstCheck : Garage
    {
        public FirstCheck()
        {
        }

        public override void HandleCar(Car car)
        {
            int num = new Random().Next(1, 10);
            if (num >= 6)
            {
                CarNeedRepair = false;
                Console.WriteLine("Car Don'T Need Repair! You Are Ready to Go! - From First Check");
            }
            if (Garage1 != null)
            {
                Garage1.HandleCar(car);
            }
            else
            {
                Console.WriteLine("Your Car Is Fix,Without Any Problems,You can Go. - From First Check");
            }
        }
    }
}
