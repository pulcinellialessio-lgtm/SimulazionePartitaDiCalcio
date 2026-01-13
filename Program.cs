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
        static string eventiCasuali(ref int[] titolari1, ref int[] titolari2, ref int[] panchina1, ref int[] panchina2, ref int[] gialloTitolari1, ref int[] gialloTitolari2)
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
                    Console.WriteLine("Il giocatore numero " + InfortunioA + " è infortunato");
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
                    Console.WriteLine("Il giocatore numero " + InfortunioB + " è infortunato");
                }
                else
                {
                    titolari2[InfortunioB] = titolari2[InfortunioB] - 15;
                }
            }
            else if(Evento > 107 && Evento <= 111)
            {
                EventoCasuale = "Cartellino giallo squadra A";
                cartellinoGiallo(ref titolari1, ref titolari2, ref gialloTitolari1, ref gialloTitolari2, EventoCasuale);
            }
            else if(Evento > 111 && Evento <= 115)
            {
                EventoCasuale = "Cartellino giallo squadra B";
                cartellinoGiallo(ref titolari1, ref titolari2, ref gialloTitolari1, ref gialloTitolari2, EventoCasuale);

            }
            else if(Evento > 115 && Evento <= 119)
            { 
                EventoCasuale = "Cartellino rosso squadra A";

                int Rosso = rand.Next(0, titolari1.Length);
                titolari1[Rosso] = 0;
            }
            else if(Evento > 119 && Evento <= 123)
            {
                EventoCasuale = "Cartellino rosso squadra B";

                int Rosso = rand.Next(0, titolari2.Length);
                titolari2[Rosso] = 0;
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
        static string Gol(ref int[] titolari1, ref int[] titolari2, string EventoCasuale)
        {
            int Gol = 0;

            if(EventoCasuale == "Gol squadra A")
            {
                Gol = CalcoloForzaSquadra(titolari1) / (CalcoloForzaSquadra(titolari1) + CalcoloForzaSquadra(titolari2));
            }
            else if(EventoCasuale == "Gol squadra B")
            {
                Gol = CalcoloForzaSquadra(titolari2) / (CalcoloForzaSquadra(titolari1) + CalcoloForzaSquadra(titolari2));
            }

            return Gol.ToString();   //???????????????????????????????????????????????????????????????????????
        }
        static void cartellinoGiallo(ref int[] titolari1, ref int[] titolari2, ref int[] gialloTitolari1, ref int[] gialloTitolari2, string EventoCasuale)
        {
            Random rand = new Random();

            if (EventoCasuale == "Cartellino giallo squadra A")
            {
                int giallo = rand.Next(0, gialloTitolari1.Length);
                gialloTitolari1[giallo] = gialloTitolari1[giallo] + 1;
            }
            else if(EventoCasuale == "Cartellino giallo squadra B")
            {
                int giallo = rand.Next(0, gialloTitolari2.Length);
                gialloTitolari2[giallo] = gialloTitolari2[giallo] + 1;
            }
            
        }
        static void sostituzioni(ref int[] titolari, ref int[] panchina)
        {
            Random rand = new Random();
            int esce = rand.Next(0, titolari.Length);
            int entra = rand.Next(0, panchina.Length);
            int temp = titolari[esce];
            titolari[esce] = panchina[entra];
            panchina[entra] = temp;
        }
        static void Main(string[] args)
        {
            int[] titolari1 = new int[11];
            int[] titolari2 = new int[11];

            int[] panchina1 = new int[5];
            int[] panchina2 = new int[5];

            int[] gialloTitolari1 = new int[titolari1.Length];
            int[] gialloTitolari2 = new int[titolari2.Length];

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
