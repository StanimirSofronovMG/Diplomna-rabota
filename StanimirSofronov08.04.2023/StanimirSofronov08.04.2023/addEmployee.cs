using BusinessLayer.Models;
using DataLayer;

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
    public partial class addEmployee : Form
    {
        private RestaurantContext? _context;
        public addEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userToAdd = new User
            {
                UserName = textBox1.Text,
                Password = textBox3.Text,
                RoleId=2
            };
            _context!.Users.Add(userToAdd);
            _context.SaveChanges(); 

            this.Hide();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = new RestaurantContext();

            _context.Database.EnsureCreated();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _context?.Dispose();
            _context = null;

        }
    }
}
