using System.Security.Cryptography.X509Certificates;

namespace SimulazionePartitaDiCalcio
{
    internal class Program
    {
        static void forzaSquadra(int[] tit)
        {

            for (int i = 0; i < tit.Length; i++)
            {
                Console.WriteLine("Giocatore " + (i+1) + ":" + tit[i]);
            }
        }
        static void GenerazioneSquadre(int[] giocatori) 
        {
            Random rand = new Random();

            for (int i = 0; i < giocatori.Length; i++)
            {
                int Forzagiocatori = rand.Next(30, 101);
                giocatori[i] = Forzagiocatori;
            }
        }
        static int CalcoloForzaSquadra(int[] Giocatori)
        {
            int sommaTitolari = 0;

            for (int i = 0; i < Giocatori.Length; i++)
            {
                sommaTitolari = sommaTitolari + Giocatori[i];
            }

            return sommaTitolari;
        }
        static string eventiCasuali(ref int[] titolari1, ref int[] titolari2, ref int[] panchina1, ref int[] panchina2, ref int[] gialloTitolari1, ref int[] gialloTitolari2, ref int[] sostituzione1, ref int[] sostituzione2)
        {
            Random rand = new Random();
            int Evento = rand.Next(0, 131);

            int LimiteA = 0, LimiteB = 0;

            string EventoCasuale = "";

            if (Evento > 65 && Evento <= 71)
            {
                EventoCasuale = "Gol";
                Gol(ref titolari1, ref titolari2, ref panchina1, ref panchina2, EventoCasuale);

                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);

            }
            else if (Evento <= 65)
            {
                EventoCasuale = "Non accade niente la partita prosegue";
            }
            else if (Evento > 71 && Evento <= 75)
            {
                EventoCasuale = "Calo fisico squadra A";
                for (int i = 0; i < titolari1.Length; i++)
                {
                    if(titolari1[i] > 3)
                    {
                        titolari1[i] -= 3;
                    }
                    else
                    {
                        titolari1[i] = 0;
                    }
                }
                for (int i = 0; i < panchina1.Length; i++)
                {
                    if(panchina1[i] > 3)
                    {
                        panchina1[i] -= 3;
                    }
                    else
                    {
                        panchina1[i] = 0;
                    }
                }

                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);
            }
            else if (Evento > 75 && Evento <= 79)
            {
                EventoCasuale = "Calo fisico squadra B";
                for (int i = 0; i < titolari2.Length; i++)
                {
                    if(titolari2[i] > 3)
                    {
                        titolari2[i] -= 3;
                    }
                    else
                    {
                        titolari2[i] = 0;
                    }
                }
                for (int i = 0; i < panchina2.Length; i++)
                {
                    if(panchina2[i] > 3)
                    {
                        panchina2[i] -= 3;
                    }
                    else
                    {
                        panchina2[i] = 0;
                    }
                }

                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);
            }
            else if (Evento > 79 && Evento <= 103)
            {
                int InfortunioA = rand.Next(0, titolari1.Length);

                EventoCasuale = "Infortunio giocatore squadra A";

                if (titolari1[InfortunioA] < 15)
                {
                    titolari1[InfortunioA] = 0;
                    Console.WriteLine("Il giocatore numero " + (InfortunioA + 1) + " è infortunato");
                }
                else
                {
                    titolari1[InfortunioA] = titolari1[InfortunioA] - 15;
                    Console.WriteLine("Il giocatore numero " + (InfortunioA + 1) + " è infortunato");

                }

                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);
            }
            else if (Evento > 103 && Evento <= 107)
            {
                int InfortunioB = rand.Next(0, titolari2.Length);

                EventoCasuale = "Infortunio giocatore squadra B";

                if (titolari2[InfortunioB] < 15)
                {
                    titolari2[InfortunioB] = 0;
                    Console.WriteLine("Il giocatore numero " + (InfortunioB + 1) + " è infortunato");
                }
                else
                {
                    titolari2[InfortunioB] = titolari2[InfortunioB] - 15;
                    Console.WriteLine("Il giocatore numero " + (InfortunioB + 1) + " è infortunato");
                }
                
                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);
            }
            else if(Evento > 107 && Evento <= 111)
            {
                EventoCasuale = "Cartellino giallo squadra A";
                cartellinoGiallo(ref titolari1, ref titolari2, ref gialloTitolari1, ref gialloTitolari2, EventoCasuale);

                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);
            }
            else if(Evento > 111 && Evento <= 115)
            {
                EventoCasuale = "Cartellino giallo squadra B";
                cartellinoGiallo(ref titolari1, ref titolari2, ref gialloTitolari1, ref gialloTitolari2, EventoCasuale);

                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);

            }
            else if(Evento > 115 && Evento <= 119)
            { 
                EventoCasuale = "Cartellino rosso squadra A";

                int Rosso = rand.Next(0, titolari1.Length);
                titolari1[Rosso] = 0;

                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);
            }
            else if(Evento > 119 && Evento <= 123)
            {
                EventoCasuale = "Cartellino rosso squadra B";

                int Rosso = rand.Next(0, titolari2.Length);
                titolari2[Rosso] = 0;

                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);
            }
            else if(Evento > 123 && Evento <= 127)
            {
                LimiteA++;
                EventoCasuale = "Sostituzione squadra A";
                sostituzioni(titolari1, panchina1, sostituzione1, EventoCasuale, LimiteA);

                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);
            }
            else if(Evento > 127 && Evento <= 130)
            {
                LimiteB++;
                EventoCasuale = "Sostituzione squadra B";
                sostituzioni(titolari2, panchina2, sostituzione2, EventoCasuale, LimiteB);

                Console.WriteLine("Forza squadra A:");
                forzaSquadra(titolari1);

                Console.WriteLine("Forza squadra B:");
                forzaSquadra(titolari2);
            }

             return EventoCasuale;
        }
        static string Gol(ref int[] titolari1, ref int[] titolari2,ref int[] panchina1, ref int[] panchina2, string EventoCasuale)
        {
            Random rand = new Random();
            int Gol = 0;

            Gol = CalcoloForzaSquadra(titolari1) / (CalcoloForzaSquadra(titolari1) + CalcoloForzaSquadra(titolari2));
            int probabilitàGol = rand.Next(0, 101);

            if(probabilitàGol > (Gol * 10))
            {
                Console.WriteLine("Gol segnato dalla squadra A!");
                for (int i = 0; i < titolari1.Length; i++)
                {
                    titolari1[i] += 5;
                }
                for (int i = 0; i < panchina1.Length; i++)
                {
                    panchina1[i] += 5;
                }

                string risultato = "Gol squadra A";
                return risultato;
            }
            else
            {
                Console.WriteLine("Gol segnato dalla squadra B!");
                for (int i = 0; i < titolari2.Length; i++)
                {
                    titolari2[i] += 5;
                }
                for (int i = 0; i < panchina2.Length; i++)
                {
                    panchina2[i] += 5;
                }

                string risultato = "Gol squadra B";
                return risultato;
            }

        }
        static string cartellinoGiallo(ref int[] titolari1, ref int[] titolari2, ref int[] gialloTitolari1, ref int[] gialloTitolari2, string EventoCasuale)
        {
            Random rand = new Random();

            if (EventoCasuale == "Cartellino giallo squadra A")
            {
                int giallo = rand.Next(0, gialloTitolari1.Length);
                gialloTitolari1[giallo] = gialloTitolari1[giallo] + 1;
                if(gialloTitolari1[giallo] == 2)
                {
                    titolari1[giallo] = 0;
                    Console.WriteLine("Il giocatore numero " + giallo + " della squadra A è stato espulso per doppio cartellino giallo");
                }

                string Giallo = "Cartellino giallo squadra A";
                return Giallo;
            }
            else
            {
                int giallo = rand.Next(0, gialloTitolari2.Length);
                gialloTitolari2[giallo] = gialloTitolari2[giallo] + 1;
                if (gialloTitolari2[giallo] == 2)
                {
                    titolari2[giallo] = 0;
                    Console.WriteLine("Il giocatore numero " + giallo + " della squadra B è stato espulso per doppio cartellino giallo");
                }

                string Giallo = "Cartellino giallo squadra B";
                return Giallo; 
            }
        }
        static void sostituzioni(int[] titolari, int[] panchina, int[] sost, string eventoCasuale, int Limite)
        {
            Random rand = new Random();

            int max = 0, min = 10000, l = 0, s = 0;

            if(Limite <= 5)
            {
                for(int i = 0; i < panchina.Length; i++)
                {
                    if(max < panchina[i])
                    {
                        max = panchina[i];
                        l = i;
                    }
                }

                sost[0] = max;
                panchina[l] = 0;

                for(int j = 0; j < titolari.Length; j++)
                {
                    if(min > titolari[j])
                    {
                        min = titolari[j];
                        s = j;  
                    }
                }

                panchina[l] = titolari[s];
                titolari[s] = 0;
                titolari[s] = sost[0];
            }
            else
            {
                Console.WriteLine("Limite sostituzioni raggiunto");
            }
        }
        static void statistiche(string EventoCasuale, string risultato, string Giallo, ref int[] titolari1, ref int[] titolari2)
        {
            int GolA = 0, GolB = 0, rossiA = 0, rossiB = 0, gialloA = 0, gialloB = 0, sosA = 0, sosB = 0, infA = 0, infB = 0;

            if (risultato == "Gol squadra A")
            {
                GolA++;
            }
            else if (risultato == "Gol squadra B")
            {
                GolB++;
            }
            else if (EventoCasuale == "Cartellino rosso squadra A")
            {
                rossiA++;
            }
            else if (EventoCasuale == "Cartellino rosso squadra B")
            {
                rossiB++;
            }
            else if(Giallo == "Cartellino giallo squadra A")
            {
                gialloA++;
            }
            else if(Giallo == "Cartellino giallo squadra B")
            {
                gialloB++;
            }
            else if(EventoCasuale == "Sostituzione squadra A")
            {
                sosA++;
            }
            else if(EventoCasuale == "Sostituzione squadra B")
            {
                sosB++;
            }
            else if(EventoCasuale == "Infortunio giocatore squadra A")
            {
                infA++;
            }
            else if(EventoCasuale == "Infortunio giocatore squadra B")
            {
                infB++;
            }

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("|                         Squadra A           Squadra B       |");
            Console.WriteLine("|  Gol:                  " + GolA + "        " + GolB + "     |");
            Console.WriteLine("|  Cartellini gialli:    " + gialloA + "     " + gialloB + "  |");
            Console.WriteLine("|  Cartellini rossi:     " + rossiA + "      " + rossiB + "   |");
            Console.WriteLine("|  Sostituzioni:         " + sosA + "        " + sosB + "     |");
            Console.WriteLine("|  Infortuni:            " + infA + "        " + infB + "     |");
            Console.WriteLine("|  Potenza finale:       " + CalcoloForzaSquadra(titolari1) + " " + CalcoloForzaSquadra(titolari2) + " |");
            Console.WriteLine("---------------------------------------------------------------");
        }
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] titolari1 = new int[11];
            int[] titolari2 = new int[11];

            int[] panchina1 = new int[5];
            int[] panchina2 = new int[5];

            int[] gialloTitolari1 = new int[titolari1.Length];
            int[] gialloTitolari2 = new int[titolari2.Length];

            int[] sostituzione1 = new int[2];
            int[] sostituzione2 = new int[2];

            GenerazioneSquadre(titolari1);
            GenerazioneSquadre(titolari2);
            GenerazioneSquadre(panchina1);
            GenerazioneSquadre(panchina2);

            CalcoloForzaSquadra(titolari1);
            CalcoloForzaSquadra(titolari2);

            int tempo = 90;
            int recupero = 0;

            recupero = rand.Next(1, 6);

            tempo = tempo + recupero;

            for (int i = 0; i < tempo; i++)
            {
                Console.WriteLine("Minuto " + (i + 1) + ":" + eventiCasuali(ref titolari1, ref titolari2, ref panchina1, ref panchina2, ref gialloTitolari1, ref gialloTitolari2, ref sostituzione1, ref sostituzione2));
                Console.ReadLine();

                if (i == 89)
                {
                    Console.WriteLine("Il recupero è di " + recupero + " minuti");
                }
            }

            Console.WriteLine("Fine partita");
        }
        
    }
}
