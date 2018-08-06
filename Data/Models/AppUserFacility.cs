using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TM.Data.Interfaces;

namespace TM.Data.Models
{
    public class AppUserFacility : IModificationHistory
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int AppUserId { get; set; }

        [Required]
        public string FacilityId { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        [Required]
        public int Level = 1;

        public bool DeleteFlag { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
