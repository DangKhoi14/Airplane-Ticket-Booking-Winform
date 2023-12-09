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
        public RegistrationAccountForm()
        {
            InitializeComponent();
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
            if (txtCustomerName.Text != "" && txtCustomerPassPort.Text != "" && txtCustomerNationality.Text != "")
            {
                if (rdbCertify.Checked)
                {
                    new AirTicketBooking().Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("You must certify that you provided true infomation !");
            }
            else
                MessageBox.Show("Something is missing !");
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
            //openFileDlg.Title = "Find Avatar Images";
            //openFileDlg.Filter = "JPG file|*.jpg";
        }
    }
}
