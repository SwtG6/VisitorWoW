using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class Gnomeregan : IAzeroth
    {

        private string _capitalName = "Gnomeregan";

        public void WriteCapitalName()
        {
            Console.WriteLine(_capitalName);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(gnomeregan:this);
        }
    }
}
