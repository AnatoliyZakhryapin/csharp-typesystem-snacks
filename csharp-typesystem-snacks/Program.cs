using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Seleziona uno snack da eseguire:");
                Console.WriteLine("1. Snack 1");
                Console.WriteLine("2. Snack 2");
                Console.WriteLine("3. Snack 3");
                Console.WriteLine("4. Snack 4");
                Console.WriteLine("5. Snack 5");
                Console.WriteLine("6. Snack 6");
                Console.WriteLine("7. Snack 7");
                Console.WriteLine("8. Snack 8");
                Console.WriteLine("9. Snack 9");
                Console.WriteLine("10. Snack 10");
                // Aggiungi altri snack qui

                Console.WriteLine("0. Esci");

                // Leggi l'input dell'utente
                string input = Console.ReadLine();

                // Converte l'input in un numero intero
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 0:
                            // Uscita dal programma
                            return;
                        case 1:
                            Snack1();
                            break;
                        case 2:
                            Snack2();
                            break;
                        case 3:
                            Snack3();
                            break;
                        case 4:
                            Snack4();
                            break;
                        case 5:
                            Snack5();
                            break;
                        case 6:
                            Snack6();
                            break;
                        case 7:
                            Snack7();
                            break;
                        case 8:
                            Snack8();
                            break;
                        case 9:
                            Snack9();
                            break;
                        case 10:
                            Snack10();
                            break;
                        // Aggiungi altri casi per gli altri snack
                        default:
                            Console.WriteLine("Scelta non valida. Riprova.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input non valido. Riprova.");
                }
            }

            static void Snack1()
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
                            // number2 = int.Parse(userInput);
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
            }

            static void Snack2()
            {
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
            }

            static void Snack3()
            {
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
            }

            static void Snack4()
            {
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
            }

            static void Snack5()
            {
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
            }

            static void Snack6()
            {

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

                        // Convertiamo il nome dell'utente in minuscolo per uniformità
                        userInput = userInput.ToLower();

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

                    // Convertiamo i nomi dei partecipanti in minuscolo per uniformità
                    participants = Array.ConvertAll(participants, p => p.ToLower());

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
            }

            static void Snack7()
            {
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
            }

            static void Snack8()
            {
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

            static void Snack9()
            {
                // -------
                // Snack 9
                // -------

                {
                    Console.WriteLine("Snack9");

                    // Creiamo le variabile
                    int[] numbers = new int[0];
                    int sum = 0;
                    int number;

                    // Continua a chiedere i numeri all'utente e inserirli nell'array finché la somma degli elementi è minore di 50
                    while (sum < 50)
                    {
                        // Chiediamo inserire un numero al utente
                        Console.WriteLine("Inserisci il secondo numero:");

                        // Salviamo input 
                        string userInput = Console.ReadLine();

                        try
                        {
                            number = Convert.ToInt32(userInput);

                            // Estendiamo l'array e aggiungiamo il numero inserito
                            Array.Resize(ref numbers, numbers.Length + 1);
                            numbers[numbers.Length - 1] = number;

                            // Aggiorniamo la somma degli elementi nell'array
                            sum = numbers.Sum();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Errore di formato. Inserisci un numero valido, NON puo contenere le lettere o simboli!.");
                        }
                    }

                    // Stampiamo che la somma e maggiore di 50
                    if (sum > 50)
                    {
                        Console.WriteLine("La somma è piu grande di 50");
                        Console.WriteLine($"La somma del array è: {sum}");
                    }
                }
            }

            static void Snack10()
            {
                // -------
                // Snack 10
                // -------

                {
                    Console.WriteLine("Snack10");


                    // Chiediamo di inserire un numero all'utente
                    Console.WriteLine("Inserisci un numero:");

                    // Salviamo il numero inserito dall'utente come un int
                    int N = int.Parse(Console.ReadLine());

                    // Se il numero inserito è negativo, ne calcoliamo il valore assoluto
                    N = Math.Abs(N);

                    // Creamo una istanza del Random
                    Random randomNumber = new Random();

                    // Facciamo ciclo per creare N quantita dei array
                    for (int i = 1; i <= N; i++)
                    {
                        // Creamo array
                        int[] array = new int[10];

                        // Stampiamo il numero del Array creato
                        Console.WriteLine($"Array {i}:");

                        // Andiamo cambiare i valori dei numeri del nostro array con i numeri random da 1 a 100
                        for (int j = 0; j < array.Length; j++)
                        {
                            array[j] = randomNumber.Next(1, 101);
                            Console.Write(array[j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
