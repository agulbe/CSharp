using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Ders13a
{
    internal class ResimKutusu : PictureBox
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SatirNo { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SutunNo { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { get; set; }
    }
}
