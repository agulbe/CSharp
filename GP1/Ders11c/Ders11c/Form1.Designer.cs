namespace Ders11c
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
            imgListe = new ImageList(components);
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            SuspendLayout();
            // 
            // imgListe
            // 
            imgListe.ColorDepth = ColorDepth.Depth32Bit;
            imgListe.ImageStream = (ImageListStreamer)resources.GetObject("imgListe.ImageStream");
            imgListe.TransparentColor = Color.Transparent;
            imgListe.Images.SetKeyName(0, "Facebook16.png");
            imgListe.Images.SetKeyName(1, "Google16.png");
            imgListe.Images.SetKeyName(2, "Linkedin16.png");
            imgListe.Images.SetKeyName(3, "WhatsApp16.png");
            // 
            // linkLabel1
            // 
            linkLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel1.ImageIndex = 0;
            linkLabel1.ImageList = imgListe;
            linkLabel1.Location = new Point(50, 21);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(120, 25);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Facebook";
            linkLabel1.TextAlign = ContentAlignment.MiddleRight;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // linkLabel2
            // 
            linkLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel2.ImageIndex = 1;
            linkLabel2.ImageList = imgListe;
            linkLabel2.Location = new Point(50, 76);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(120, 25);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "google+";
            linkLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // linkLabel3
            // 
            linkLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel3.ImageIndex = 2;
            linkLabel3.ImageList = imgListe;
            linkLabel3.Location = new Point(50, 131);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(120, 25);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "linkedIn";
            linkLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // linkLabel4
            // 
            linkLabel4.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel4.ImageIndex = 3;
            linkLabel4.ImageList = imgListe;
            linkLabel4.Location = new Point(50, 186);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(120, 25);
            linkLabel4.TabIndex = 3;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "WhatsApp";
            linkLabel4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 234);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private ImageList imgListe;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
    }
}
