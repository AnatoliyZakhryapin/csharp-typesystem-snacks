using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------
            // Snack 1
            // -------

            {
                Console.WriteLine("Snack 1");

                int number1 = 0;
                int number2 = 0;

                // Recuperiamo il primo numero, si fa il ciclo finche non riusciamo assegnare a number1 un valore numerico.
                while (true)
                {
                    // Chiediamo inserire un numero al utente
                    Console.WriteLine("Inserisci il primo numero:");

                    // Salviamo input 
                    string userInput = Console.ReadLine();

                    // Proviamo ad assegnare a number1 il valore del userInput, se viene eseguito assegnazione - si esce dal ciclo tramite break.
                    try
                    {
                        //number1 = int.Parse(userInput);
                        number1 = Convert.ToInt32(userInput);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Errore di formato. Inserisci un numero valido, NON puo contenere le lettere o simboli!.");
                    }
                }

                // Recuperiamo il secondo numero, si fa il ciclo finche non riusciamo assegnare a number2 un valore numerico.
                while (true)
                {
                    // Chiediamo inserire un numero al utente
                    Console.WriteLine("Inserisci il secondo numero:");

                    // Salviamo input 
                    string userInput = Console.ReadLine();

                    // Proviamo ad assegnare a number1 il valore del userInput, se viene eseguito assegnazione - si esce dal ciclo tramite break.
                    try
                    {
                        //number2 = int.Parse(userInput);
                        number2 = Convert.ToInt32(userInput);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Errore di formato. Inserisci un numero valido, NON puo contenere le lettere o simboli!.");
                    }
                }

                // Stampiamo i resultati 
                Console.WriteLine("I numeri inseriti sono:");
                Console.WriteLine($"number1 = {number1}");
                Console.WriteLine($"number2 = {number2}");

                // Stabiliamo il numero maggiore
                int maxNumber = Math.Max(number1, number2);

                // Stampiamo la risposta tramite if esle
                //if (maxNumber == number1)
                //{
                //    Console.WriteLine("Number1 è maggiore");
                //} 
                //else
                //{
                //    Console.WriteLine("Number2 è maggiore");
                //}

                // Stampiamo la risposta tramite switch
                switch (maxNumber)
                {
                    case int value when value == number1:
                        Console.WriteLine("Number1 è maggiore");
                        break;
                    case int value when value == number2:
                        Console.WriteLine("Number2 è maggiore");
                        break;
                }
            }

            // -------
            // Snack 2
            // -------

            {
                Console.WriteLine("Snack 2");

                string word1, word2;

                // Recuperiamo la prima parola, si fa il ciclo finche non riusciamo assegnare a word1 il valore correto.
                while (true)
                {
                    // Chiediamo inserire la prima parola all'utente
                    Console.WriteLine("Inserisci la prima parola:");

                    // Salviamo input 
                    string userInput = Console.ReadLine();

                    // Verifichiamo se la stringa non è vuota e contiene almeno un carattere alfabetico
                    if (!string.IsNullOrEmpty(userInput) && userInput.Any(char.IsLetter))
                    {
                        word1 = userInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Errore. Inserisci una parola valida (senza numeri o simboli). La parola deve contenere almeno una lettera.");
                    }
                }

                // Recuperiamo la seconda parola, si fa il ciclo finche non riusciamo assegnare a word2 il valore correto.
                while (true)
                {
                    // Chiediamo inserire la seconda parola all'utente
                    Console.WriteLine("Inserisci la seconda parola:");

                    // Salviamo input 
                    string userInput = Console.ReadLine();

                    // Verifichiamo se la stringa non è vuota e contiene almeno un carattere alfabetico
                    if (!string.IsNullOrEmpty(userInput) && userInput.Any(char.IsLetter))
                    {
                        word2 = userInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Errore. Inserisci una parola valida (senza numeri o simboli). La parola deve contenere almeno una lettera.");
                    }
                }

                // Verifichiamo la lunghezza di ogni parola
                int word1Length = word1.Length;
                int word2Length = word2.Length;

                string wordShorter = (word1Length > word2Length) ? word2 : word1;
                string wordLonger = (word1Length > word2Length) ? word1 : word2;

                // Stampiamo il risultato
                Console.WriteLine($"La parola piu corta è {wordShorter}");
                Console.WriteLine($"La parola piu lunga è {wordLonger}");
            }

            // -------
            // Snack 3
            // -------

            {
                Console.WriteLine("Snack 3");

                // Creamo la variabile index per gestire il ciclo while
                int index = 0;

                // Creamo il nostro array con 10 numeri di defaul = 0;
                int[] inputNumbers = new int[10];

                // Facciamo ciclo perassegnare i valori del input a nostro array inputNumbers
                while (index < 10)
                {
                    // Chiediamo inserire un numero al utente
                    Console.WriteLine($"Inserisci il numero {index + 1}:");

                    // Salviamo il valore del input
                    string userInput = Console.ReadLine();

                    // Creamo la variabile number che servira per assegnare il valore del input al inputNumbers
                    int number;

                    // Se il valore del input e un numero la condizione restituisce true e number prendera il valore del userUnput
                    if (int.TryParse(userInput, out number))
                    {
                        // Aggiornuamo il valore del inputNumbers
                        inputNumbers[index] = number;

                        // Aumentiamo il nostro indice
                        index++;
                    }
                    else
                    {
                        Console.WriteLine("Input non valido. Inserisci un numero valido.");
                    };
                };

                // Calcoliamo la somma dei numeri
                int sum = inputNumbers.Sum();

                // Stampiamo la somma 
                Console.WriteLine($"La somma di tutti numeri è: {sum}");
            }

            // -------
            // Snack 4
            // -------

            {
                Console.WriteLine("Snack 4");

                // Creamo le variabili 
                int sum = 0;
                int count = 0;
                double average;

                // Facciamo il ciclo da 2 a 10 per calcolare sum e aggiornare count
                for (int i = 2; i <= 10; i++)
                {
                    // Aggiorniamo la variabile sum
                    sum += i;

                    // Aggiorniamo il count
                    count++;
                }

                average = sum / count;

                Console.WriteLine($"La somma dei numeri da 2 a 10 é: {sum}");
                Console.WriteLine($"La media dei numeri da 2 a 10 é: {average}");
            }

            // -------
            // Snack 5
            // -------

            {
                Console.WriteLine("Snack 5");

                // Creamo la variabile number
                int number;

                // Facciamo il ciclo finche l'utente non inserisce un numero
                while (true)
                {
                    // Chiediamo inserire un numero al utente
                    Console.WriteLine("Inserisci un numero:");

                    // Salviamo input 
                    string userInput = Console.ReadLine();

                    // Proviamo ad assegnare a number il valore del userInput, se viene eseguito assegnazione - si esce dal ciclo tramite break.
                    try
                    {
                        number = Convert.ToInt32(userInput);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Errore di formato. Inserisci un numero valido, NON puo contenere le lettere o simboli!.");
                    }
                }

                // Controlliamo se il numero e pari
                bool isOdd = number % 2 == 0 ? true : false;

                // Stampiamo la risposta
                switch (isOdd)
                {
                    // Se numero e pari
                    case true:
                        Console.WriteLine("Number è pari!");
                        Console.WriteLine($"Il valore del Number è: {number}");
                        break;
                    // Se numero e dispari
                    case false:
                        Console.WriteLine("Number è dispari!");
                        Console.WriteLine($"Il valore succesivo del Number è: {number + 1}");
                        break;
                }
            }

            // -------
            // Snack 6
            // -------

            {
                Console.WriteLine("Snack 6");

                // Creamo array dei partecipanti
                string[] participants = { "Anatoliy", "Federico", "Andrea", "Matteo" };

                // Creamo la variabile userName
                string userName;

                // Recuperiamo il nome dell'uttente, si fa il ciclo finche utente non da un nome adeguato (non deve essere i numeri o vuoto)
                while (true)
                {
                    // Chiediamo inserire il nome all'utente
                    Console.WriteLine("Inserisci il tuo nome:");

                    // Salviamo input 
                    string userInput = Console.ReadLine();

                    // Verifichiamo se la stringa non è vuota e contiene non contiene i numeri
                    if (!string.IsNullOrEmpty(userInput) && userInput.All(char.IsLetter))
                    {
                        userName = userInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Errore. Inserisci il nome valido (senza numeri o simboli). La parola deve contenere almeno una lettera.");
                    }
                }

                // Controlliamo se puo partecipare
                bool isCanPartecipate = participants.Contains(userName);

                // Se è presente nella lista diamo il Benvenuto
                if (isCanPartecipate)
                {
                    Console.WriteLine("Benvenuto alla festa!!!");
                }
                else
                {
                    Console.WriteLine("Ci dispiace ma non sei presente nella lista dei partecipanti");
                }
            }

            // -------
            // Snack 7
            // -------

            {
                Console.WriteLine("Snack7");

                // Creamo la variabile index per gestire il ciclo while
                int index = 0;

                // Creamo il nostro array
                string[] inputNumbers = new string[6];

                // Facciamo ciclo per assegnare i valori del input a nostro array inputNumbers
                while (index < 6)
                {
                    // Chiediamo inserire un numero al utente
                    Console.WriteLine($"Inserisci il numero {index + 1}° :");

                    // Salviamo il valore del input
                    string userInput = Console.ReadLine();

                    // Creamo la variabile number che servira per assegnare il valore del input al inputNumbers
                    int number;

                    // Se il valore del input e un numero la condizione restituisce true e number prendera il valore del userUnput
                    if (int.TryParse(userInput, out number))
                    {
                        // Aggiornuamo il valore del inputNumbers solo se e dispari
                        if (number % 2 != 0)
                        {
                            inputNumbers[index] = userInput;
                        }

                        // Aumentiamo il nostro indice
                        index++;
                    }
                    else
                    {
                        Console.WriteLine("Input non valido. Inserisci un numero valido.");
                    }
                };

                // Stampiamo il nostro array inputNumbers
                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    Console.WriteLine($"Numero {i + 1}° è: {inputNumbers[i]}");
                }
            }

            // -------
            // Snack 8
            // -------

            {
                Console.WriteLine("Snack8");

                // Creiamo un array di numeri interi da 1 a 100
                int[] numbers = new int[100];

                // Popoliamo l'array con i numeri da 1 a 100
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = i + 1;
                }

                // Variabile per memorizzare la somma degli elementi in posizione dispari
                int sumNumberWithOddPosition = 0;

                // Cicliamo array e sommiamo gli elementi in posizione dispari
                for (int i = 1; i < numbers.Length; i += 2)
                {
                    sumNumberWithOddPosition += numbers[i];
                }

                // Stampiamo la somma
                Console.WriteLine($"La somma dei numeri con posizione dispari è: {sumNumberWithOddPosition}");
            }
        }
    }
}
