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

        static int CaricamentoRandom(ref int[] array, int lenght, int max, int min)
        {
            Random random = new Random();
            for (int i = 0; i < lenght; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return 0;
        }

        static int CambiaLunghezza(ref int[] array, ref int lenght, int nextLenght)
        {
            for (int i = lenght-1; i < nextLenght - 1; i++)
            {
                array[lenght - 1] = 0;
            }
            lenght = nextLenght;
            return 0;
        }

        static void CaricamentoOrdinato(ref int[] array, int lenght, int max, int min)
        {
            int CurrentLenght = 1, temp;
            Random r = new Random();
            array[0] = r.Next(min, max + 1);

            for (int i = 1; i < lenght; i++)
            {
                temp = r.Next(min, max + 1);
                for (int j = 0; j < CurrentLenght; j++)
                {
                    if (temp < array[j])
                    {
                        for (int k = CurrentLenght; k >= j; k--)
                        {
                            array[k] = array[k + 1];
                        }
                        array[j] = temp;
                        j = CurrentLenght;
                    }
                }
                CurrentLenght++;

            }
        }


        static void Main(string[] args)
        {
            int[] array = new int[100];
            int menuChoice, lenght, max, min, nextLenght;
            string userInput;
            bool continuare;

            Console.WriteLine("inserire lunghezza");
            lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("inserire massimo");
            max = int.Parse(Console.ReadLine());
            Console.WriteLine("inserire minimo");
            min = int.Parse(Console.ReadLine());
            CaricamentoRandom(ref array, lenght, max, min);


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
                Console.WriteLine("\nHai tre opzioni: \n1 - caricamento di un array di N elementi con numeri random compresi tra X e Y scelti dall'utente\n2 - troncamento di un array, data una dimensione Z inserita dall'utente (l'array viene ridotto alla dimensione Z)\n3 - aggiunta ordinata di numeri in un array (inserire il valore nella posizione corretta, mantenendo l'ordinamento ad ogni aggiunta)");
                menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice)
                {
                    case 0:
                        for (int i = 0; i < lenght; i++)
                        {
                            Console.Write(array[i]+"-");
                        }
                        
                        break;

                    case 1:
                        Console.WriteLine("inserire lunghezza");
                        lenght=int.Parse(Console.ReadLine());
                        Console.WriteLine("inserire massimo");
                        max = int.Parse(Console.ReadLine());
                        Console.WriteLine("inserire minimo");
                        min = int.Parse(Console.ReadLine());
                        CaricamentoRandom(ref array, lenght, max, min);
                        break;

                    case 2:
                        Console.WriteLine("inserire nuova lughezza");
                        nextLenght = int.Parse(Console.ReadLine());
                        CambiaLunghezza(ref array, ref lenght, nextLenght);
                        break;

                    case 3:
                        Console.WriteLine("inserire lunghezza");
                        lenght = int.Parse(Console.ReadLine());
                        Console.WriteLine("inserire massimo");
                        max = int.Parse(Console.ReadLine());
                        Console.WriteLine("inserire minimo");
                        min = int.Parse(Console.ReadLine());

                        

                        CaricamentoOrdinato(ref array, lenght, max, min);
                        break;
                }
            }
        }
    }
}
