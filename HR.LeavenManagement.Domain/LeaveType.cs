using HR.LeavenManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeavenManagement.Domain
{
    public class LeaveType : BaseDomainEntiry
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
