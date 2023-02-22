﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        // BUILD FOREIGN KEY RELATIONSHIP
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
