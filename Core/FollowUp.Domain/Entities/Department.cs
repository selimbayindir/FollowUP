using FollowUp.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowUp.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; }
        public Company Company { get; set; }
        ICollection<Section> Sections { get; set; } 
    }
}
