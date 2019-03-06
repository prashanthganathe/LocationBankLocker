using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankLocker.Models
{
    public class LocationModel: AuditBaseModel
    {
      
            
        [Key]
        public int Id { get; set; }

        [Display(Name = "Location Name")]     
        public string Name { get; set; }
        public virtual ICollection<LocationBank> LocationBanks { get; set; }
        
    }
}
