﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentFormSystem
{
    public partial class PaymentMethod : Form
    {
        private List<PaymentMethod> paymentMethods;
        public PaymentMethod()
        {
            InitializeComponent();
            paymentMethods = new List<PaymentMethod>();
            InitializeDataGridView();
            RefreshPaymentMethods();

        }
        private void InitializeDataGridView()
        {
            dataGridViewPaymentMethods.Columns.Clear();
            dataGridViewPaymentMethods.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Payment Method ID", Name = "PaymentMethodId" });
            dataGridViewPaymentMethods.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Method Name", Name = "MethodName" });
        }

        private void RefreshPaymentMethods()
        {
            dataGridViewPaymentMethods.Rows.Clear();
            foreach (var paymentMethod in paymentMethods)
            {
                dataGridViewPaymentMethods.Rows.Add(paymentMethod.PaymentMethodId, paymentMethod.MethodName);
            }
        }

        private void AddButton_Click(object sender, EventArgs e, PaymentMeethod newPaymentMethod)
        {
            int paymentMethodId = paymentMethods.Count + 1;
            string methodName = PaymentMethodTextBox.Text;
            var newPaymentMethod = new PaymentMethod(paymentMethodId, methodName);
            paymentMethods.Add(newPaymentMethod);
            RefreshPaymentMethods();
            PaymentMethodTextBox.Clear();
        }

        private void EditButton_Click(object sender, EventArgs e, DataGridViewTextBoxColumn methodName)
        {
            if (dataGridViewPaymentMethods.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridViewPaymentMethods.SelectedRows[0].Index;
                string methodName = PaymentMethodTextBox.Text;

                paymentMethods[selectedIndex].MethodName = methodName;
                RefreshPaymentMethods();
                PaymentMethodTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please select a payment method to edit.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewPaymentMethods.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridViewPaymentMethods.SelectedRows[0].Index;
                paymentMethods.RemoveAt(selectedIndex);
                RefreshPaymentMethods();
            }
            else
            {
                MessageBox.Show("Please select a payment method to delete.");
            }
        }

        private void PaymentMethodTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public class PaymentMeethod
        {
            public int PaymentMethodId { get; set; }
            public string MethodName { get; set; }
            public PaymentMeethod(int paymentMethodId, string methodName)
            {
                PaymentMethodId = paymentMethodId;
                MethodName = methodName;
            }
        }
    }
}
