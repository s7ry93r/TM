using System;
using System.ComponentModel.DataAnnotations;
using TM.Data.Interfaces;

namespace TM.Data.Models
{
    public class AppUser : IModificationHistory
    {
        [Required]
        public int Id { get; set; }

        public int? AppLogonId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Name must between 8 and 30 characters long")]
        public string Name { get; set; }

        [Required]
        public string Pwd { get; set; }

        public string UserEmail { get; set; }

        public string UserSmartPhone { get; set; }

        [Required]
        public int Level = 0;

        public bool DeleteFlag { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
