using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricot_Calculator_Design
{
    class OperatorClass
    {
        private Double val = 0;
        private String text = "";
        private bool oper_press = false;

        private String calc2;

        public double Val { get => val; set => val = value; }
        public string Text { get => text; set => text = value; }
        public bool Oper_press { get => oper_press; set => oper_press = value; }
        public string Calc2 { get => calc2; set => calc2 = value; }

        public void Add()
        {
            calc2 = (Val + Double.Parse(Calc2)).ToString();
        }
        public void Subtract()
        {
            calc2 = (Val - Double.Parse(Calc2)).ToString();
        }
        public void Multiply()
        {
            calc2 = (Val * Double.Parse(Calc2)).ToString();
        }
        public void Division()
        {
            calc2 = (Val / Double.Parse(Calc2)).ToString();
        }
    }
}
