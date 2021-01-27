using System;

namespace Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> dictionary = new MyDictionary<int,string>();
            dictionary.Add(456789, "Elma");
            dictionary.Add(829892, "Baharat");
            dictionary.Add(329894, "Et");
            dictionary.Add(233890, "Kitap");

            
        }
    }
}
