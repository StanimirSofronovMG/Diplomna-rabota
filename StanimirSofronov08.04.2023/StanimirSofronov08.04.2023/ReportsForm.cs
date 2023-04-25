using BusinessLayer.Models;
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
        private const int HoursPerShift = 8;
        private const int MaxHoursPerMonth = 160;

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

        private void btnTotalHours_Click(object sender, EventArgs e)
        {
            var user = _context.Users.First(u => u.UserName == selectedUsername);
            var from = dateTimePickerFrom.Value.Month;
            var to = dateTimePickerTo.Value.Month;
            var monthsCount = (to - from) + 1;
            var filteredFinal = new List<TableShift>();

            var filteredByUser = _context.TableShifts.Include(ts => ts.Shift)
                .Where(ts => ts.UserId == user.UserId &&
                             ts.ShiftDate.Date.Month >= from &&
                             ts.ShiftDate.Date.Month <= to).ToList();

            listBoxResult.Items.Clear();
            listBoxResult.Items.Add("   Месец | Взети смени | Взети часове  | Извънреден труд ");

            for (int i = 0; i < monthsCount; i++)
            {
                var filteredByMonth = filteredByUser.Where(x => x.ShiftDate.Date.Month == from + i);
                var shifts = filteredByMonth.Count();
                var hours = shifts * HoursPerShift;
                var overtime = 0;
                if (hours > MaxHoursPerMonth) { overtime = hours - MaxHoursPerMonth; }
                listBoxResult.Items.Add($" {from + i}  |  {shifts}  |  {hours}  |  {overtime}");
            }


            //var result = filteredFinal.Select(x =>
            //$"- {x.ShiftDate.Date} | {x.TableId} | {x.Shift.Description} | {x.Shift.Payrate * 6} | {x.Late.ToString()} | {x.MissedShift} "
            //).ToArray();

            //listBoxResult.Items.Clear();
            //listBoxResult.Items.Add("   Месец | Взети смени | Взети часове  | Извънреден труд ");
            //listBoxResult.Items.AddRange(result);
        }
    }
}
