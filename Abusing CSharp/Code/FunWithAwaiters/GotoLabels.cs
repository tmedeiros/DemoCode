﻿// Copyright 2013 Jon Skeet. All rights reserved. Use of this source code is governed by the Apache License 2.0, as found in the LICENSE.txt file.
using System;
using System.ComponentModel;

namespace FunWithAwaiters
{
    [Description("Goto (with labels)")]
    class GotoLabels
    {
        static void Main()
        {
            Console.WriteLine("Hello");
          loop:
            Console.Write("Keep going? ");
            string line = Console.ReadLine();
            if (line == "y")
            {
                goto loop;
            }
            Console.WriteLine("Finished!");
        } 
    }
}
