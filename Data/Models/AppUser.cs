using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TM.Data.Interfaces;

namespace TM.Data.Models
{
    public class AppUser : IModificationHistory
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? FacilityID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Name must between 8 and 30 characters long")]
        public string Name { get; set; }

        [Required]
        public string Pwd { get; set; }

        public string UserEmail { get; set; }

        public string UserSmartPhone { get; set; }

        [Required]
        public int Level { get; set; }

        public bool DeleteFlag { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
