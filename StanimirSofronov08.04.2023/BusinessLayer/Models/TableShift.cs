using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.Models
{
    public partial class TableShift
    {
        [Key]
        public int TableId { get; set; }

        [Key]
        public int ShiftId { get; set; }

        [Key]
        public DateTime ShiftDate { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public User User { get; set; }

        public bool Late { get; set; }

        public bool MissedShift { get; set; }

    }
}
