﻿using System.ComponentModel.DataAnnotations;

namespace AspTest.DTOs
{
    public class CreateUserDto
    {
        public long Id { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
