﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.IO.Interfaces;

namespace _08.CollectionHierarchy.IO
{
    public class Writer : IWriter
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
