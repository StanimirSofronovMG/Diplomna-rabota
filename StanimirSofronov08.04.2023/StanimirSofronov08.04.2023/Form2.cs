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
            var selectedUser = FirstTableFirstShiftBox.SelectedItem.ToString();
            AssignTableShift(1, 1, selectedUser!);


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUser = FirstTableSecondShiftBox.SelectedItem.ToString();
            AssignTableShift(1, 2, selectedUser!);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FirstTableFirstShiftBox.Visible = true;

            FirstTableSecondShiftBox.Visible = true;
        }



        private void AssignTableShift(int tableId, int shiftId, string selectedUser)
        {
            //firsShift
            var date = dateTimePicker1.Value.Date;

            var user = _context!.Users.Include(u => u.Role)
                .FirstOrDefault(u => u.UserName == selectedUser);
            var tableShift = new TableShift
            {
                TableId = tableId,
                ShiftId = shiftId,
                ShiftDate = date,
                UserId = user!.UserId
            };

            var existing = _context.TableShifts.FirstOrDefault(ts =>
                 ts.TableId == tableShift.TableId &&
                 ts.ShiftId == tableShift.ShiftId &&
                 ts.ShiftDate == date
                 );
            if (existing != null)
            {
                _context.TableShifts.Remove(existing);
            }
            _context.TableShifts.Add(tableShift);
            _context.SaveChanges();


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

            FirstTableFirstShiftBox.Items.AddRange(users);
            FirstTableSecondShiftBox.Items.AddRange(users);

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _context?.Dispose();
            _context = null;

        }



        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (isAdmin == true)
            {
                new Form3(true).Show();
                this.Hide();
            }
            else if (isAdmin == false)
            {
                new Form3(false).Show();
                this.Hide();
            }
        }

        private void BothShiftForDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
