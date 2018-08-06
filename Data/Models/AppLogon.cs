using System;
using System.ComponentModel.DataAnnotations;
using TM.Data.Interfaces;

namespace TM.Data.Models
{
    public class AppLogon : IModificationHistory
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Name must between 8 and 30 characters long")]
        public string Name { get; set; }

        [Required]
        public string Pwd { get; set; }

        public bool DeleteFlag { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }

    }
}
