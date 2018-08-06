using System;
using System.ComponentModel.DataAnnotations;
using TM.Data.Interfaces;

namespace TM.Data.Models
{
    public class AppEntityRole : IModificationHistory
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int AppRoleId { get; set; }

        [Required]
        public int EntityId { get; set; }

        [Required]
        public int Level { get; set; }

        public bool DeleteFlag { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
