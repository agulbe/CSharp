using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MySwitch.MyControls
{
    public class StatusButton : Button
    {
        // --- Özellikler (Properties) ---

        // Yuvarlak köşelerin yarıçapı
        private int _borderRadius = 10;
        [Category("Appearance_Custom")]
        [Description("Buton köşelerinin yuvarlatılma yarıçapı.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius
        {
            get => _borderRadius;

            set 
            {
                if (value < Height / 2)
                {
                    _borderRadius = value;
                    this.Invalidate();// Değişirse yeniden çiz
                }
            } 
        }

        // Gösterge dairesinin boyutu
        private int _indicatorSize = 8;
        [Category("Appearance_Custom")]
        [Description("Enabled gösterge dairesinin çapı.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IndicatorSize
        {
            get => _indicatorSize;
            set 
            { 
                _indicatorSize = value < BorderRadius ? value : BorderRadius -1; 
                Invalidate(); 
            }
        }

        // Gösterge dairesinin konumu için Enum tanımlıyoruz
        public enum IndicatorLocation
        {
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight
        }

        // Konum özelliğini tutan değişken
        private IndicatorLocation _indicatorPosition = IndicatorLocation.TopRight;
        [Category("Appearance_Custom")]
        [Description("Enabled gösterge dairesinin hangi köşede duracağı.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IndicatorLocation IndicatorPosition
        {
            get => _indicatorPosition;
            set { _indicatorPosition = value; this.Invalidate(); }
        }

        // Renk Tanımlamaları (İsteğe bağlı olarak
        // bunları da Property yapabilirsiniz)
        private Color EnabledColor = Color.LimeGreen;
        private Color DisabledColor = Color.Crimson;
        // Dairenin etrafındaki ince çizgi
        private Color IndicatorBorderColor = Color.White; 

        public StatusButton()
        {
            // Titremeyi önlemek için gelişmiş çizim ayarları
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);

            this.Size = new Size(100, 30); // Varsayılan boyut
            this.BackColor = Color.FromArgb(60, 60, 60); // Koyu varsayılan arka plan
            this.ForeColor = Color.White; // Beyaz yazı
            this.FlatStyle = FlatStyle.Flat; // Standart buton kenarlıklarını kaldırır
            this.FlatAppearance.BorderSize = 0; // Kenarlık kalınlığını sıfırlar
        }

        // Yuvarlak köşeli dikdörtgen yolu oluşturmak için yardımcı metod
        private GraphicsPath GetRoundRectanglePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;

            path.StartFigure();
            // Sol Üst
            if (IndicatorPosition == IndicatorLocation.TopLeft)
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, -270);
            else
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // Sağ Üst
            if(IndicatorPosition == IndicatorLocation.TopRight)
                path.AddArc(rect.Right - diameter, rect.Y, 
                    diameter, diameter, 270, -270);
            else 
                path.AddArc(rect.Right - diameter, rect.Y, 
                    diameter, diameter, 270, 90);
            // Sağ Alt
            if (IndicatorPosition == IndicatorLocation.BottomRight)
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, 
                    diameter, diameter, 0, -270);
            else
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, 
                    diameter, diameter, 0, 90);
            // Sol Alt
            if(IndicatorPosition == IndicatorLocation.BottomLeft)
                path.AddArc(rect.X, rect.Bottom - diameter, 
                    diameter, diameter, 90, -270);
            else
                path.AddArc(rect.X, rect.Bottom - diameter, 
                    diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        // Butonun çizimini tamamen kontrol altına alıyoruz
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Base metodunu çağırmıyoruz, çünkü her şeyi kendimiz çizeceğiz.
            // base.OnPaint(pevent); 

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Pürüzsüz kenarlar
            g.Clear(this.Parent.BackColor); // Arka planı temizle
            
            // Düğmenin alanını tanımlayan dikdörtgen
            Rectangle rectButton = new Rectangle(0, 0, this.Width, this.Height);
            // Tıklama alanıiçin tam boyutlu dikdörtgen 
            RectangleF rectBounds = new RectangleF(0, 0, this.Width, this.Height);

            // 1. BUTON ARKA PLANINI ÇİZ (Yuvarlak Köşeli)
            using (GraphicsPath path = 
                GetRoundRectanglePath(rectBounds, BorderRadius))
            {
                // this.Region = new Region(path); 
                // Butonun tıklanabilir alanını da yuvarlar
                Region = new Region(rectButton);
                // Fare durumuna göre arka plan rengini hafifçe değiştir
                // (Görsel geri bildirim)
                Color currentBackColor = this.BackColor;
                // Koyu yap
                if (!this.Enabled) currentBackColor = 
                        Color.FromArgb(currentBackColor.R / 2, 
                        currentBackColor.G / 2, 
                        currentBackColor.B / 2); 
                else if (
                    this.ClientRectangle.Contains(
                        this.PointToClient(
                            Control.MousePosition)) && 
                            MouseButtons == MouseButtons.Left)
                    // Tıklanınca koyulaştır
                    currentBackColor = ControlPaint.Dark(this.BackColor, 0.1f);

                //using (SolidBrush brush = new SolidBrush(currentBackColor))
                //{
                //    g.FillPath(brush, path);
                //}

                SolidBrush brush = new SolidBrush(currentBackColor);
                g.FillPath(brush, path);
                brush.Dispose();
            }

            // 2. BUTON METNİNİ ÇİZ
            TextRenderer.DrawText(g, this.Text, this.Font, 
                rectButton, this.ForeColor,
                TextFormatFlags.HorizontalCenter | 
                TextFormatFlags.VerticalCenter | 
                TextFormatFlags.EndEllipsis);

            // 3. ENABLED GÖSTERGESİNİ (DAİRE) ÇİZ
            DrawStatusIndicator(g);
        }

        // Daire göstergesini çizen metod
        private void DrawStatusIndicator(Graphics g)
        {
            int x = 0, y = 0;
            // Gösterge boyutu, köşe yarıçapından büyük olamaz
            int indicatorSize = IndicatorSize * 2;
            // Köşeden olan iç boşluk
            int padding = (BorderRadius - IndicatorSize); 

            // Konum enumuna göre koordinatları hesapla
            switch (IndicatorPosition)
            {
                case IndicatorLocation.TopLeft:
                    x = padding;
                    y = padding;
                    break;
                case IndicatorLocation.TopRight:
                    x = this.Width - indicatorSize - padding;
                    y = padding;
                    break;
                case IndicatorLocation.BottomLeft:
                    x = padding ;
                    y = this.Height - indicatorSize - padding;
                    break;
                case IndicatorLocation.BottomRight:
                    x = this.Width - indicatorSize - padding ;
                    y = this.Height - indicatorSize - padding;
                    break;
            }

            Rectangle rectIndicator = 
                new Rectangle(x, y, indicatorSize, indicatorSize);

            // Enabled durumuna göre rengi belirle
            Color statusColor = this.Enabled ? EnabledColor : DisabledColor;

            // Dairenin içini doldur
            using (SolidBrush brush = new SolidBrush(statusColor))
            {
                g.FillEllipse(brush, rectIndicator);
            }

            // Dairenin etrafına ince bir beyaz çizgi (kontur) çiz
            // (daha belirgin olması için)
            using (Pen pen = new Pen(IndicatorBorderColor, 1f))
            {
                g.DrawEllipse(pen, rectIndicator);
            }
        }
    }
}
