namespace AS2324._3G.FraternaleEnea.menuRubrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fraternale Meloni Enea 3G  08/02/2024");
            Console.WriteLine("esercizio rubrica");



            int scelta;
            string[] cognome = new string[100];
            string[] nome = new string[100];
            int[] simpatia = new int[100];
            string[] nickname = new string[100];
            int[] annoNascita = new int[100];
            int i = 0;


            do
            {
                Console.WriteLine("\n\nBenvenuto nel menu scelta rubrica");
                Console.WriteLine("inserire 1 per l'inserimento di un nominativo completo");
                Console.WriteLine("inserire 2 per visualizare l'elenco di tutti i nominativi inseriti");
                Console.WriteLine("inserire 3 per trovare un nominativo in base al suo nickname");
                Console.WriteLine("inserire 9 per uscire dal menu rubrica");
                scelta = int.Parse(Console.ReadLine());
                switch (scelta)
                {
                    case 1: //TODO: campi obbligatori e facoltativi
                        Console.WriteLine("benvenuto nell'inserimento di un nominativo completo all'interno della rubrica");
                        
                        Console.WriteLine($"inserisci il cognome della persona numero {i + 1}");
                        cognome[i] = Convert.ToString(Console.ReadLine());

                        Console.WriteLine($"inserisci il nome della persona numero {i + 1}");
                        nome[i] = Convert.ToString(Console.ReadLine());

                        Console.WriteLine($"inserisci il livello di simpatia della persona numero {i + 1}");
                        Console.WriteLine("il livello di simpatia va da 1 a 5");
                        do
                        {
                            simpatia[i] = Convert.ToInt32(Console.ReadLine());

                        } while (simpatia[i] > 1 || simpatia[i] < 5);
                        
                        Console.WriteLine($"inserisci il nikname della persona numero {i + 1}");
                        nickname[i] = Convert.ToString(Console.ReadLine());
                        
                        Console.WriteLine($"inserisci l'anno di nascita della persona numero {i + 1}");
                        annoNascita[i] = Convert.ToInt32(Console.ReadLine());

                        i++;

                        break;

                    case 2:
                        


                        break;

                    case 3:

                        break;

                }

            } while (scelta != 9);
            Console.WriteLine("arrivederci");


        }
    }
}