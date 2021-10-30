using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteka;
using Stos;

namespace Inkwizytor
{
    class Program
    {

        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\tA - Dodaj czarownicę do stosu");
            Console.WriteLine("\n\t\tB - Usuń czarownicę ze stosu");
            Console.WriteLine("\n\t\tC - Podaj liczbę czarownic na stosie");
            Console.WriteLine("\n\t\tD - Opróżnij stos");
            Console.WriteLine("\n\t\tK - Koniec");
            return Console.ReadKey(true).KeyChar;
        }

        static void Main(string[] args)
        {
            Stack mojaStos;
            Stack.Create(out mojaStos, 10);
            Osoba tmp;
            char c;

            do
            {
                c = Menu();
                switch (c)
                {
                    case 'a':
                    case 'A':
                        Osoba.WprowadzOsobe(out tmp);
                        Stack.Push(ref mojaStos, tmp);
                        break;
                    case 'b':
                    case 'B':
                        Osoba.WypiszOsobe(Stack.Pop(ref mojaStos));
                        Console.ReadKey();
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("Liczba czarownic na stosie wynosi: {0}",
                            Stack.GetLength(mojaStos));
                        Console.ReadKey();
                        break;
                    case 'd':
                    case 'D':
                        Stack.Clear(ref mojaStos);
                        Console.WriteLine("Stos oprózniony!!!");
                        Console.ReadKey();
                        break;
                }
            }
            while (!(c == 'k' || c == 'K'));
        }

    }
}
