using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoJaJo.Model
{
    public class Square
    {
        public delegate void valueChangedEvent();
        public valueChangedEvent ValueChanged { get; set; }
        private int squareValue;
        public int SquareValue { get
            {
                return squareValue;
            }
            set
            {
                squareValue = value;
                ValueChanged?.Invoke();
            }
        }

        public Square()
        {
            SquareValue = 0;
        }

    }
}
