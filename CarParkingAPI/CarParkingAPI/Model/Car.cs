using System;

namespace CarParkingAPI.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string LicensePlate { get; set; }
        public int ParkingId { get; set; }
        public DateTime DateInitial { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
