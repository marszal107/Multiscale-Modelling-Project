﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModelling
{
    public static class RandomHelper
    {
        private static readonly Random random = new Random();


        public static int Next(int maxValue)
        {
            return RandomHelper.random.Next(maxValue);
        }
    }
}
