using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Ders10.Kontrol
{
    public class Switch : CheckBox
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsOn { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color OnColor { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color OffColor { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color OnBackColor { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color OffBackColor { get; set; }


        public Switch()
        {
            DoubleBuffered = true;
            AutoSize = false;
            Cursor = Cursors.Hand;
            Text = "Switch";
            Width = 45;
            Height = 22;
            OnColor = Color.Green;
            OffColor = Color.DarkGray;
            OnBackColor = Color.LightGray;
            OffBackColor = Color.Gray;
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = Height - 1;

            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(Width - arcSize -2, 0, 
                arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
                path.AddArc(leftArc, 90, 180);
                path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // KENAR YUMUŞATMAYI AÇ
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            // Her yeni çizimde arka planı formun arkaplan rengi ile boya
            pevent.Graphics.Clear(Parent.BackColor);
            
            // Dairenin çapı
            int toggleSize = Height - 5;


            if (IsOn)
            {
                // Switch'in arka planını boya
                pevent.Graphics.FillPath(new SolidBrush(OnBackColor), GetFigurePath());
                // Switch'in dairesini boya
                pevent.Graphics.FillEllipse(new SolidBrush(OnColor), new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(OffBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(OffColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }

    }
}
