﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class FormforgetPassword : Form
    {
        public FormforgetPassword()
        {
            InitializeComponent();
        }

        private void label1titleusername_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormforgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void button2guest_Click(object sender, EventArgs e)
        {
            if (label1titleusername.Text.Trim() == "12345-6789123-4" && dateTimePickerDOB.Text == "Saturday, January 1, 2000")
            {
                this.Close();
                FormNewPassword fnp = new FormNewPassword();
                fnp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid CNIC or DOB!", "Failed Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
