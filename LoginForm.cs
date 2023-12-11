using System.Drawing;
//CMT
namespace AirTicketBookingWindowForm
{
    public partial class LoginForm : Form
    {
        public static LoginForm OriginalForm;
        public List<Customer> CustomerList;
        public List<User> UserList;
        public List<FlightInfo> FlightInfoList;
        public List<FlightRegistration> FlightRegistrations;
        public string StartupPath;
        public bool ResetLogin;

        public LoginForm()
        {
            InitializeComponent();
            OriginalForm = this;
            StartupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            CustomerList = new List<Customer>();
            //CustomerList.Add(new Customer("Dora", DateTime.Now, Image.FromFile(StartupPath + "\\Images\\Doraemon.jpg"), "TestPP", "TestNationality"));
            UserList = new List<User>();
            UserList.Add(new User("Testing", "Testing"));

            FlightInfoList = new List<FlightInfo>();
            FlightInfoList.Add(new FlightInfo("HCM", "HN", DateTime.Now.AddHours(10), DateTime.Now.AddHours(12), "Timberland Airline"));

            ResetLogin = true;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter user name !", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter password !", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }

            User SpecificOne = UserList.Find(x => (x.UserName == txtUserName.Text) && (x.Password == txtPassword.Text));
            if (SpecificOne == null)
            {
                MessageBox.Show("Username and Password are not exist. \nPlease reinput or register a new one.",
                    "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Clear();
                txtPassword.Focus();
            }
            else
            {
                AirTicketBooking obj = new AirTicketBooking();
                User currentUser = UserList.Find(x => (x.UserName == txtUserName.Text) && (x.Password == txtPassword.Text));
                //obj.SetCurrentUser(currentUser);
                this.Hide();
                obj.Show();
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
