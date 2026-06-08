using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
namespace MySwitch.MyControls
{
    public class ModernSwitch : CheckBox
    {
        // Renk Ayarları
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color OnBackColor { get; set; } = Color.MediumSlateBlue;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color OffBackColor { get; set; } = Color.Gray;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color OnColor { get; set; } = Color.Lime;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color OffColor { get; set; } = Color.Silver;

        public ModernSwitch()
        {
            this.DoubleBuffered = true;
            this.Cursor = Cursors.Hand;
            this.AutoSize = false;
            this.Size = new Size(132, 30); // Metin sığsın diye biraz genişlettik
        }

        private GraphicsPath GetFigurePath(Rectangle rect)
        {
            int arcSize = rect.Height - 1;
            Rectangle leftArc = new Rectangle(rect.X, rect.Y, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(rect.X + rect.Width - arcSize - 1, rect.Y, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            //Graphics g = pevent.Graphics;
            //g.SmoothingMode = SmoothingMode.AntiAlias;
            //g.Clear(this.Parent.BackColor);

            //// 1. Switch Boyutlarını Belirle (Görsel kısım)
            //int switchWidth = 45;
            //int switchHeight = 22;
            //// Switch'i dikeyde ortala
            //Rectangle rectSurface = new Rectangle(0, (this.Height - switchHeight) / 2, switchWidth, switchHeight);
            //int toggleSize = switchHeight - 5;

            //// 2. Arka Planı Çiz
            //if (this.Checked)
            //    g.FillPath(new SolidBrush(OnBackColor), GetFigurePath(rectSurface));
            //else
            //    g.FillPath(new SolidBrush(OffBackColor), GetFigurePath(rectSurface));

            //// 3. Toggle (Düğme) Çiz
            //if (this.Checked)
            //    g.FillEllipse(new SolidBrush(ToggleColor),
            //        new Rectangle(rectSurface.Width - switchHeight + 1, rectSurface.Y + 2, toggleSize, toggleSize));
            //else
            //    g.FillEllipse(new SolidBrush(ToggleColor),
            //        new Rectangle(2, rectSurface.Y + 2, toggleSize, toggleSize));

            //// 4. Metni (Text) Çiz
            //// Metni switch'in hemen yanına, dikeyde ortalanmış şekilde yazıyoruz
            //TextRenderer.DrawText(g, this.Text, this.Font,
            //    new Point(switchWidth + 5, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2),
            //    this.ForeColor);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(this.Parent.BackColor);

            // 1. Ölçüleri Tanımla
            int switchWidth = Height+Height;
            int switchHeight = Height;
            int margin = 10; // Metin ile switch arasındaki boşluk
            int toggleSize = switchHeight - 5;

            // 2. Switch Dikdörtgenini SAĞA Yasla
            // Kontrolün tam genişliğinden switch genişliğini çıkarıyoruz
            Rectangle rectSurface = new Rectangle(this.Width - switchWidth - 2, (this.Height - switchHeight) / 2, switchWidth, switchHeight);

            // 3. Arka Planı Çiz (Açık/Kapalı Renkleri)
            if (this.Checked)
                g.FillPath(new SolidBrush(OnBackColor), GetFigurePath(rectSurface));
            else
                g.FillPath(new SolidBrush(OffBackColor), GetFigurePath(rectSurface));

            // 4. Toggle (Düğme) Çiz
            if (this.Checked) // Sağa Yasla
            {
                g.FillEllipse(new SolidBrush(OnColor),
                    new Rectangle(rectSurface.Right - switchHeight + 1, rectSurface.Y + 2, toggleSize, toggleSize));
            }
            else // Sola Yasla
            {
                g.FillEllipse(new SolidBrush(OffColor),
                    new Rectangle(rectSurface.X + 2, rectSurface.Y + 2, toggleSize, toggleSize));
            }

            // 5. Metni SOLA Çiz
            // Metin 0 noktasından başlar, dikeyde ortalanır
            Size textSize = TextRenderer.MeasureText(Text, Font);
            // textSize.Width += 16;
            Rectangle textRect = new Rectangle(0, (Height - textSize.Height) / 2, 
                Width - switchWidth - margin, textSize.Height);

            TextRenderer.DrawText(g, this.Text, this.Font, textRect, this.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }
    }
}