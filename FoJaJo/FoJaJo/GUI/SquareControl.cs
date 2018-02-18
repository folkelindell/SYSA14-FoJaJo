using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoJaJo.GUI
{
    public class SquareControl : Button
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int Value { get; set; }

        public SquareControl()
        {
            Value = 0;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            if(Value < 0)
            {
                BackColor = System.Drawing.Color.AliceBlue;
            }else if(Value > 0)
            {
                BackColor = System.Drawing.Color.IndianRed;

            }

            base.OnPaint(pevent);

        }
    }
}
