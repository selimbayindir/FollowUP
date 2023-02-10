using FollowUp.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowUp.Domain.Entities
{
    public class Section : BaseEntity
    {
        public string SectionName { get; set; }
        public Department Department { get; set; }
        ICollection<Person> Persons { get; set; }
    }
}
