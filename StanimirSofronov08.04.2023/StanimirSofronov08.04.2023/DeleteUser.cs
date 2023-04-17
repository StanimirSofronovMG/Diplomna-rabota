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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StanimirSofronov08._04._2023
{
    public partial class DeleteUser : Form
    {
        private RestaurantContext _context;
        public DeleteUser()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = new RestaurantContext();

            _context.Database.EnsureCreated();

            //////////////////////////////////////////////////////  




            var users = _context.Users.Include(u => u.UserVacations)
                   //.Where(u => u.RoleId==2)
                   .Select(u => u.UserName).ToArray();

            SelectDelete.Items.AddRange(users);


        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _context?.Dispose();
            _context = null;

        }

        private void SelectDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();        
        }
    }
}
