using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SzkolenieTechniczne2.Cinema.Common.Entities;
using SzkolenieTechniczne2.Cinema.Domain.Entities;

namespace SzkolenieTechniczne2.Cinema.Domain
{
    [Table("MovieCategory", Schema = "Cinema")]
    public class MovieCategory : BaseEntity
    {
        protected MovieCategory() 
        { 
        }
        public MovieCategory(string name)
        {
            Name = name;
        }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; protected set; } = new List<Movie>();
    }
}
