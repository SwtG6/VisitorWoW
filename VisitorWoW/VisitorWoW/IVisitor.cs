﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    interface IVisitor
    {
        void Visit(StormwindCity stormwindCity);
        void Visit(Ironforge ironforge);
        void Visit(Darnassus darnassus);
        void Visit(Gnomeregan gnomeregan);
        
    } 
   
}
