﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core1.Exceptions
{
    public class ClasroomException : Exception
    {
        public ClasroomException(string message = "Clasroom not found") : base(message)
        {
        }
    }
}