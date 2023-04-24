using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanimirSofronov08._04._2023
{
    public partial class ReportsForm : Form
    {
        private RestaurantContext _context;
        private string selectedUsername;

        public ReportsForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = new RestaurantContext();

            _context.Database.EnsureCreated();

            var users = _context.Users.Include(u => u.UserVacations).Select(u => u.UserName).ToArray();
            cbUsers.Items.AddRange(users);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _context?.Dispose();
            _context = null;
        }

        private void btnAllShifts_Click(object sender, EventArgs e)
        {
            // Get all shifts for a given user for the last month
            var user = _context.Users.First(u => u.UserName == selectedUsername);

            var filtered = _context.TableShifts.Include(ts => ts.Shift)
                .Where(ts => ts.UserId == user.UserId &&
                             ts.ShiftDate.Date >= dateTimePickerFrom.Value.Date &&
                             ts.ShiftDate.Date <= dateTimePickerTo.Value.Date).ToList();

            var result = filtered.Select(x =>
            $"- {x.ShiftDate.Date} | {x.TableId} | {x.Shift.Description} | {x.Shift.Payrate * 6} | {x.Late.ToString()} | {x.MissedShift} "
            ).ToArray();

            listBoxResult.Items.Clear();
            listBoxResult.Items.Add("   Date   | Table | Shift | Earned | WasLate | MissedShift");
            listBoxResult.Items.AddRange(result);
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUsername = cbUsers.SelectedItem.ToString();
        }
    }
}
