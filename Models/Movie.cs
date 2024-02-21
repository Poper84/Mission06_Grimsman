using System.ComponentModel.DataAnnotations;

namespace Mission_6.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

       
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

        [Required]
        public string Title { get; set; }
        [Range(1800, 2024)]
        [Required]
        public int Year { get; set; }
        
        public string? Director { get; set; }

        [Required]
        public string? Rating { get; set; } // Change data type to string

        [Required]
        public bool Edited { get; set; }

       
        public string? LentTo { get; set; }

        [Required]
        public string CopiedToPlex { get; set; }

        public string? Notes { get; set; }
    }
}
