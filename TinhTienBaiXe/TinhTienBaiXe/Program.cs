using System;
using System.Collections.Generic;

namespace TinhTienBaiXe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle vehicle;

            Console.WriteLine("Enter number of vehicle");
            int vehicleNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < vehicleNumber; i++)
            {
                vehicle = new Vehicle();

                Console.WriteLine("Enter your vehicle type:");
                vehicle.VehicleType = Console.ReadLine();

                Console.WriteLine("Enter your vehicle name:");
                vehicle.VehicleName = Console.ReadLine();

                vehicle.VehicleCode = i;

                Console.WriteLine("Enter your vehicle enter time:");
                vehicle.VehicleIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter your vehicle exit time:");
                vehicle.VehicleOut = DateTime.Parse(Console.ReadLine());

                vehicles.Add(vehicle);

            }

            Console.WriteLine("Enter your vehicle id");

            int vehicleId = int.Parse(Console.ReadLine());
            //goi tao gia tri default cho customer
            Vehicle customer = null;

            //tra lai xe dung theo id
            foreach (Vehicle customerVehicle in vehicles)
            {
                if (customerVehicle.VehicleCode == vehicleId)
                {
                    customer = customerVehicle;
                    //kiem duoc xe roi break thoi
                    break;
                }
            }

            TimeSpan hourInGarage = (customer.VehicleOut - customer.VehicleIn);
            double totalHour = hourInGarage.TotalHours;
            double parkingExpense;

            switch (customer.VehicleType)
            {
                case "xe dap":
                    parkingExpense = totalHour * 10;
                    Console.WriteLine("So tien can phai tra la {0}", parkingExpense);
                    break;
                case "xe may":
                     parkingExpense = totalHour * 200;
                     Console.WriteLine("So tien can phai tra la {0}", parkingExpense);
                    break;
                case "xe hoi":
                    parkingExpense = totalHour * 3000;
                    Console.WriteLine("So tien can phai tra la {0}", parkingExpense);
                    break;
            }

        }
    }
}
