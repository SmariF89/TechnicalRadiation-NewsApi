using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models.InputModels
{
    public class CategoryInputModel
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}