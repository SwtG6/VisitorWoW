using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class StormwindCity : IAzeroth
    {
        private string _capitalName = "Stormwind City";

        public void WriteCapitalName()
        {
            Console.WriteLine(_capitalName);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(stormwindCity:this);
        }
    }
}
