using FoJaJo.Controller;
using FoJaJo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoJaJo.GUI
{
    public class SquareControl : Button, IView
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public GameController Controller { get; set; }
        private Square square;
        public Square Square
        {
            get
            {
                return square;
            }
            set
            {
                square = value;
                if (square != null) square.ValueChanged += this.UpdateView;
            }
        }
        public SquareControl(int x, int y, Square square)
        {
            Square = square;
            XPos = x;
            YPos = y;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            Size = new System.Drawing.Size(30, 30);
            Click += new System.EventHandler(this.MakeMove);
            FlatStyle = FlatStyle.Flat;
            Font = new System.Drawing.Font(Font.Name, 15, System.Drawing.FontStyle.Bold);


        }

        private void MakeMove(object sender, EventArgs e)
        {
            Controller.MakeMove(XPos, YPos);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            if (Square?.SquareValue < 0)
            {
                Text = "X";
            }
            else if (Square?.SquareValue > 0)
            {
                Text = "O";
            }
            base.OnPaint(pevent);
        }

        public void UpdateView()
        {
            Refresh();
        }
    }
}
