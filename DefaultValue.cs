﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class DefaultValue
    {
        public static T GetDefault<T>()
        { 
            return default(T);
        }
    }
}
