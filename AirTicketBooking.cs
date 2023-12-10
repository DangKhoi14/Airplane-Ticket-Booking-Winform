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
    public partial class AirTicketBooking : Form
    {
        public AirTicketBooking()
        {
            InitializeComponent();
        }

        private void AirTicketBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
