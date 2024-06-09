﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentFormSystem
{
    public partial class ElectricBill : Form
    {
        public int ContactNumber { get; set; }
        public string ContactPassword { get; set; }
        public string ContactName { get; set; }
        private string connectionString = "Data Source=DESKTOP-TU0VOQH\\SQLEXPRESS;Initial Catalog=Register;Integrated Security=True";
        public ElectricBill()
        {
            InitializeComponent();
            this.Load += ElectricalForm_Load;
        }

        public void SetElectricBill()
        {
            DefaultLabel.Text = GetElectricBill(ContactNumber, ContactPassword);
        }

        private string GetElectricBill(int contactNumber, string contactPassword)
        {
            string query = "SELECT electric_bill FROM Registration WHERE contact_number = @ContactNumber AND contact_password = @ContactPassword";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        command.Parameters.AddWithValue("@ContactPassword", contactPassword);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            return "Bill not found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Payments paymentPage = new Payments();
            paymentPage.ContactNumber = ContactNumber;
            paymentPage.ContactPassword = ContactPassword;
            paymentPage.SetContactName();
            paymentPage.Show();
            this.Close();
        }

        private void ElectricalForm_Load(object sender, EventArgs e)
        {
            SetElectricBill();
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
