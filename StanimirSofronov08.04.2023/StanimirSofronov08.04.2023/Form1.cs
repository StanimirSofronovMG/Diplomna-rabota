namespace StanimirSofronov08._04._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var userEntity = context.User.FirstOrDefault(user => user.Name == txtUsername.Text && user.Passwrod == txtPassword.Text)
            // userEntity = null -> not founbd in the db -> show error
            // userEntity not null -> ok continue


            if (txtUsername.Text=="Stanimir" && txtPassword.Text=="123456" )
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("��������������� ��� ��� �������� �� ������. �������� ������");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}