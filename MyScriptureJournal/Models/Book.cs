using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models;

    public class Book
    {
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Name { get; set; } = string.Empty;
    }

