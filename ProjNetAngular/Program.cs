using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectionExoEnsemble;

namespace ProjNetAngular
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("value");
            //arrayList.Add(new object());
            //arrayList.Add(15);
            
            List<string> list = new List<string>();
            
            list.Add("value");
            list.Add("v1");
            list.Add("v2");
            list.Add("v3");
            list.Add("v4");
            list.Add("v5");
            list.Add("v6");
            list.Insert(1, "value 2");
            //list.Contains("value");
            list.Remove("value");
            //list.Count();
            //list.ToArray();


            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list[i]);
            }

            // Hashtable

            Hashtable table = new Hashtable();
            table.Add(18, "valeur 1");
            table.Add("key", new int[3]);
            table.Add(true, 4.8);

            if (!table.ContainsKey(18))
                table.Add(18, "valeur autre");
            else
                table[18] = "valeur autre";

            Console.WriteLine( table[true] ); 
            Console.WriteLine( table["key"] ); 
            Console.WriteLine( table[18] );


            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine( $"key : {item.Key} | valeur : {item.Value}" );
            }

            foreach (object key in table.Keys)
            {
                Console.WriteLine($"key : {key} | valeur : { table[key] }");
            }

            foreach (object value in table.Values)
            {
                Console.WriteLine($"key : ??? | valeur : { value }");
            }

            Dictionary<char, string> dictionary = new Dictionary<char, string>();
            dictionary.Add('a', "allo");
            dictionary.Add('b', "bonjour");
            dictionary.Add('c', "coucou");

            // Queue

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("element 1");
            queue.Enqueue("element 2");
            queue.Enqueue("element 3");

            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine( queue.Dequeue() );
            }

            // Stack

            Stack<string> stack = new Stack<string>();
            stack.Push("element 1");
            stack.Push("element 2");
            stack.Push("element 3");


            Console.WriteLine( stack.Pop() );

            Console.ReadLine();

        }
    }
}
