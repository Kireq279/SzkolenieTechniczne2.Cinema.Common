
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SzkolenieTechniczne2.Cinema.Common.Entities
{
    public class BaseEntity : ItrackedEntity
    {
        [Key]
        public long Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid CreatedByUserId { get; set; }
        public Guid ModifiedByUserId { get; set; }
    }
}