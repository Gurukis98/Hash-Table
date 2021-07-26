using System;
using System.Collections;

namespace Hash_Table_UC_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myhashtable = new Hashtable();
            MyMapNode<string, string> hashtable = new MyMapNode<string, string>(1);

            myhashtable.Add("W1", "Paranoids");
            myhashtable.Add("W2", "are");
            myhashtable.Add("W3", "not");
            myhashtable.Add("W4", "paranoid");
            myhashtable.Add("W5", "because");
            myhashtable.Add("W6", "they");
            myhashtable.Add("W7", "are");
            myhashtable.Add("W8", "paranoid");
            myhashtable.Add("W9", "but");
            myhashtable.Add("W10", "because");
            myhashtable.Add("W11", "they");
            myhashtable.Add("W12", "keep");
            myhashtable.Add("W13", "putting");
            myhashtable.Add("W14", "themselves");
            myhashtable.Add("W15", "deliberately");
            myhashtable.Add("W16", "into");
            myhashtable.Add("W17", "paranoid");
            myhashtable.Add("W18", "avoidable");
            myhashtable.Add("W19", "situations");

            myhashtable.Remove("W18");

            Console.WriteLine("Key and Value pairs from myhashtable");

            foreach (DictionaryEntry freq in myhashtable)
            {
                Console.WriteLine("{0} and {1} ", freq.Key, freq.Value);
            }
        }
    }
}
