﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeXv2
{
    public static class Extensions
    {
        public static bool Contain(this string Text, string ContainedText)
        {
            if (Text.ToUpperInvariant().Contains(ContainedText.ToUpperInvariant()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
