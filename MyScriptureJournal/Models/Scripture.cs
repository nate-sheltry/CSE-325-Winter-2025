using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models;
    public class Scripture
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Book { get; set; } = string.Empty;

        [Display(Name = "Excerpt")]
        [RegularExpression(@"^\d{1,3}(?::\d{1,3})?(?:-\d{1,3})?$")]
        [Required]
        public string Range { get; set; } = string.Empty;

        [StringLength(1000, MinimumLength = 3)]
        [Required]
        public string Notes { get; set; } = string.Empty;

        [Display(Name = "Date Added"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }
    }
