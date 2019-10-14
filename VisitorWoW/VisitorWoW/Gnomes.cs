using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class Gnomes : IAzeroth
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(gnomes:this);
        }
    }
}
