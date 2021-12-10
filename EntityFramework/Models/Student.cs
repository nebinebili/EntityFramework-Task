using EntityFramework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Student:BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public short SchoolNumber { get; set; }

        public Gender Gender { get; set; }

        public DateTime BirthDay { get; set; }

        public string PhonenUmber { get; set; }

        public virtual List<Operation> Operations { get; set; }
    }
}
