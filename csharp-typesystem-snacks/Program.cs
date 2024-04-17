namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------
            // Snack 1
            // -------

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
    }
}
