using System;
using System.ComponentModel.DataAnnotations; //allows validation

namespace MovieCollection.Models
{
    public class NewMovie
    {
        [Key] //automatic
        [Required]
        public int MovieId { get; set; }

        //required fields
        [Required(ErrorMessage ="Category Required")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Title Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year Required")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Director Required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating Required")]
        public string Rating { get; set; }

        //optional fields
        public bool? Edited { get; set; }
        public string? Lent { get; set; }
        [StringLength(25)] //only allows notes to be <= 25 chars
        public string? Notes { get; set; }
    }
}
