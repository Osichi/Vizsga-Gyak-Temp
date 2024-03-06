namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. feladat
            List<Books> books = new List<Books>();
            string[] sorok = File.ReadAllLines("books.txt");
            foreach(var s in sorok)
            {
                string[] values = s.Split(',');
                Books books_object = new Books(values[0], values[1], values[2], values[3], values[4]);
                books.Add(books_object);
            }
            Console.WriteLine("4. feladat");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.sorszam} {book.mufaj} {book.cim} {book.ar} {book.mennyiseg}");
            }

            //5. feladat
            Console.WriteLine("5. feladat");
            int bookdb = 0;
            foreach (var book in books)
            {
                bookdb+= book.mennyiseg;
            }
            Console.WriteLine($"Az össz darabszám: {bookdb}");

            //6. feladat
            Console.WriteLine("6. feladat");
            foreach(var book in books)
            {
                if (book.mufaj == "Regény")
                {
                    Console.WriteLine($"A regény kategóriában lévő könyv címe és ára: {book.mufaj} {book.cim} {book.ar}");
                }
            }

            //7. feladat
            Console.WriteLine("7. feladat");
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var book in books)
            {
                if (dic.ContainsKey(book.mufaj))
                {
                    dic[book.mufaj]++;
                }
                else
                {
                    dic[book.mufaj] = 1;
                }
                Console.WriteLine("\nKategóriák és termékek száma:");
                foreach (var kvp in dic)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value} termék");
                }
            }

            //8. feladat
            Console.WriteLine("8. feladat");

            List<Books> legolcsobbak = new List<Books>();
            Books legolcsobb = books[0];
            legolcsobbak.Add(legolcsobb);

            foreach (var book in books)
            {
                if (book.ar < legolcsobb.ar)
                {
                    legolcsobb = book;
                    legolcsobbak.Clear();
                    legolcsobbak.Add(legolcsobb);
                }
                else if (book.ar == legolcsobb.ar)
                {
                    legolcsobbak.Add(book);
                }
            }

            Console.WriteLine("\nLegolcsóbb termek(ek) adatai:");
            foreach (var legolcsobbTermek in legolcsobbak)
            {
                Console.WriteLine($"Kategória: {legolcsobbTermek.mufaj}, {legolcsobbTermek.cim}, Ár: {legolcsobbTermek.ar}");
            }


            Console.ReadKey();



        }
    }
}