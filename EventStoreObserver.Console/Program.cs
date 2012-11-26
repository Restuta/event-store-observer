using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restuta.ConsoleExtensions.Colorfull;

namespace EventStoreObserver.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //v1
            //connect to mongo
            //start quering EventStore collection (assuming it's one for now?) with time intervals, let's say once in
            //      half-second, investigate any mongo notifiers, hooks
            //      investigate if it's possible to hook into event writing process right into app or event store layer
            //
            //format message
            //output colored
        }

        public static void W(string text)
        {
            ColorfulConsole.Write(text);
        }

        public static void WL(string text)
        {
            ColorfulConsole.WriteLine(text);
        }
    }
}
