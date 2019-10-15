using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWoW
{
    class Client
    {
        public static void BeforeVisitor(List<IAzeroth> Capitals)
        {
            Console.WriteLine("Before visitor: \n");
            foreach (var Capital in Capitals)
            {
                Capital.WriteCapitalName();
                Console.WriteLine("\n");
            }
        }

        public static void AfterVisitor(List<IAzeroth> Capitals, IVisitor visitor)
        {
            Console.WriteLine("After visitor: \n");
            foreach (var Capital in Capitals)
            {
                Capital.WriteCapitalName();
                Capital.Accept(visitor);
                Console.WriteLine("\n");
            }
        }
    }
}
