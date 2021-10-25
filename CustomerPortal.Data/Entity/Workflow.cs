using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPortal.Data.Entity
{
    public class Workflow
    {
        [Key]
        [Required]
        public int WorkflowId { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        
        public ICollection<WorkflowItem> WorkflowItems { get; set; }
    }
}
