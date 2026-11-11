using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoteel_Room
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int age, nights, guests;

            // check name
            if (name == "")
            {
                MessageBox.Show("Status: REJECTED\n\nPlease enter guest name.");
                txtName.Focus();
                return;
            }

            // check numbers
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Status: REJECTED\n\nPlease enter a valid age.");
                txtAge.Focus();
                return;
            }

            if (!int.TryParse(txtNights.Text, out nights))
            {
                MessageBox.Show("Status: REJECTED\n\nPlease enter a valid number of nights.");
                txtNights.Focus();
                return;
            }

            if (!int.TryParse(txtGuest.Text, out guests))
            {
                MessageBox.Show("Status: REJECTED\n\nPlease enter a valid number of guests.");
                txtGuest.Focus();
                return;
            }

            // age must be 18 or more
            if (age < 18)
            {
                MessageBox.Show("Status: REJECTED\n\nGuest must be 18 or older.");
                txtAge.Focus();
                return;
            }

            // nights 1 to 30
            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Status: REJECTED\n\nNumber of nights must be between 1 and 30.");
                txtNights.Focus();
                return;
            }

            // guests 1 to 6
            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Status: REJECTED\n\nNumber of guests must be between 1 and 6.");
                txtGuest.Focus();
                return;
            }

            // room type
            double price = 0;
            string room = "";
            int maxGuests = 0;

            if (rdoStandard.Checked)
            {
                price = 50;
                room = "Standard";
                maxGuests = 2;
            }
            else if (rdoNormal.Checked)
            {
                price = 80;
                room = "Normal";
                maxGuests = 4;
            }
            else if (rdoHight.Checked)
            {
                price = 120;
                room = "High";
                maxGuests = 6;
            }
            else
            {
                MessageBox.Show("Status: REJECTED\n\nPlease select a room type.");
                return;
            }

            // check max guests for the room
            if (guests > maxGuests)
            {
                MessageBox.Show("Status: REJECTED\n\n" + room + " room allows a maximum of " + maxGuests + " guests.");
                txtGuest.Focus();
                return;
            }

            // calculate cost
            double roomCost = price * nights;
            double breakfastCost = 0;

            // breakfast is $10 per guest per night
            if (chkBreakfast.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            // discount based on nights
            double discountRate = 0;

            if (nights >= 10)
            {
                discountRate = 0.12;   // 10 or more nights = 12%
            }
            else if (nights >= 5)
            {
                discountRate = 0.05;   // 5 to 9 nights = 5%
            }

            // additional 5% senior discount (age 60 or above)
            double seniorRate = 0;
            if (age >= 60)
            {
                seniorRate = 0.05;
            }

            double discount = roomCost * discountRate;
            double seniorDiscount = roomCost * seniorRate;

            double total = roomCost - discount - seniorDiscount + breakfastCost;

            // show result
            MessageBox.Show(
                "Status: APPROVED\n\n" +
                "Guest Name: " + name +
                "\nGuest Age: " + age +
                "\nRoom Type: " + room +
                "\nNumber of Nights: " + nights +
                "\nNumber of Guests: " + guests +
                "\nRoom Cost: $" + roomCost.ToString("0.00") +
                "\nBreakfast Cost: $" + breakfastCost.ToString("0.00") +
                "\nNights Discount (" + (discountRate * 100).ToString("0") + "%): -$" + discount.ToString("0.00") +
                "\nSenior Discount (" + (seniorRate * 100).ToString("0") + "%): -$" + seniorDiscount.ToString("0.00") +
                "\nTotal Price: $" + total.ToString("0.00"),
                "Booking Summary"
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtGuest.Clear();

            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;
            chkBreakfast.Checked = false;

            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}