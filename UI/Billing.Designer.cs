namespace demo3
{
    partial class Billing
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
            this.panelBilling = new System.Windows.Forms.Panel();
            this.lblCrossbtn = new System.Windows.Forms.Label();
            this.lblBilling = new System.Windows.Forms.Label();
            this.dgvItemDisplay = new System.Windows.Forms.DataGridView();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustContact = new System.Windows.Forms.TextBox();
            this.lblCustContact = new System.Windows.Forms.Label();
            this.lblItemDetails = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemNam = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtQtn = new System.Windows.Forms.TextBox();
            this.lblQnt = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblGTotal = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBilling
            // 
            this.panelBilling.BackColor = System.Drawing.Color.Navy;
            this.panelBilling.Controls.Add(this.lblCrossbtn);
            this.panelBilling.Controls.Add(this.lblBilling);
            this.panelBilling.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBilling.Location = new System.Drawing.Point(0, 0);
            this.panelBilling.Name = "panelBilling";
            this.panelBilling.Size = new System.Drawing.Size(1308, 124);
            this.panelBilling.TabIndex = 0;
            // 
            // lblCrossbtn
            // 
            this.lblCrossbtn.AutoSize = true;
            this.lblCrossbtn.BackColor = System.Drawing.Color.Navy;
            this.lblCrossbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCrossbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrossbtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCrossbtn.Location = new System.Drawing.Point(1264, 0);
            this.lblCrossbtn.Name = "lblCrossbtn";
            this.lblCrossbtn.Size = new System.Drawing.Size(41, 46);
            this.lblCrossbtn.TabIndex = 1;
            this.lblCrossbtn.Text = "x";
            this.lblCrossbtn.Click += new System.EventHandler(this.lblCrossbtm_Click);
            // 
            // lblBilling
            // 
            this.lblBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBilling.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilling.ForeColor = System.Drawing.Color.White;
            this.lblBilling.Location = new System.Drawing.Point(0, 0);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(1308, 124);
            this.lblBilling.TabIndex = 0;
            this.lblBilling.Text = "Billing";
            this.lblBilling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvItemDisplay
            // 
            this.dgvItemDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemDisplay.Location = new System.Drawing.Point(18, 360);
            this.dgvItemDisplay.Name = "dgvItemDisplay";
            this.dgvItemDisplay.RowHeadersWidth = 62;
            this.dgvItemDisplay.RowTemplate.Height = 28;
            this.dgvItemDisplay.Size = new System.Drawing.Size(693, 313);
            this.dgvItemDisplay.TabIndex = 26;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(12, 141);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(247, 32);
            this.lblCustomer.TabIndex = 27;
            this.lblCustomer.Text = "Customer Details";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(17, 184);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(78, 29);
            this.lblCustName.TabIndex = 28;
            this.lblCustName.Text = "Name";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(122, 184);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(232, 32);
            this.txtCustName.TabIndex = 29;
            // 
            // txtCustContact
            // 
            this.txtCustContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustContact.Location = new System.Drawing.Point(498, 184);
            this.txtCustContact.Name = "txtCustContact";
            this.txtCustContact.Size = new System.Drawing.Size(154, 32);
            this.txtCustContact.TabIndex = 31;
            // 
            // lblCustContact
            // 
            this.lblCustContact.AutoSize = true;
            this.lblCustContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustContact.Location = new System.Drawing.Point(393, 184);
            this.lblCustContact.Name = "lblCustContact";
            this.lblCustContact.Size = new System.Drawing.Size(94, 29);
            this.lblCustContact.TabIndex = 30;
            this.lblCustContact.Text = "Contact";
            // 
            // lblItemDetails
            // 
            this.lblItemDetails.AutoSize = true;
            this.lblItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDetails.Location = new System.Drawing.Point(12, 245);
            this.lblItemDetails.Name = "lblItemDetails";
            this.lblItemDetails.Size = new System.Drawing.Size(175, 32);
            this.lblItemDetails.TabIndex = 32;
            this.lblItemDetails.Text = "Item Details";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(398, 289);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(154, 32);
            this.txtItemName.TabIndex = 36;
            // 
            // lblItemNam
            // 
            this.lblItemNam.AutoSize = true;
            this.lblItemNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNam.Location = new System.Drawing.Point(314, 289);
            this.lblItemNam.Name = "lblItemNam";
            this.lblItemNam.Size = new System.Drawing.Size(78, 29);
            this.lblItemNam.TabIndex = 35;
            this.lblItemNam.Text = "Name";
            // 
            // txtItemID
            // 
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(111, 289);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(154, 32);
            this.txtItemID.TabIndex = 34;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemId.Location = new System.Drawing.Point(17, 289);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(88, 29);
            this.lblItemId.TabIndex = 33;
            this.lblItemId.Text = "Item ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1024, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 32);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(937, 187);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 29);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "Date";
            // 
            // txtQtn
            // 
            this.txtQtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtn.Location = new System.Drawing.Point(691, 289);
            this.txtQtn.Name = "txtQtn";
            this.txtQtn.Size = new System.Drawing.Size(106, 32);
            this.txtQtn.TabIndex = 40;
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQnt.Location = new System.Drawing.Point(585, 289);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(100, 29);
            this.lblQnt.TabIndex = 39;
            this.lblQnt.Text = "Quantity";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(906, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 32);
            this.textBox2.TabIndex = 42;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(837, 289);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(63, 29);
            this.lblRate.TabIndex = 41;
            this.lblRate.Text = "Rate";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1087, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 43);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(906, 395);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(94, 32);
            this.txtDiscount.TabIndex = 45;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(743, 396);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(150, 29);
            this.lblDiscount.TabIndex = 44;
            this.lblDiscount.Text = "Discount (%)";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(906, 493);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(94, 32);
            this.txtTax.TabIndex = 47;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(743, 496);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(97, 29);
            this.lblTax.TabIndex = 46;
            this.lblTax.Text = "Tax (%)";
            this.lblTax.Click += new System.EventHandler(this.lblTax_Click);
            // 
            // lblGTotal
            // 
            this.lblGTotal.AutoSize = true;
            this.lblGTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGTotal.Location = new System.Drawing.Point(743, 596);
            this.lblGTotal.Name = "lblGTotal";
            this.lblGTotal.Size = new System.Drawing.Size(140, 29);
            this.lblGTotal.TabIndex = 48;
            this.lblGTotal.Text = "Grand Total";
            // 
            // textTotal
            // 
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(906, 593);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(94, 32);
            this.textTotal.TabIndex = 49;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1087, 589);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 43);
            this.btnPrint.TabIndex = 50;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1087, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 43);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1087, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 43);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1308, 696);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.lblGTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtQtn);
            this.Controls.Add(this.lblQnt);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemNam);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblItemId);
            this.Controls.Add(this.lblItemDetails);
            this.Controls.Add(this.txtCustContact);
            this.Controls.Add(this.lblCustContact);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.dgvItemDisplay);
            this.Controls.Add(this.panelBilling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(201, 45);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panelBilling.ResumeLayout(false);
            this.panelBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBilling;
        private System.Windows.Forms.Label lblBilling;
        private System.Windows.Forms.Label lblCrossbtn;
        private System.Windows.Forms.DataGridView dgvItemDisplay;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustContact;
        private System.Windows.Forms.Label lblCustContact;
        private System.Windows.Forms.Label lblItemDetails;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemNam;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtQtn;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblGTotal;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}