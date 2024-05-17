﻿using System.ComponentModel.DataAnnotations;

namespace ExamManagement.Models.ViewModels
{
    public class UpdateStudent
    {
        //[Required]
        //public int StudentId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }
        public string? Role { get; set; }
        public string? Status { get; set; }

    }
}

