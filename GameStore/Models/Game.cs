using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GameStore.Models
{
    public class Game
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        public string? Descriprion { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 200)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string? Studio { get; set; }
    }
}
