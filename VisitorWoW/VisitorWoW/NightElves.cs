using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class NightElves : IAzeroth
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(nightElves:this);
        }
    }
}
