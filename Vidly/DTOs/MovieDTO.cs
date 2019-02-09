using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Vidly.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
       
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1, 20, ErrorMessage = "The field Number In Stock must be between 1 and 20.")]
        public byte NumberInStock { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}