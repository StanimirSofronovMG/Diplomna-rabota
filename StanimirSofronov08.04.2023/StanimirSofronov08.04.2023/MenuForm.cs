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
    public partial class MenuForm : Form
    {
        private RestaurantContext? _context;

        private bool isAdmin;

        public MenuForm(bool is_Admin)
        {
            InitializeComponent();
            this.isAdmin = is_Admin;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void добавянеНаСлужителToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new addEmployee().Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isAdmin == true)
            {
                new ReservationForm(true).Show();
            }
            else if (isAdmin == false)
            {
                new ReservationForm(false).Show();
            }
            this.Hide();
        }

        private void изберетеОпцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin == true)
            {
                добавянеНаСлужителToolStripMenuItem.Visible = true;
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            new SignInForm().Show();
            this.Hide();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            new ReportsForm().Show();
            this.Hide();
        }

        private void премахванеНаПотребителToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeleteUser().Show();

        }

        private void vacation_Click(object sender, EventArgs e)
        {
            new VacationForm().Show();
        }
    }
}
