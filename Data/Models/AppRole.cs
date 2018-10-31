using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TM.Data.Interfaces;

namespace TM.Data.Models
{
    public class AppRole : IModificationHistory
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Must be between 4 and 50 characters long", MinimumLength = 4)]
        public string Name { get; set; }

        public string Desc { get; set; }

        [Required]
        [Range(0,2, ErrorMessage ="Must be a 0, 1, or 2. Facility Logon = 0, User Logon = 1, User at Facility = 2")]
        public int Level { get; set; }

        public bool DeleteFlag { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
