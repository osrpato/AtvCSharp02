using Microsoft.VisualBasic;
using System;

namespace CarAPI.Model
{
    public class Car
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

        public string Plate { get; set; }

        public DateTime InitialDate { get; set; }

        public DateTime LastDate { get; set; }

        public int ParkingId { get; set; }


    }
}
