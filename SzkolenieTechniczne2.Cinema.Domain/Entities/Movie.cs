using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using SzkolenieTechniczne2.Cinema.Common.Entities;

namespace SzkolenieTechniczne2.Cinema.Domain.Entities
{
    [Table("MovieCategory", Schema = "Cinema")]
    internal class Movie : BaseEntity
    {
        protected Movie() { }
        public Movie(string name, string year, int seanceTime, long movieCategoryId)
        {
            Name = name;
            Year = year;
            SeanceTime = seanceTime;
            MovieCategoryId = movieCategoryId;
        }

        [MaxLength(256)]
        [Required]
        public string Name { get; protected set; }
        [Range(1888, 2100)]
        public string Year { get; protected set; }
        [Range(1, 600)]
        public int SeanceTime { get; protected set; }

        public long MovieCategoryId { get; protected set; }
        public MovieCategory MovieCategory { get; protected set; }

        public virtual ICollection<Seance> Seances { get; protected set; }

        public Seance GetSeanceByDateAndRoomId(DateTime date)
        => Seances.SingleOrDefault(x => DateTime.Compare(x.Date, date) == 0);

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetYear(string year)
        {
            Year = year;
        }

        public void SetSeanceTime(int seanceTime)
        {
            SeanceTime = seanceTime;
        }
    }
}








