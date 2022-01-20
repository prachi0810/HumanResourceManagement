using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HumanResourceList.Models
{
    public class HumanReasourceList
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string DepartmentName { get; set; }
        public string Status { get; set; }
        public int EmpNo { get; set; }
    }

    public class HumanReasourceDBContext:DbContext
    {
        public DbSet<HumanReasourceList> HumanResource { get; set; }
    }
}