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
            string[] email = new string[100];
            int i = 0;


            do
            {
                Console.WriteLine("\n\nBenvenuto nel menu scelta rubrica");
                Console.WriteLine("inserire 1 per l'inserimento di un nominativo completo");
                Console.WriteLine("inserire 2 per visualizare l'elenco di tutti i nominativi inseriti");
                Console.WriteLine("inserire 3 per trovare un nominativo in base al suo nickname");
                Console.WriteLine("inserire 4 per trovare tutte le persone con il nome inserito");
                Console.WriteLine("inserire 5 per trovare i cognomi che inziano con una lettera che vuoi");
                Console.WriteLine("inserire 6 per trovare i cognomi che contengono il dato ricercato");
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

                        } while (simpatia[i] < 1 || simpatia[i] > 5);
                        
                        Console.WriteLine($"inserisci il nickname della persona numero {i + 1}");
                        nickname[i] = Convert.ToString(Console.ReadLine());
                        
                        Console.WriteLine($"inserisci l'anno di nascita della persona numero {i + 1}");
                        annoNascita[i] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"inserisci l'email della persona numero {i + 1}");
                        email[i] = Convert.ToString(Console.ReadLine());

                        i++;

                        break;

                    case 2:
                        Console.WriteLine("benvenuto, vuoi visualizzare la tua rubrica");

                        Console.WriteLine("\ncognome    nome    simpatia    nickname    anno di nascita    email");

                        for (int i2 = 0; i2 < i; i2++)
                        {
                            Console.Write(cognome[i2] + "    ");
                            Console.Write(nome[i2] + "    ");
                            Console.Write(simpatia[i2] + "    ");
                            Console.Write(nickname[i2] + "    ");
                            Console.Write(annoNascita[i2] + "    ");
                            Console.Write(email[i2]);
                        }

                        break;

                    case 3:
                        Console.WriteLine("inserisci il nickname della persona che vuoi cercare");
                        string tNickname = Convert.ToString(Console.ReadLine());
                        for(int i3 = 0; i3 < i; i3++)
                        {
                            if (tNickname == nickname[i3])
                            {
                                Console.WriteLine($"il nickname corrisponde alla persona con il seguente nominativo {cognome[i3]} {nome[i3]} {simpatia[i3]} {annoNascita[i3]} {email[i3]} ");
                                
                            }
                            else
                            {
                                Console.WriteLine("persona non trovata");
                                Console.WriteLine("verificare se il nickname è esistente o se è scritto in maniera errata");
                            }
                        }


                        break;

                    case 4:
                        Console.WriteLine("inserisci il nome che vuoi ricercare");
                        string tNome = Console.ReadLine().ToUpper();
                        for (int i4 = 0; i4 < i; i4++)
                        {
                            if (tNome == nome[i4])
                            {
                                Console.WriteLine($"il nome corrisponde alla persona con le seguenti informazioni {cognome[i4]} {simpatia[i4]} {simpatia[i4]} {annoNascita[i4]} {email[i4]} ");

                            }
                            else
                            {
                                Console.WriteLine("verificare che il nome esiste o se è scritto il maniera errata");
                            }
                        }

                        break; 
                    
                    case 5:

                       
                        break; 
                    
                    case 6:


                        break;

                }

            } while (scelta != 9);
            Console.WriteLine("arrivederci");


        }
    }
}