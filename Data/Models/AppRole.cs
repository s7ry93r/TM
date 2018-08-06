using System;
using System.ComponentModel.DataAnnotations;
using TM.Data.Interfaces;

namespace TM.Data.Models
{
    public class AppRole : IModificationHistory
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Must be between 4 and 50 characters long", MinimumLength = 4)]
        public string Name { get; set; }

        public string Desc { get; set; }

        [Required]
        [Range(0,1, ErrorMessage ="Must be a 0 or 1. (0 is User Level, 1 is Facility Level)")]
        public int Level { get; set; }

        public bool DeleteFlag { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
