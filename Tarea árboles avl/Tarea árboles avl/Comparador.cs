﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_árboles_avl
{
    interface Comparador
    {
        bool igualQue(Object q);
        bool menorQue(Object q);
        bool menorIgualQue(Object q);
        bool mayorQue(Object q);
        bool mayorIgualQue(Object q);
    }
}
