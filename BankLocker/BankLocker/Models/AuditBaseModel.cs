using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankLocker.Models
{
    public class AuditBaseModel
    {
        //public string CreatedBy { get; set; }
        //public string ModifiedBy { get; set; }

   
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime ModifiedOn { get; set; } = DateTime.Now;
    }
}
