using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class VisitorDemo
    {
        static void Main(string[] args)
        {
            List<IAzeroth> azeroth = new List<IAzeroth>
            {

                new StormwindCity(),
                new Ironforge(),
                new Darnassus(),
                new Gnomeregan()

            };

            Console.WindowWidth = 100;
            Console.WindowHeight = 35;
            Client.BeforeVisitor(azeroth);
            Console.WriteLine();

            var v1 = new RacialQuotesVisitor();
            Client.AfterVisitor(azeroth, v1);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
