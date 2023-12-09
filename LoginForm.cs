using System.Drawing;
//CMT
namespace AirTicketBookingWindowForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "TestingUserName" && txtPassword.Text == "TestingPassword")
            {
                new AirTicketBooking().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User Name or Password is incorrect, try again!");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.PasswordChar = '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new RegistrationAccountForm().Show();
            this.Hide();
        }
    }
}
