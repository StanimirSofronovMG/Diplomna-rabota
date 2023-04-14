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
    public partial class Form2 : Form
    {

        private bool isAdmin;
        private RestaurantContext _context;

        public Form2(bool is_Admin)
        {
            InitializeComponent();
            this.isAdmin = is_Admin;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Visible = true;

        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
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
