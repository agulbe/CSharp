namespace Ders10_1a
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
            btnGetir = new Button();
            cboCity = new ComboBox();
            btnSorgu = new Button();
            dgvSorgu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSorgu).BeginInit();
            SuspendLayout();
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(12, 12);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(75, 23);
            btnGetir.TabIndex = 0;
            btnGetir.Text = "&Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Items.AddRange(new object[] { "Aachen", "Albuquerque", "Anchorage", "Århus", "Barcelona", "Barquisimeto", "Bergamo", "Berlin", "Bern", "Boise", "Bräcke", "Brandenburg", "Bruxelles", "Buenos Aires", "Butte", "Campinas", "Caracas", "Charleroi", "Cork", "Cowes", "Cunewalde", "Elgin", "Eugene", "Frankfurt a.M.", "Genève", "Graz", "Helsinki", "I. de Margarita", "Kirkland", "Kobenhavn", "Köln", "Lander", "Leipzig", "Lille", "Lisboa", "London", "Luleå", "Lyon", "Madrid", "Mannheim", "Marseille", "México D.F.", "Montréal", "München", "Münster", "Nantes", "Oulu", "Paris", "Portland", "Reggio Emilia", "Reims", "Resende", "Rio de Janeiro", "Salzburg", "San Cristóbal", "San Francisco", "Sao Paulo", "Seattle", "Sevilla", "Stavern", "Strasbourg", "Stuttgart", "Torino", "Toulouse", "Tsawassen", "Vancouver", "Versailles", "Walla Walla", "Warszawa" });
            cboCity.Location = new Point(93, 13);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(140, 23);
            cboCity.Sorted = true;
            cboCity.TabIndex = 1;
            // 
            // btnSorgu
            // 
            btnSorgu.Location = new Point(239, 13);
            btnSorgu.Name = "btnSorgu";
            btnSorgu.Size = new Size(75, 23);
            btnSorgu.TabIndex = 2;
            btnSorgu.Text = "&Sorgula";
            btnSorgu.UseVisualStyleBackColor = true;
            btnSorgu.Click += btnSorgu_Click;
            // 
            // dgvSorgu
            // 
            dgvSorgu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSorgu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSorgu.Location = new Point(12, 56);
            dgvSorgu.Name = "dgvSorgu";
            dgvSorgu.Size = new Size(388, 150);
            dgvSorgu.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 218);
            Controls.Add(dgvSorgu);
            Controls.Add(btnSorgu);
            Controls.Add(cboCity);
            Controls.Add(btnGetir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSorgu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetir;
        private ComboBox cboCity;
        private Button btnSorgu;
        private DataGridView dgvSorgu;
    }
}
