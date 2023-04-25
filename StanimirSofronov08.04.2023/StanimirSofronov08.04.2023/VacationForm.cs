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
    public partial class VacationForm : Form
    {
        private RestaurantContext _context;
        private string selectedUsername;

        public VacationForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = new RestaurantContext();
            _context.Database.EnsureCreated();

            var users = _context.Users.Include(u => u.UserVacations).Select(u => u.UserName).ToArray();
            cbUsersVacation.Items.AddRange(users);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _context?.Dispose();
            _context = null;
        }
        private void cbUsersVacation_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUsername = cbUsersVacation.SelectedItem.ToString();

            var user = _context.Users.First(u => u.UserName == selectedUsername);
            var vacations = _context.UserVacations.Where(uv => uv.UserId == user.UserId)
                .Select(uv => $" {uv.StartDate}  |  {uv.EndDate}  |  {(uv.IsPaidLeave ? "Да" : "Не")}  ").ToArray();

            listBoxVacation.Items.Clear();
            listBoxVacation.Items.Add("   StartDate   |  EndDate  | IsPaid ");
            listBoxVacation.Items.AddRange(vacations);
        }

        private void btnVacation_Click(object sender, EventArgs e)
        {
            if (selectedUsername == null)
            {
                MessageBox.Show("choose user");
                return;
            }

            var user = _context.Users.First(u => u.UserName == selectedUsername);
            var from = dateTimePickerFrom.Value.Date;
            var to = dateTimePickerTo.Value.Date;

            var vacationExists = _context.UserVacations.Any(uv =>
                                                            uv.UserId == user.UserId &&
                                                            ((from >= uv.StartDate && from <= uv.EndDate) ||
                                                            (to >= uv.StartDate && to <= uv.EndDate)));
            //-----------------------------------------------------------------------------

            if (vacationExists)
            {
                MessageBox.Show("already have such vacation");
                return;
            }


            var vacationEntity = new UserVacation
            {
                UserId = user.UserId,
                IsPaidLeave = checkBoxVacation.Checked,
                StartDate = from,
                EndDate = to
            };

            _context.UserVacations.Add(vacationEntity);
            _context.SaveChanges();

            listBoxVacation.Items.Add($" {from}  |  {to}  |  {(vacationEntity.IsPaidLeave ? "Да" : "Не")}  ");
        }

    }
}
