using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPortal.Data.Entity
{
    public class Question
    {
        [Key]
        [Required]
        public int QuestionId { get; set; }
        public string Text { get; set; }

        public ICollection<EmployeeReviewAnswer> EmployeeReviewAnswers {get;set;} 
       
    }
}
