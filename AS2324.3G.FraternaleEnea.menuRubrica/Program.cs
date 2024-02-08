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


            do
            {
                Console.WriteLine("\n\n Benvenuto nel menu scelta rubrica");
                Console.WriteLine("inserire 1 per l'inserimento di un nominativo completo");
                Console.WriteLine("inserire 2 per visualizare l'elenco di tutti i nominativi inseriti");
                Console.WriteLine("inserire 3 per trovare un nominativo in base al suo nickname");
                Console.WriteLine("inserire 9 per uscire dal menu rubrica");
                scelta = int.Parse(Console.ReadLine());
                switch (scelta)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                }

            } while (scelta != 9);


        }
    }
}