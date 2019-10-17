using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class RacialQuotesVisitor : IVisitor
    {
        public void Visit(StormwindCity stormwindCity)
        {
            Console.WriteLine("Human: \"For the Alliance\"");
        }

        public void Visit(Ironforge ironforge)
        {
            Console.WriteLine("Dwarf: \"Interest ya'n a pint?\"");
        }

        public void Visit(Darnassus darnassus)
        {
            Console.WriteLine("Night elf:\"May the stars guide you\"");
        }

        public void Visit(Gnomeregan gnomeregan)
        {
            Console.WriteLine("Gnome: \"My, you're a tall one!\"");
        }

        
    }
}
