using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace Zjazd_6
{
    class Program
    {
        class Osoba
        {
            public string imie;
            public string nazwisko;
            public int id;

            public Osoba(string imie, string nazwisko, int id)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.id = id;
            }
        }
        static void Main(string[] args)
        {
            #region task
            //  List<int> lista = Enumerable.Range(150, 100).ToList();
            // List<> lista = Enumerable.Range(150, 100).Select(x=>(double)x).ToList();

            // List<double> lista = Enumerable.Range(150, 100).Cast<double>().ToList();
            //składnia lambda
            //List<int> lista = Enumerable.Range(150, 100).ToList();
            //IEnumerable<int> podzielprzez3 = lista.Where(x => x % 3 == 0).ToList();

            //List<int> lista = Enumerable.Range(150, 100).ToList();
            //IEnumerable<int> podzielprzez3 = lista.Where(x=>x%3==0).ToList();
            //foreach (var item in podzielprzez3)
            //{
            //    Console.WriteLine(item);
            //}
            //int suma = podzielprzez3.Sum();
            //Console.WriteLine(suma);

            //double srednia = podzielprzez3.Average(); // abc.Average liczba całkowita  double zmienna
            //Console.WriteLine(srednia);
            #endregion

            #region task2
            //List<int> lista = Enumerable.Range(150, 100).ToList();
            //List<Osoba> osoby = lista.Select(x => new Osoba()
            //{
            //    imie = x.ToString(),
            //    nazwisko="Aaa",
            //    id=x

            //}).ToList();

            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.id}:{item.imie}{item.nazwisko}");
            //}
            #endregion

            #region task3
            //List<int> lista = Enumerable.Range(150, 100).ToList();
            //List<Osoba> osoby = lista.Select(x => new Osoba()
            //{
            //    imie = x.ToString(),
            //    nazwisko = "Aaa",
            //    id = x

            //}).ToList();

            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.id}:{item.imie}{item.nazwisko}");
            //}

            //osoby[45].nazwisko = "Bbb";
            //Osoba osobyB = osoby.Where(x => x.nazwisko.StartsWith("Bbb")).First();
            //   Osoba osobyB = osoby.Where(x => x.nazwisko.StartsWith("C")).FirstOrDefault();


            //osoby.Select(x => x.nazwisko)
            //    .Distinct().ToList().ForEach(Console.WriteLine);
            //int iloscelemetownastronie = 10;
            //int nrstrony = 2;
            //List<Osoba> strona = osoby.Skip(iloscelemetownastronie * (nrstrony))
            //    .Take(iloscelemetownastronie).ToList();

            //foreach (var item in strona)
            //{
            //    Console.WriteLine($"{item.id}:{item.imie}{item.nazwisko}");
            //}
            #endregion

            List<int> lista = Enumerable.Range(150, 100).ToList();
            var randomizerFirstName =
                RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var randomizerLastName =
                RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            List<Osoba> osoby = lista.Select(
                x => new Osoba
                (randomizerFirstName.Generate(),
                 randomizerLastName.Generate(),
                 x)).ToList();

            foreach (var item in osoby)
            {
                Console.WriteLine($"{item.id}:{item.imie} {item.nazwisko}");
            }

            Console.ReadKey();
        }
    }
}
