﻿using FollowUp.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowUp.Domain.Entities
{
    public class Company:BaseEntity
    {
        public string CompanyName { get; set; }
        ICollection<Department> Departments { get; set; }

    }
}
