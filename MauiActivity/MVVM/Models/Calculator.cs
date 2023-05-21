using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiActivity.MVVM.Models
{
    public class Calculator
    {
        public string Num1 { get; set; }

        public string Num2 { get; set; }

        public string Oper { get; set; }

        public double History { get; set; }

        public double Result { get; set; }
    }
}
