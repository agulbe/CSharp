namespace Der04
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            imageList = new ImageList(components);
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.IndianRed;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.ImageIndex = 2;
            label1.ImageList = imageList;
            label1.Location = new Point(16, 16);
            label1.Margin = new Padding(1);
            label1.MaximumSize = new Size(350, 100);
            label1.MinimumSize = new Size(120, 32);
            label1.Name = "label1";
            label1.Padding = new Padding(1);
            label1.Size = new Size(192, 63);
            label1.TabIndex = 0;
            label1.Text = "&Adres:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "phone-call.png");
            imageList.Images.SetKeyName(1, "envelope.png");
            imageList.Images.SetKeyName(2, "user24.png");
            imageList.Images.SetKeyName(3, "home.png");
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.AutoCompleteCustomSource.AddRange(new string[] { "Abdülmuttalip", "Burhanettin", "Celalettin", "Cemalettin", "Ceyhun", "Cengizhan", "Cumali", "Canberk", "Cihan", "Coşkun", "Demirhan", "Ekbercan", "Fahrettin" });
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.AllUrl;
            textBox1.Location = new Point(469, 17);
            textBox1.Margin = new Padding(8);
            textBox1.MaxLength = 200;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Lütfen adınızı giriniz...";
            textBox1.Size = new Size(165, 187);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(16, 151);
            button1.Name = "button1";
            button1.Size = new Size(175, 53);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(197, 151);
            button2.Name = "button2";
            button2.Size = new Size(175, 53);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 250);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ImageList imageList;
        private Button button1;
        private Button button2;
    }
}
