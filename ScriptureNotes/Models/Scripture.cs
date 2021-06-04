using System;
using System.ComponentModel.DataAnnotations;

namespace ScriptureNotes.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [Display(Name = "Scripture")]
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Book { get; set; }

        [StringLength(800, MinimumLength = 2)]
        [Required]
        public string Note { get; set; }

        [Required]
        public string Chapter { get; set; }

        [Required]
        public string Verse { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateAdded { get; set; }
    }
}