using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiApplicationTest.Dto
{
    public class WorkingDaysDto : DaysBaseDto
    {
        public string work_hours { get; set; }
        public string wages { get; set; }
    }
}
