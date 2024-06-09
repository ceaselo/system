namespace PaymentFormSystem
{
    partial class TransactionHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ExportButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelToDate = new System.Windows.Forms.Label();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewDetails = new System.Windows.Forms.ToolStrip();
            this.menuItemEditTransaction = new System.Windows.Forms.ToolStrip();
            this.menuItemDeleteTransaction = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionID,
            this.Date,
            this.Description,
            this.Amount,
            this.Type,
            this.Balance});
            this.dataGridView1.Location = new System.Drawing.Point(105, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "Transaction ID";
            this.TransactionID.Name = "TransactionID";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(105, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 26);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 26);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(105, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // ExportButton
            // 
            this.ExportButton.AllowDrop = true;
            this.ExportButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(528, 98);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(71, 32);
            this.ExportButton.TabIndex = 5;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.AllowDrop = true;
            this.RefreshButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(528, 151);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(71, 32);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.AllowDrop = true;
            this.SearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(285, 186);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(71, 32);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(853, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailsToolStripMenuItem,
            this.editTransactionToolStripMenuItem,
            this.deleteTransactionToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(171, 70);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(12, 41);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(62, 18);
            this.labelSearch.TabIndex = 12;
            this.labelSearch.Text = "Search:";
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromDate.Location = new System.Drawing.Point(12, 112);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(87, 18);
            this.labelFromDate.TabIndex = 13;
            this.labelFromDate.Text = "From Date:";
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToDate.Location = new System.Drawing.Point(12, 151);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(66, 18);
            this.labelToDate.TabIndex = 14;
            this.labelToDate.Text = "To Date:";
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.textBox1);
            this.groupBoxFilters.Controls.Add(this.dateTimePicker1);
            this.groupBoxFilters.Controls.Add(this.comboBox1);
            this.groupBoxFilters.Controls.Add(this.labelToDate);
            this.groupBoxFilters.Controls.Add(this.dateTimePicker2);
            this.groupBoxFilters.Controls.Add(this.SearchButton);
            this.groupBoxFilters.Controls.Add(this.labelFromDate);
            this.groupBoxFilters.Controls.Add(this.labelSearch);
            this.groupBoxFilters.Location = new System.Drawing.Point(105, 53);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(397, 237);
            this.groupBoxFilters.TabIndex = 15;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            // 
            // editTransactionToolStripMenuItem
            // 
            this.editTransactionToolStripMenuItem.Name = "editTransactionToolStripMenuItem";
            this.editTransactionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.editTransactionToolStripMenuItem.Text = "Edit Transaction";
            // 
            // deleteTransactionToolStripMenuItem
            // 
            this.deleteTransactionToolStripMenuItem.Name = "deleteTransactionToolStripMenuItem";
            this.deleteTransactionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.deleteTransactionToolStripMenuItem.Text = "Delete Transaction";
            // 
            // menuItemViewDetails
            // 
            this.menuItemViewDetails.Location = new System.Drawing.Point(0, 0);
            this.menuItemViewDetails.Name = "menuItemViewDetails";
            this.menuItemViewDetails.Size = new System.Drawing.Size(853, 25);
            this.menuItemViewDetails.TabIndex = 16;
            this.menuItemViewDetails.Text = "toolStrip1";
            // 
            // menuItemEditTransaction
            // 
            this.menuItemEditTransaction.Location = new System.Drawing.Point(0, 25);
            this.menuItemEditTransaction.Name = "menuItemEditTransaction";
            this.menuItemEditTransaction.Size = new System.Drawing.Size(853, 25);
            this.menuItemEditTransaction.TabIndex = 17;
            this.menuItemEditTransaction.Text = "toolStrip1";
            // 
            // menuItemDeleteTransaction
            // 
            this.menuItemDeleteTransaction.Location = new System.Drawing.Point(0, 50);
            this.menuItemDeleteTransaction.Name = "menuItemDeleteTransaction";
            this.menuItemDeleteTransaction.Size = new System.Drawing.Size(853, 25);
            this.menuItemDeleteTransaction.TabIndex = 18;
            this.menuItemDeleteTransaction.Text = "toolStrip1";
            // 
            // TransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 554);
            this.Controls.Add(this.menuItemDeleteTransaction);
            this.Controls.Add(this.menuItemEditTransaction);
            this.Controls.Add(this.menuItemViewDetails);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ExportButton);
            this.Name = "TransactionHistory";
            this.Text = "TransactionHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStrip menuItemViewDetails;
        private System.Windows.Forms.ToolStrip menuItemEditTransaction;
        private System.Windows.Forms.ToolStrip menuItemDeleteTransaction;
    }
}