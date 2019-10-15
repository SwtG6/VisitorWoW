using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class Ironforge : IAzeroth
    {
        private string _capitalName = "Ironforge";

        public void WriteCapitalName()
        {
            Console.WriteLine(_capitalName);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(ironforge:this);
        }
    }
}
