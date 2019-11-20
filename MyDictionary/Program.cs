using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDictionaryContext db = new MyDictionaryContext())
            {
                Dictionary word1 = new Dictionary { RussianWord="солнце", EnglishWord= "sun" };
                Dictionary word2 = new Dictionary { RussianWord = "море", EnglishWord = "sea" };
                db.Dictionaries.Add(word1);
                db.Dictionaries.Add(word2);
                db.SaveChanges();
                Console.WriteLine("Words save succesfully!");
                var dictionaries = db.Dictionaries;
                Console.WriteLine("List words:");
                foreach (Dictionary d in dictionaries)
                {
                    Console.WriteLine("{0}.{1}-{2}",d.Id, d.RussianWord, 
                        d.EnglishWord);
                }
            }
            Console.ReadKey();
        }
    }
}
