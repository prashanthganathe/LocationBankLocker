using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankLocker.Models
{
    public class LocationBank: AuditBaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual ICollection<LockerModel> Lockers { get; set; }
    }
}
