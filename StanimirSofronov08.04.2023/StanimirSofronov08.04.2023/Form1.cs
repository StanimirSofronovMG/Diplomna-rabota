using DataLayer;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace StanimirSofronov08._04._2023
{
    public partial class Form1 : Form
    {
        private RestaurantContext? _context;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var userEntity = context.User.FirstOrDefault(user => user.Name == txtUsername.Text && user.Passwrod == txtPassword.Text)
            // userEntity = null -> not founbd in the db -> show error
            // userEntity not null -> ok continue

            var userEntity = _context!.Users.Include(u => u.Role)
                .FirstOrDefault(u => u.UserName == txtUsername.Text && u.Password == txtPassword.Text);
            
            if(userEntity == null)
            {
                MessageBox.Show("Потребителското име или паролата са грешни. Опитайте отново");
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else if (userEntity.Role.RoleName=="Admin")
            {
                new Form2(true).Show();
                this.Hide();
            }
            


         /*   if (txtUsername.Text == "Stanimir" && txtPassword.Text == "123456")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Потребителското име или паролата са грешни. Опитайте отново");
                txtUsername.Clear();
                txtPassword.Clear();
            }*/
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