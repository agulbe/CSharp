namespace Ders04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ciz(Graphics g)
        {
            g.DrawImage(Image.FromFile("D:\\Resim\\Portre\\2444030010.jpg"), 100, 100);
            g.DrawEllipse(Pens.Blue, 200, 100, 200, 200);
            g.DrawRectangle(Pens.Red, 300, 100, 200, 200);
            g.DrawArc(Pens.Orange, 50, 50, 300, 100, 0, -180);
            g.DrawBezier(Pens.LightGreen, 50, 250, 250, 450, 100, 100, 200, 250);
            g.DrawBeziers(Pens.Coral,
                new Point(100, 300),
                new Point(150, 350),
                new Point(200, 300),
                new Point(250, 350),
                new Point(300, 250),
                new Point(350, 300),
                new Point(400, 250));
            g.DrawLine(Pens.Brown, 500, 100, 700, 800); 
            g.DrawLines(Pens.Cyan,
                new Point(600, 100),
                new Point(700, 200),
                new Point(600, 300),
                new Point(700, 400),
                new Point(600, 500));

            g.DrawPie(Pens.Silver, 10, 400, 200, 300, 60, 60);
            g.DrawPolygon(Pens.Yellow,
                new Point(450, 400),
                new Point(625, 410),
                new Point(600, 490),
                new Point(475, 500));

            g.DrawRoundedRectangle(Pens.Indigo,
                new Rectangle(10, 350, 300, 300),
                new Size(40, 40));

            g.FillEllipse(Brushes.Yellow, 210, 110, 180, 180);
            g.FillPie(Brushes.Red, 20, 410, 180, 280, 60, 60);
            g.FillPolygon(Brushes.Orange,
                new Point(460, 410),
                new Point(615, 400),
                new Point(590, 480),
                new Point(465, 490)
                );
            g.FillRectangle(Brushes.Cyan,
                310, 110, 180, 180);

            g.FillRoundedRectangle(Brushes.Violet,
                new Rectangle(20, 360, 280, 280),
                new Size(33, 33)
                );
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            Ciz(g);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Width = 1920;
            Height = 1000;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Ciz(g);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
