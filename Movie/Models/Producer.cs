﻿using System.ComponentModel.DataAnnotations;

namespace Movie.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilePictureURL { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }

        //Realationship
        public List<Movie>? Movies { get; set; }
    }
}
