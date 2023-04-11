using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{ 
    public partial class Table
    {
        public Table()
        {
            TableShifts = new HashSet<TableShift>();
        }

        public int TableId { get; set; }

        public int SeatCount { get; set; }
        
        public bool IsInside { get; set; }

        public virtual ICollection<TableShift> TableShifts { get; set; }
    }
}
