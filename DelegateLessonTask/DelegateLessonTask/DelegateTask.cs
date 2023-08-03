using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLessonTask
{
    internal class DelegateTask
    {


        //    2) Person tipinden listimiz var.Maashi 1000-den cox olan personlarin
        //    ad, soyad ve addresini gosteren ve parametr olaraq predicate qebul eden method yazin.

        public void PersonMethod()
        {

            List<Person> list = new();

            list.Add(new Person { Id = 1, FullName = "Ismayil Efendizade", Address = "Yasamal", Salary = 500 });
            list.Add(new Person { Id = 2, FullName = "Samir Qehramanov", Address = "Sumqayit", Salary = 700 });
            list.Add(new Person { Id = 3, FullName = "Fidan Bashirova", Address = "Xirdalan", Salary = 3000 });
            list.Add(new Person { Id = 4, FullName = "Kubra Memmedova", Address = "Xetai", Salary = 2400 });
            list.Add(new Person { Id = 5, FullName = "Pervin Mirzeyev", Address = "Bileceri", Salary = 4500 });

            PersonFilterBySalary(list, m => m.Salary > 1000);

        }

        private void PersonFilterBySalary(List<Person> persons, Predicate<Person> func)

        {

            foreach (var person in persons)
            {
                if (func(person))
                {
                    Console.WriteLine($"Fullname: {person.FullName} Adrdess: {person.Address}");
                }
            }

        }





        // 3) Book tipinden listimiz olacaq.Authoru  Nizami olan book-larin sayini gosteren ve predicate qebul eden method yazin.


        // 1-ci usul



        public void BookMethod()
        {

            List<Book> list = new();

            list.Add(new Book { Id = 1, NameBook = "Xosrov ve Shirin", Author = "Nizami Gencevi" });
            list.Add(new Book { Id = 2, NameBook = "Samir Qehramanov", Author = "Nizami Gencevi" });
            list.Add(new Book { Id = 3, NameBook = "Fidan Bashirova", Author = "Bextiyar Vahabzade" });
            list.Add(new Book { Id = 4, NameBook = "Kubra Memmedova", Author = "Semed Vurgun" });
            list.Add(new Book { Id = 5, NameBook = "Pervin Mirzeyev", Author = "Mikayil Mushviq" });

            FilterByAuthorCount(list, m => m.Author == "Nizami Gencevi");

        }

        private void FilterByAuthorCount(List<Book> books, Predicate<Book> func)

        {
            int count = 0;
            foreach (var book in books)
            {
                if (func(book))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }





        // 2-ci usul


        public void BookMehtodSecond()
        {
            List<Book> list = new();

            list.Add(new Book { Id = 1, NameBook = "Xosrov ve Shirin", Author = "Nizami Gencevi" });
            list.Add(new Book { Id = 2, NameBook = "Samir Qehramanov", Author = "Nizami Gencevi" });
            list.Add(new Book { Id = 3, NameBook = "Ekizler", Author = "Bextiyar Vahabzade" });
            list.Add(new Book { Id = 4, NameBook = "Agaclar", Author = "Semed Vurgun" });
            list.Add(new Book { Id = 5, NameBook = "Solgun guller", Author = "Mikayil Mushviq" });

            var result = list.Where(m => m.Author == "Nizami Gencevi").Count();

            Console.WriteLine(result);

        }












    }
}
