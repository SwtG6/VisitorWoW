using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class Visitor : IVisitor
    {
        public void Visit(StormwindCity stormwindCity)
        {
            Console.WriteLine("For the Alliance");
        }

        public void Visit(Darnassus darnassus)
        {
            Console.WriteLine("May the stars guide you");
        }

        public void Visit(Gnomeregan gnomeregan)
        {
            Console.WriteLine("My, you're a tall one!");
        }

        public void Visit(Ironforge ironforge)
        {
            Console.WriteLine("Interest ya'n a pint?");
        }
    }
}
