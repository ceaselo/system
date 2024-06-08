﻿    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace BillingSystemDesgin
{
    public partial class PaymentPage : Form
    {
        public int ContactNumber { get; set; }
        public string ContactPassword { get; set; }
        private string connectionString = "Data Source=LAPTOP-B4PH2BDG\\SQLEXPRESS;Initial Catalog=Register;Integrated Security=True;Encrypt=False;";

        public PaymentPage()
        {
            InitializeComponent();
        }


        public void SetContactName()
        {
            label3.Text = GetContactName(ContactNumber, ContactPassword);
        }

        private string GetContactName(int contactNumber, string contactPassword)
        {
            string query = "SELECT contact_name FROM Registration WHERE contact_number = @ContactNumber AND contact_password = @ContactPassword";
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
                            return null;
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

        private void button3_Click(object sender, EventArgs e)
        {
            InternetForm internetForm = new InternetForm();
            internetForm.ContactNumber = ContactNumber;
            internetForm.ContactPassword = ContactPassword.ToString();
            internetForm.ContactName = GetContactName(ContactNumber, ContactPassword);
            internetForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElectricalForm electricalForm = new ElectricalForm();
            electricalForm.ContactNumber = ContactNumber;
            electricalForm.ContactPassword = ContactPassword;
            electricalForm.ContactName = GetContactName(ContactNumber, ContactPassword);
            electricalForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WaterForm waterForm = new WaterForm();
            waterForm.ContactNumber = ContactNumber;
            waterForm.ContactPassword = ContactPassword;
            waterForm.ContactName = GetContactName(ContactNumber, ContactPassword); 
            waterForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        internal void SetElectricBill()
        {
            throw new NotImplementedException();
        }
    }
}