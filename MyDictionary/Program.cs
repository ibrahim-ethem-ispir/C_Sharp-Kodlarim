using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dictionary = new MyDictionary<string, int>();
            dictionary.add("Masa", 10);
            dictionary.add("Kitap", 15);
            dictionary.add("Telefon", 4);

            dictionary.list();
        }
    }
}
