﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class Darnassus : IAzeroth
    {
        private string _capitalName = "Darnassus";

        public void WriteCapitalName()
        {
            Console.WriteLine(_capitalName);
        }


        public void Accept(IVisitor visitor)
        {
            visitor.Visit(darnassus:this);
        }
    }
}
