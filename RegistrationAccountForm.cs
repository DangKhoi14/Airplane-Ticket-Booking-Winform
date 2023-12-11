using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketBookingWindowForm
{
    public partial class RegistrationAccountForm : Form
    {
        string StartupPath;
        string AvatarPath;
        LoginForm ParentForm;

        public RegistrationAccountForm()
        {
            InitializeComponent();
            StartupPath = LoginForm.OriginalForm.StartupPath;
            ParentForm = LoginForm.OriginalForm;
        }

        private void RegistrationAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerPassPort.Clear();
            txtCustomerNationality.Clear();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            User obj = new User();
            Customer objCustomer = new Customer();

            if (txtUserName.Text.Trim().Length == 0 ||
                txtPassword.Text.Trim().Length == 0 ||
                txtCustomerName.Text.Trim().Length == 0)
            {
                MessageBox.Show("User name, Password and Full name can be blank !", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("You confirm wrong password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            User SpecificOne = ParentForm.UserList.Find(x => (x.UserName == txtUserName.Text) && (x.Password == txtPassword.Text));
            if (SpecificOne != null)
            {
                MessageBox.Show("User name is existed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (rdbCertify.Checked)
            {
                obj.UserName = txtUserName.Text;
                obj.Password = txtPassword.Text;

                objCustomer.CustomerName = txtCustomerName.Text;
                objCustomer.Birthday = dteBirthday.Value;
                objCustomer.Avatar = picCustomerAvatar.Image;
                objCustomer.PassPortNbr = txtCustomerPassPort.Text;
                objCustomer.Nationality = txtCustomerNationality.Text;

                ParentForm.UserList.Add(obj);
                ParentForm.CustomerList.Add(objCustomer);

                MessageBox.Show("Account Created !", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                new LoginForm().Show();
                this.Hide();
            }
            else
                MessageBox.Show("You must certify that you provided true infomation.", "Certify Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(RegistrationAccountForm));
            picCustomerAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picCustomerAvatar.Image")));
            picCustomerAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Title = "Find Avatar Images";
            openFileDlg.Filter = "JPG file|*.jpg";
            openFileDlg.InitialDirectory = StartupPath;

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                AvatarPath = openFileDlg.FileName;
                picCustomerAvatar.Image = Image.FromFile(AvatarPath);

                StartupPath = Path.GetDirectoryName(AvatarPath);
                picCustomerAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
