using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class Humans : IAzeroth
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(humans: this);
        }
    }
}
