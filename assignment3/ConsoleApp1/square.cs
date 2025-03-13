using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class square : shape
    {
        public double Side { get; set; }
        public square(double side)
        {
            Side = side;
        }
        public override string Type => "square";
        public override bool IsValid => Side > 0;
        public override double CalculateArea() => IsValid ? Side * Side : 0;
        public override string ToString() => $"{Type,-10} (Side={Side:F2})";
    }
}