using FollowUp.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowUp.Domain.Entities
{
    public class Person :BaseEntity
    {
        public string PersonName { get; set; }
        public int PersonSurname { get; set; }

    }
}
