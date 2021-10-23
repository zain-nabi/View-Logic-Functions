using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using View_Logic_Functions.ViewModel;

namespace View_Logic_Functions.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }

    public class NewVehicle
    {
        public List<Vehicle> Get()
        {
            var VehicleViewModel = new VehicleViewModel();
            var vehicleList = new List<Vehicle>();


            vehicleList.Add(new Vehicle() { Make = "Toyota", Model = "Aygo", Color = "Red", VehicleID = 1 });
            vehicleList.Add(new Vehicle() { Make = "Subaru", Model = "Forester", Color = "White", VehicleID = 2 });
            vehicleList.Add(new Vehicle() { Make = "Datsun", Model = "Go", Color = "Blue", VehicleID = 3 });

            VehicleViewModel.Vehicles = vehicleList;

            return VehicleViewModel.Vehicles;
        }

        public List<Vehicle> GetTrucks()
        {
            var VehicleViewModel = new VehicleViewModel();
            var vehicleList = new List<Vehicle>();


            vehicleList.Add(new Vehicle() { Make = "MAN", Model = "Spiti", Color = "Red", VehicleID = 1 });
            vehicleList.Add(new Vehicle() { Make = "Mercedes", Model = "Sprinter", Color = "White", VehicleID = 2 });
            vehicleList.Add(new Vehicle() { Make = "VOLVO", Model = "Torino", Color = "Blue", VehicleID = 3 });

            VehicleViewModel.Vehicles = vehicleList;

            return VehicleViewModel.Vehicles;
        }
    }
}
