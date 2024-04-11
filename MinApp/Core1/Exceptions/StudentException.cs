﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core1.Exceptions
{
    public class StudentException : Exception
    {
        public StudentException(string message = "Student not found") : base(message)
        {
        }
    }
}
