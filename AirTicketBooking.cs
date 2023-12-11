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
        const int ticketcost = 2000000;
        const double EconomyPrice = 1.0;
        const double PremiumEconomyPrice = 1.6;
        const double BussinessPrice = 5.0;
        const double FirstPrice = 17.0;
        int EconomyTotalCost = 0;
        int PremiumEconomyTotalCost = 0;
        int BussinessTotalCost = 0;
        int FirstTotalCost = 0;
        int TOTAL_COST = 0;
        LoginForm ParentForm;
        public Customer currentCustomer;
        public User currentUser;
        public int idxRegistration;
        string strRegistration;
        List<FlightInfo> flights = new List<FlightInfo>
        {
            new FlightInfo("HCM", "HN", DateTime.Now.AddHours(10), DateTime.Now.AddHours(12), "VN Airline"),
            new FlightInfo("DN", "HCM", DateTime.Now.AddHours(17), DateTime.Now.AddHours(18), "Bamboo Airline"),
            new FlightInfo("HN", "Kwang Chou", DateTime.Now.AddHours(21), DateTime.Now.AddHours(22.34), "Timerland Airline"),
            new FlightInfo("DCM", "Dalat", DateTime.Now.AddHours(22), DateTime.Now.AddHours(23), "Timerland Airline"),
        };

        public AirTicketBooking()
        {
            InitializeComponent();
            ParentForm = LoginForm.OriginalForm;
            ShowRegistration();
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
            ParentForm.ResetLogin = true;
            this.Close();
            ParentForm.Show();
        }

        private void TotalCost()
        {
            TOTAL_COST = EconomyTotalCost +
                PremiumEconomyTotalCost +
                BussinessTotalCost + FirstTotalCost;
        }

        private void UpdateEconomyTotalCost()
        {
            EconomyTotalCost = (int)(nudEconomy.Value * (decimal)ticketcost * (decimal)EconomyPrice);
            TotalCost();
        }

        private void UpdatePremiumEconomyTotalCost()
        {
            PremiumEconomyTotalCost = (int)(nudPremiumEconomy.Value * (decimal)ticketcost * (decimal)PremiumEconomyPrice);
            TotalCost();
        }

        private void UpdateBussinessTotalCost()
        {
            BussinessTotalCost = (int)(nudBussiness.Value * (decimal)ticketcost * (decimal)BussinessPrice);
            TotalCost();
        }

        private void UpdateFirstTotalCost()
        {
            FirstTotalCost = (int)(nudFirst.Value * (decimal)ticketcost * (decimal)FirstPrice);
            TotalCost();
        }

        private void nudEconomy_ValueChanged(object sender, EventArgs e)
        {
            UpdateEconomyTotalCost();
        }

        private void nudPremiumEconomy_ValueChanged(object sender, EventArgs e)
        {
            UpdatePremiumEconomyTotalCost();
        }

        private void nudBussiness_ValueChanged(object sender, EventArgs e)
        {
            UpdateBussinessTotalCost();
        }

        private void nudFirst_ValueChanged(object sender, EventArgs e)
        {
            UpdateFirstTotalCost();
        }

        public string ShowRegistration()
        {
            strRegistration = "\t\t\t Flights List\n";
            strRegistration += "_______________________________________________________________\n";

            foreach (FlightInfo flight in flights)
            {
                strRegistration += $"ID: {flight.FlightID}, " +
                    $"From: {flight.Start}, " +
                    $"To: {flight.Goal}, " +
                    $"Departure Time: {flight.TimeDepart}, " +
                    $"Arrival Time: {flight.TimeArrival} " +
                    $"--- by {flight.FlightType}\n";
            }

            rtxRegistrationInfo.Text = strRegistration;
            return strRegistration;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (TOTAL_COST == 0)
            {
                MessageBox.Show("Choose class before booking", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FlightInfo FlightTicket = flights.Find(x => (x.Start == txtFrom.Text) && (x.Goal == txtTo.Text));
            if (FlightTicket == null)
            {
                MessageBox.Show("Your route is currently unavailable", "Path not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show($"Your Ticket Information:\nFlight ID: {FlightTicket.FlightID}" +
                $"\nFrom: {txtFrom} To: {txtTo}\nYour ticket classes you booked:" +
                $"\nEconomy: {nudEconomy.Value}" +
                $"\nPremium Economy: {nudPremiumEconomy.Value}" +
                $"\nBussiness: {nudBussiness.Value}" +
                $"\nFirst: {nudFirst.Value}" +
                $"TOTAL COST: {TOTAL_COST} VND",
                "Booking succesfully !!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
