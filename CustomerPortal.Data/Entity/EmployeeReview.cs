using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPortal.Data.Entity
{
    public class EmployeeReview
    {
        [Key]
        [Required]
        public int EmployeeReviewId { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        public DateTime ReviewDate { get; set; }
        public int WorkflowItemId { get; set; }
        
        public Employee Employee { get; set; }
        public WorkflowItem WorkflowItem { get; set; }
        public ICollection<EmployeeReviewAnswer> EmployeeReviewAnswers { get; set; }
    }
}
