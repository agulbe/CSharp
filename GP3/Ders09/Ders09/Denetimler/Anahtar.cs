using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Ders09.Denetimler
{
    internal class Anahtar: CheckBox
    {
        #region Alanlar
        private Color acikArkaRengi = Color.SkyBlue;
        private Color acikDugmeRengi = Color.LightSkyBlue;
        private Color kapaliArkaRengi = Color.DarkGray;
        private Color kapaliDugmeRengi = Color.LightGray;
        #endregion Alanlar

        #region Kurucu
        public Anahtar()
        {
            MinimumSize = new Size(40, 22);
            AutoSize = false;
        }
        #endregion Kurucu

        #region Metodlar
        private GraphicsPath Kenarlik()
        {
            int yayBoyu = Height - 1;
            var solYay = new Rectangle(0, 0, yayBoyu, yayBoyu);
            var sagYay = new Rectangle(Width - yayBoyu - 2, 0, yayBoyu, yayBoyu);

            GraphicsPath kenarlar = new();
            kenarlar.StartFigure();
            kenarlar.AddArc(solYay, 90, 180);
            kenarlar.AddArc(sagYay, 270, 180);
            kenarlar.CloseFigure();


            return kenarlar;
        }
        #endregion Metodlar
    }
}
