﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalc
{
   public static class Calc
    {
        public static double Massimo(double a, double b)
        {
            double max = 0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
        public static double Minimo(double a, double b)
        {
            double min = 0;
            if (a > b)
            {
                min = b;
            }
            else
            {
                min = a;
            }
            return min;
        }
        public static double Media(double a, double b)
        {
            double ris = 0;
            ris = (a + b) / 2;
            return ris;
        }
    }
}
