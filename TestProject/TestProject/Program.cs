﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            for (int i = 0; i < 20; i++)
            {
                x += i;
                i += 2;
                //this is the master branch
            }
        }
    }
}
