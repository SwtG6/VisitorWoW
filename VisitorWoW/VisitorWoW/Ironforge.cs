using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class Ironforge : IAzeroth
    {
        public void CapitalName()
        {
            Console.WriteLine("Ironforge:");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(ironforge:this);
        }
    }
}
