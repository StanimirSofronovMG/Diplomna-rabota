using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public partial class Shift
    {
        public Shift()
        {
            TableShifts = new HashSet<TableShift>();
        }

        public int ShiftId { get; set; }

        public string Description { get; set; } = string.Empty;

        public double Payrate { get; set; }

        public virtual ICollection<TableShift> TableShifts { get; set; }
    }
}
