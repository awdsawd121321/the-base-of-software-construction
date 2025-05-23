﻿using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 长方形类
    class rectangle : shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override string Type => "rectangle";
        public override bool IsValid => Width > 0 && Height > 0;
        public override double CalculateArea() => IsValid ? Width * Height : 0;
        public override string ToString() => $"{Type,-10} (Width={Width:F2}, Height={Height:F2})";
    }

}