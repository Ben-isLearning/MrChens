﻿using System.ComponentModel.DataAnnotations;
namespace MrChens.Data.Models
{
    public class Customer
    {
        [Key]
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }

    }
}