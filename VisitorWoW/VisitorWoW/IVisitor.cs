using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    interface IVisitor
    {
        void Visit(Humans humans);
        void Visit(NightElves nightElves);
        void Visit(Gnomes gnomes);
        void Visit(Dwarves dwarves);
    } 
   
}
