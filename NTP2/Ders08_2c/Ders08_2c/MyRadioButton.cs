using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Ders08_2c
{
    public class MyRadioButton : RadioButton
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? GroupName { get; set; }
    }
}
