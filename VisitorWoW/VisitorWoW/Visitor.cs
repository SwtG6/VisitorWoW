using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class Visitor : IVisitor
    {
        public void Visit(Humans humans)
        {
            Console.WriteLine("For the Alliance XD");
        }

        public void Visit(NightElves nightElves)
        {
            Console.WriteLine("May the stars guide you");
        }

        public void Visit(Gnomes gnomes)
        {
            Console.WriteLine("My, you're a tall one!");
        }

        public void Visit(Dwarves dwarves)
        {
            Console.WriteLine("Interest ya'n a pint?");
        }
    }
}
