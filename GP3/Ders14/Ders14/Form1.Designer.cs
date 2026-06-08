namespace Ders14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            txtAddress = new TextBox();
            label11 = new Label();
            txtPhone = new MaskedTextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            txtClient = new TextBox();
            label8 = new Label();
            nudQuantity = new NumericUpDown();
            label7 = new Label();
            nudPrice = new NumericUpDown();
            label6 = new Label();
            txtService = new TextBox();
            label5 = new Label();
            dtpDue = new DateTimePicker();
            label4 = new Label();
            dtpIsuue = new DateTimePicker();
            label3 = new Label();
            cboStatus = new ComboBox();
            label2 = new Label();
            txtNumber = new TextBox();
            label1 = new Label();
            dgvInvoice = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtAddress);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(txtPhone);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(txtEmail);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(txtClient);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(nudQuantity);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(nudPrice);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(txtService);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(dtpDue);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(dtpIsuue);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(cboStatus);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtNumber);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvInvoice);
            splitContainer1.Size = new Size(571, 347);
            splitContainer1.SplitterDistance = 213;
            splitContainer1.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(101, 296);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 39);
            txtAddress.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 296);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 20;
            label11.Text = "Adres: ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(101, 267);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 270);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 18;
            label10.Text = "&Telefon: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(101, 238);
            txtEmail.MaxLength = 127;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 241);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 16;
            label9.Text = "&E-posta:";
            // 
            // txtClient
            // 
            txtClient.Location = new Point(101, 209);
            txtClient.MaxLength = 50;
            txtClient.Name = "txtClient";
            txtClient.Size = new Size(100, 23);
            txtClient.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 212);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 14;
            label8.Text = "Müşteri &Adı: ";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(104, 180);
            nudQuantity.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(59, 23);
            nudQuantity.TabIndex = 13;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 182);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 12;
            label7.Text = "&Miktar: ";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(104, 151);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(97, 23);
            nudPrice.TabIndex = 11;
            nudPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 153);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 10;
            label6.Text = "&Birim Fiyat:";
            // 
            // txtService
            // 
            txtService.Location = new Point(101, 122);
            txtService.Name = "txtService";
            txtService.Size = new Size(100, 23);
            txtService.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 125);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "&Hizmet: ";
            // 
            // dtpDue
            // 
            dtpDue.Format = DateTimePickerFormat.Short;
            dtpDue.Location = new Point(101, 93);
            dtpDue.Name = "dtpDue";
            dtpDue.Size = new Size(100, 23);
            dtpDue.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "Ödeme Tarihi: ";
            // 
            // dtpIsuue
            // 
            dtpIsuue.Format = DateTimePickerFormat.Short;
            dtpIsuue.Location = new Point(101, 64);
            dtpIsuue.Name = "dtpIsuue";
            dtpIsuue.Size = new Size(100, 23);
            dtpIsuue.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 70);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 4;
            label3.Text = "Fatura Tarihi:";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "(Yok)", "Beklemede", "Ödendi" });
            cboStatus.Location = new Point(101, 35);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(100, 23);
            cboStatus.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 38);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "&Durum:";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(101, 6);
            txtNumber.MaxLength = 10;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(85, 23);
            txtNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Fatura &No.";
            // 
            // dgvInvoice
            // 
            dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Dock = DockStyle.Fill;
            dgvInvoice.Location = new Point(0, 0);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.Size = new Size(354, 347);
            dgvInvoice.TabIndex = 0;
            dgvInvoice.CellClick += dgvInvoice_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 347);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtNumber;
        private Label label1;
        private Label label5;
        private DateTimePicker dtpDue;
        private Label label4;
        private DateTimePicker dtpIsuue;
        private Label label3;
        private ComboBox cboStatus;
        private Label label2;
        private Label label10;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtClient;
        private Label label8;
        private NumericUpDown nudQuantity;
        private Label label7;
        private NumericUpDown nudPrice;
        private Label label6;
        private TextBox txtService;
        private TextBox txtAddress;
        private Label label11;
        private MaskedTextBox txtPhone;
        private DataGridView dgvInvoice;
    }
}
