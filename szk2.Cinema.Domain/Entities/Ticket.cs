using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 
using SzkolenieTechniczne2.Cinema.Common.Entities;
using SzkolenieTechniczne2.Cinema.Domain.Entities;

namespace SzkolenieTechniczne2.Cinema.Domain
{
    // Poprawiony zapis: Schema podajemy jako drugi argument string, a nie przez ISchema
    [Table("Tickets", Schema = "Cinema")]
    public class Ticket : BaseEntity
    {
        // Konstruktor chroniony dla Entity Framework
        protected Ticket() { }

        public Ticket(string email, int peopleCount, long seanceId)
        {
            Email = email;
            SeanceId = seanceId;
            PeopleCount = peopleCount;
            CreatedOn = DateTime.Now; // Upewnij się, że w BaseEntity to pole jest public lub protected
        }

        [MaxLength(256)] // Poprawiona literówka (było MaxLenght)
        [Required]
        public string Email { get; protected set; }

        [Range(1, 100)]
        public int PeopleCount { get; protected set; }

        public long SeanceId { get; protected set; }

        // Navigation Property
        public virtual Seance Seance { get; protected set; }
    }
}