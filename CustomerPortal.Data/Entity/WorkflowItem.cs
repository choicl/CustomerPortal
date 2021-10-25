using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPortal.Data.Entity
{
    public class WorkflowItem
    {
        [Key]
        [Required]
        public int WorkflowItemId { get; set; }
        [Required]
        public int WorkflowId { get; set; }
        public bool IsApprovedByHR { get; set; }
        public bool IsApprovedByAM { get; set; }
        public DateTime HRApprovalDate { get; set; }
        public DateTime AMApprovalDate { get; set; }

        public Workflow Workflow { get; set; }
        public ICollection<EmployeeReview> EmployeeReviews { get; set; }
    }
}
