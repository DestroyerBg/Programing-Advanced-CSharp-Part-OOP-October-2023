﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Stream_Progress.Interfaces
{
    public interface IStream
    {
        public int Length { get; }

        public int BytesSent { get;}
    }
}
