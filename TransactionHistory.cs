using System;
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
    public partial class TransactionHistory : Form
    {
        private DataGridView dataGridViewTransactions;
        private TextBox searchTextBox;
        private ComboBox typeComboBox;
        private DateTimePicker fromDatePicker;
        private DateTimePicker toDatePicker;
        private Button searchButton;
        private Button exportButton;
        private Button refreshButton;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        public TransactionHistory()
        {
            InitializeControls();
            InitializeComponent();
        }

        private void InitializeControls()
        {
            // Top Section - Filters
            GroupBox groupBoxFilters = new GroupBox
            {
                Text = "Filters",
                Dock = DockStyle.Top
            };

            typeComboBox = new ComboBox
            {
                Dock = DockStyle.Top,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            typeComboBox.Items.AddRange(new string[] { "All", "Credit", "Debit" });
            groupBoxFilters.Controls.Add(new Label { Text = "Transaction Type:", Dock = DockStyle.Top });
            groupBoxFilters.Controls.Add(typeComboBox);

            fromDatePicker = new DateTimePicker
            {
                Dock = DockStyle.Top,
                Format = DateTimePickerFormat.Short
            };
            groupBoxFilters.Controls.Add(new Label { Text = "From Date:", Dock = DockStyle.Top });
            groupBoxFilters.Controls.Add(fromDatePicker);

            toDatePicker = new DateTimePicker
            {
                Dock = DockStyle.Top,
                Format = DateTimePickerFormat.Short
            };
            groupBoxFilters.Controls.Add(new Label { Text = "To Date:", Dock = DockStyle.Top });
            groupBoxFilters.Controls.Add(toDatePicker);

            searchTextBox = new TextBox
            {
                PlaceholderText = "Search...",
                Dock = DockStyle.Top
            };
            groupBoxFilters.Controls.Add(new Label { Text = "Search:", Dock = DockStyle.Top });
            groupBoxFilters.Controls.Add(searchTextBox);

            searchButton = new Button
            {
                Text = "Search",
                Dock = DockStyle.Top
            };
            groupBoxFilters.Controls.Add(searchButton);

            // Middle Section - DataGridView
            dataGridViewTransactions = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dataGridViewTransactions.Columns.Add("TransactionID", "Transaction ID");
            dataGridViewTransactions.Columns.Add("Date", "Date");
            dataGridViewTransactions.Columns.Add("Description", "Description");
            dataGridViewTransactions.Columns.Add("Amount", "Amount");
            dataGridViewTransactions.Columns.Add("Type", "Type");
            dataGridViewTransactions.Columns.Add("Balance", "Balance");

            // Bottom Section - Buttons and StatusStrip
            Button exportButton = new Button
            {
                Text = "Export",
                Dock = DockStyle.Left
            };

            Button refreshButton = new Button
            {
                Text = "Refresh",
                Dock = DockStyle.Left
            };

            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel
            {
                Text = "Ready"
            };
            statusStrip.Items.Add(statusLabel);

            // Add controls to form
            Controls.Add(dataGridViewTransactions);
            Controls.Add(groupBoxFilters);
            Controls.Add(exportButton);
            Controls.Add(refreshButton);
            Controls.Add(statusStrip);

            // Event handlers
            searchButton.Click += SearchButton_Click;
            exportButton.Click += ExportButton_Click;
            refreshButton.Click += RefreshButton_Click;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Searching...";
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Exporting...";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Exporting...";
        }
    }
}
