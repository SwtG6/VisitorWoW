using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class StormwindCity : IAzeroth
    {
        public void CapitalName()
        {
            Console.WriteLine("Stormwind City:");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(stormwindCity:this);
        }
    }
}
