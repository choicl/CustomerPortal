using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPortal.Data.Entity
{
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        [StringLength(400)]
        public string Position { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Resume { get; set; }
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public ICollection<EmployeeReview> EmployeeReviews { get; set; }
    }
}
