﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class UnaException : Exception
    {
        public Exception Excepcion;
        public UnaException(DivideByZeroException j)
        {
            this.Excepcion = j.InnerException;
        }
    }
}
