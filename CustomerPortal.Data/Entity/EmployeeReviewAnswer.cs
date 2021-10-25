using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPortal.Data.Entity
{
    public class EmployeeReviewAnswer
    {
        [Key]
        [Required]
        public int EmployeeReviewAnswerId { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [Required]
        public int EmployeeReviewId { get; set; }
        public string Text { get; set; }
        public int Score { get; set; }

        public Question Question { get; set; }

        public EmployeeReview EmployeeReview { get; set; }
        
    }
}
