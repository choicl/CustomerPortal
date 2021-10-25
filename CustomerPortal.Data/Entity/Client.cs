using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerPortal.Data.Entity
{
    public class Client
    {
        [Key]
        [Required]
        public int ClientId { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
