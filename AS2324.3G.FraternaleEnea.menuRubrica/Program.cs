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
                Console.WriteLine("inserire 5 per trovare i cognomi che inziano con una lettera che desideri");
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

                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(cognome[j] + "    ");
                            Console.Write(nome[j] + "    ");
                            Console.Write(simpatia[j] + "    ");
                            Console.Write(nickname[j] + "    ");
                            Console.Write(annoNascita[j] + "    ");
                            Console.Write(email[j]);
                        }

                        break;

                    case 3:
                        Console.WriteLine("inserisci il nickname della persona che vuoi cercare");
                        string tNickname = Convert.ToString(Console.ReadLine());
                        for(int j = 0; j < i; j++)
                        {
                            if (tNickname == nickname[j])
                            {
                                Console.WriteLine($"il nickname corrisponde alla persona con il seguente nominativo {cognome[j]} {nome[j]} {simpatia[j]} {annoNascita[j]} {email[j]} ");
                                
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
                        string cNome=Convert.ToString(Console.ReadLine());

                        for (int j = 0; j < nome.Length; j++)
                        {
                            
                            if (nome[j].ToLower()==cNome.ToLower())
                            {
                                Console.WriteLine($"il nominativo del della persona {nome[j]} è {cognome[j]} {simpatia[j]} {nickname[j]} {annoNascita[j]} {email[j]}");
                            }
                            else
                            {
                                Console.WriteLine("verificare che il nome esiste o se è scritto il maniera errata");
                            }
                        }

                        break; 
                    
                    case 5://sistemare il 5 case
                        Console.WriteLine("inserire l'iniziale del cognome che vuoi trovare");
                        string iCognome = Console.ReadLine().ToUpper();
                        if (cognome[i].StartsWith(iCognome)==true)
                        {
                            Console.WriteLine(cognome[i]);
                        }
                        else
                        {
                            Console.WriteLine("verificare che il nome esiste o se è scritto il maniera errata");
                        }
                        break; 
                    
                    case 6:


                        break;

                }

            } while (scelta != 9);
            Console.WriteLine("arrivederci");


        }
    }
}