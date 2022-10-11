using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var stringCollection = new SCollection())
            {
                var list = stringCollection.RetrieveStringCollection();
                stringCollection.ProcessCollection(list).ForEach(w => Console.Write("{0}\n", w));
                Console.ReadKey();
            }
        }

    }
    
}
