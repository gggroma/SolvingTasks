using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiApplicationTest.Dto
{
    public class AnalyseDto
    {
        public DaysDto days { get; set; }
        public WorkingDaysDto working_days { get; set; }
        public DaysBaseDto weekend_days { get; set; }
        public object public_holidays { get; set; }
    }

}
