using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Inserire il menù di scelta delle opzioni nel Main
// caricamento di un array di N elementi con numeri random compresi tra X e Y scelti dall'utente
// troncamento di un array, data una dimensione Z inserita dall'utente (l'array viene ridotto alla dimensione Z)
//aggiunta ordinata di numeri in un array (inserire il valore nella posizione corretta, mantenendo l'ordinamento ad ogni aggiunta), sfruttando la funzione di "inserimento in posizione". dell'esercitazione 21
//Creare una funzione per ogni funzionalità richiesta, all'interno delle funzioni non ci devono essere riferimenti alla Console.
//Il menù dovrà essere inserito nel Main e in ogni opzione dovrà essere presente la chiamata alla funzione corrispondente alla funzionalità scelta.

namespace Aggiunta_Array_e_funzioni
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] array = new int[100];
            int menuChoice, lenght;
            string userInput;
            bool continuare;
            Console.WriteLine("Vuoi continuare ad usare il programma? yes o no");
            userInput = Console.ReadLine();
            if (userInput.ToLower() == "yes")
            {
                continuare = true;
            }
            else
            {
                continuare = false;
            }

            while (continuare)
            {
                Console.WriteLine("Hai tre opzioni: \n1 - caricamento di un array di N elementi con numeri random compresi tra X e Y scelti dall'utente\n2 - troncamento di un array, data una dimensione Z inserita dall'utente (l'array viene ridotto alla dimensione Z)\n3 - aggiunta ordinata di numeri in un array (inserire il valore nella posizione corretta, mantenendo l'ordinamento ad ogni aggiunta)");
                menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice)
                {
                    case 0:
                        Console.WriteLine();
                        break;

                    case 1:
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
