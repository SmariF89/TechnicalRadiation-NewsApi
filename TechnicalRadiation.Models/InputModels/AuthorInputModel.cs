using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models.InputModels
{
    public class AuthorInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Url(ErrorMessage = "Invalid Image URL")]
        public string ProfileImgSource { get; set; }

        [MaxLength(255)]
        public string Bio { get; set; }
    }
}