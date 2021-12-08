using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryEntity.Models
{
    public class Operation : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Key, Column(Order = 1)]
        public int StudentId { get; set; }

        [Key, Column(Order = 2)]
        public int BookId { get; set; }

        public Student Student { get; set; }
        public Book Book { get; set; }
    }
}
