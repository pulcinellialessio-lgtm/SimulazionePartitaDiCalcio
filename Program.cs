using System.Security.Cryptography.X509Certificates;

namespace SimulazionePartitaDiCalcio
{
    internal class Program
    {
        static void GenerazioneSquadre(int[] giocatori) 
        {
            Random rand = new Random();

            for (int i = 0; i < giocatori.Length; i++)
            {
                int Forzagiocatori = rand.Next(30, 101);
                giocatori[i] = Forzagiocatori;
                Console.WriteLine("Forza giocatore numero " + i + ":" + Forzagiocatori);
            }
        }
        static int CalcoloForzaSquadra(int[] Giocatori)
        {
            int sommaTitolari = 0;

            for (int i = 0; i < Giocatori.Length; i++)
            {
                sommaTitolari = sommaTitolari + Giocatori[i];
            }

            Console.WriteLine("la forza della squadra è: " + sommaTitolari);

            return sommaTitolari;
        }
        static string eventiCasuali(int[] titolari1, int[] titolari2, int[] panchina1, int[] panchina2)
        {
            Random rand = new Random();
            int Evento = rand.Next(0, 131);

            string EventoCasuale = "";

            if (Evento > 65 && Evento <= 68)
            {
                EventoCasuale = "Gol squadra A";
                for (int i = 0; i < titolari1.Length; i++)
                {
                    titolari1[i] += 5;
                }
                for (int i = 0; i < panchina1.Length; i++)
                {
                    panchina1[i] += 5;
                }
            }
            else if (Evento > 68 && Evento <= 71)
            {
                EventoCasuale = "Gol squadra B";
                for (int i = 0; i < titolari2.Length; i++)
                {
                    titolari2[i] += 5;
                }
                for (int i = 0; i < panchina2.Length; i++)
                {
                    panchina2[i] += 5;
                }
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
                    titolari1[i] -= 3;
                }
                for (int i = 0; i < panchina1.Length; i++)
                {
                    panchina1[i] -= 3;
                }
            }
            else if (Evento > 75 && Evento <= 79)
            {
                EventoCasuale = "Calo fisico squadra B";
                for (int i = 0; i < titolari2.Length; i++)
                {
                    titolari2[i] -= 3;
                }
                for (int i = 0; i < panchina2.Length; i++)
                {
                    panchina2[i] -= 3;
                }
            }
            else if (Evento > 79 && Evento <= 103)
            {
                EventoCasuale = "Infortunio giocatore squadra A";

                int InfortunioA = rand.Next(0, titolari1.Length);

                if (titolari1[InfortunioA] < 15)
                {
                    titolari1[InfortunioA] = 0;
                }
                else
                {
                    titolari1[InfortunioA] = titolari1[InfortunioA] - 15;
                }

            }
            else if (Evento > 103 && Evento <= 107)
            {
                EventoCasuale = "Infortunio giocatore squadra B";

                int InfortunioB = rand.Next(0, titolari2.Length);

                if (titolari2[InfortunioB] < 15)
                {
                    titolari2[InfortunioB] = 0;
                }
                else
                {
                    titolari2[InfortunioB] = titolari2[InfortunioB] - 15;
                }
            }
            else if(Evento > 107 && Evento <= 111)
            {
                EventoCasuale = "Cartellino giallo squadra A";
            }
            else if(Evento > 111 && Evento <= 115)
            {
                EventoCasuale = "Cartellino giallo squadra B";
            }
            else if(Evento > 115 && Evento <= 119)
            {
                EventoCasuale = "Cartellino rosso squadra A";
            }
            else if(Evento > 119 && Evento <= 123)
            {
                EventoCasuale = "Cartellino rosso squadra B";
            }
            else if(Evento > 123 && Evento <= 127)
            {
                EventoCasuale = "Sostituzione squadra A";
            }
            else if(Evento > 127 && Evento <= 130)
            {
                EventoCasuale = "Sostituzione squadra B";
            }

             return EventoCasuale;
        }
        static string Gol(int[] titolari1, int[] titolari2, string EventoCasuale)
        {
            int Gol = 0;

            if(EventoCasuale == "Gol squadra A")
            {
                Gol = CalcoloForzaSquadra(titolari1) / (CalcoloForzaSquadra(titolari1) + CalcoloForzaSquadra(titolari2));
            }
        }
        static void Main(string[] args)
        {
            int[] titolari1 = new int[11];
            int[] titolari2 = new int[11];

            int[] panchina1 = new int[5];
            int[] panchina2 = new int[5];

            GenerazioneSquadre(titolari1);
            GenerazioneSquadre(titolari2);
            GenerazioneSquadre(panchina1);
            GenerazioneSquadre(panchina2);

            CalcoloForzaSquadra(titolari1);
            CalcoloForzaSquadra(titolari2);

            for (int i = 0; i < 90; i++)
            {
                Console.WriteLine("Minuto " + (i+1) + ":" + eventiCasuali(titolari1, titolari2, panchina1, panchina2));
                Console.ReadLine();
            }
        }
    }
}
