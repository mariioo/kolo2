using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Program
    {
             static void Main(string[] args)
        {
             var pizza = new List<Skladnik>();
             var items = new List<KeyValuePair<string,double>>();
                 items.Add(new KeyValuePair<string,double>("pieczarki", 2.5));
                 items.Add(new KeyValuePair<string,double>("ser", 5.5));
                 items.Add(new KeyValuePair<string,double>("szynka", 8.5));
            foreach (var item in items)
	        {
		        try
                {
                    pizza.Add(new Skladnik(item.Key,item.Value));
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
	        }
            
            
              pizza.Sort();
              pizza.Reverse();
              pizza.ForEach(Console.WriteLine);
                Console.WriteLine();
                Console.WriteLine(string.Format("Suma cen skladnikow: {0}",pizza.Sum( item => item.GetCenaSkladnika())));

           

            var kolejka = new Queue<Zamowienie>();
                 kolejka.Enqueue(new Namiejscu());
                 kolejka.Enqueue(new Namiejscu());
                 kolejka.Enqueue(new Namiejscu());
                 kolejka.Enqueue(new Nawynos());
                 kolejka.Enqueue(new Nawynos());

            foreach (var item in kolejka)
            {
                Console.WriteLine(item.PoprawnyCzas());
            }

                while (kolejka.Count != 0)
            {
                 kolejka.Dequeue();
            }

         

            var pizza2 = new ArrayList();

                  pizza2.Add(new Skladnik("pieczarki", 3.5));
                  pizza2.Add(new Skladnik("szynka", 5.5));
                  pizza2.Add(new Skladnik("gyros", 4.5));
                  pizza2.Add(new Skladnik("papryka", 6.6));
                  pizza2.Add(new Skladnik("kukurydza", 3.5));
                  pizza2.Add(new Skladnik("ser", 4.5));
                  pizza2.Add(new Sos("czosnkowy", 2.5));
                  pizza2.Add(new Sos("pomidorowy", 1.25));

            
            foreach (var item in pizza2)
            {
                   Console.WriteLine(item.ToString());		 
            }
                  var pizza2Array = pizza2.ToArray().Cast<Skladnik>();

                  Console.WriteLine("Suma cen skladnikow: {0}", pizza2Array.Sum(item => item.GetCenaSkladnika()));

               var skladnik = pizza2Array.FirstOrDefault();
                 pizza2.Add(skladnik.Clone());

             foreach (var item in pizza2)
            {
                Console.WriteLine(item.ToString());
            }

               pizza2.Clear();
               pizza2Array = null;

            Console.ReadLine();
        }
    }
}
