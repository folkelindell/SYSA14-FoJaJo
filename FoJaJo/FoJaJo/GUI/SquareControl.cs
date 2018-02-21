using FoJaJo.Controller;
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

        public SquareControl(int x, int y)
        {
            Value = 0;
            XPos = x;
            YPos = y;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            Size = new System.Drawing.Size(30, 30);
            Click += new System.EventHandler(this.makeMove);
        }

        private void makeMove(object sender, EventArgs e)
        {
            if(Value == 0)
            {
                Console.WriteLine("klickkkk x: {0} y: {1}", XPos, YPos);
            }
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            if (Value < 0)
            {
                BackColor = System.Drawing.Color.AliceBlue;
            }
            else if (Value > 0)
            {
                BackColor = System.Drawing.Color.IndianRed;

            }

            base.OnPaint(pevent);
        }
    }
}
