using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Operation:BaseEntity
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        //[Key,Column(Order =1) ]
        public int StudentId { get; set; }

       // [Key, Column(Order = 2)]
        public int BookId { get; set; }


        public virtual Student Student { get; set; }

        public virtual Book Book { get; set; }
    }
}
