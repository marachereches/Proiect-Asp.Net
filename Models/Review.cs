﻿namespace Proiect.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int? HotelID { get; set; }
        public Hotel? Hotel { get; set; } 
        public int? OrasID { get; set; }
        public Oras? Oras { get; set; }
         public int? TaraID { get; set; }
        public Tara? Tara { get; set; }

        public string? Parere { get; set; }  

    }
}
