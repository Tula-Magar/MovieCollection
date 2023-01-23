using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Models
{
    public class MoviesModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a movie title")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Please enter a title that is 3 characters or less")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Pleae enter a Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter a Genre")]
        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Please enter a Price")]
        public decimal Price { get; set; }

        public string? Rating { get; set; }
    }

}
