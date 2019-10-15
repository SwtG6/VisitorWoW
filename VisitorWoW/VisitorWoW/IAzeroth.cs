using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    interface IAzeroth //Element
    {
        void WriteCapitalName();
        void Accept(IVisitor visitor);
    }
}
