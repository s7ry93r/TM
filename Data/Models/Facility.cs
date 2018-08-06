using System;
using System.ComponentModel.DataAnnotations;
using TM.Data.Interfaces;


namespace TM.Data.Models
{
    public class Facility : IModificationHistory
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(12, ErrorMessage="Must be between 8 and 12 characters long", MinimumLength = 8)]
        public string ProviderNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string FacilityName { get; set; }

        public bool DeleteFlag { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }

    }
}
