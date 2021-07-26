using System;
using System.Collections;


namespace Hash_Table_UC_1
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Hashtable myhashtable = new Hashtable();
            MyMapNode<string, string> hashtable = new MyMapNode<string, string>(6);

            myhashtable.Add("W1", "To");
            myhashtable.Add("W2", "be");
            myhashtable.Add("W3", "or");
            myhashtable.Add("W4", "not");
            myhashtable.Add("W5", "to");
            myhashtable.Add("W6", "be");

            Console.WriteLine("Key and Value pairs from myhashtable");

            foreach (DictionaryEntry freq in myhashtable)
            {
                Console.WriteLine("{0} and {1}", freq.Key, freq.Value);
            }
        }
    }
}
