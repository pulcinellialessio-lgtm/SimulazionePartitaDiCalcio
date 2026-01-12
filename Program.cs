namespace SimulazionePartitaDiCalcio
{
    internal class Program
    {
        static void GenerazioneSquadre(int[] titolari1, int[] titolari2, int[] panchina1, int[] panchina2)
        {
            Random rand = new Random();

            for (int i = 0; i < titolari1.Length; i++)
            {
                int ForzaTitolari1 = rand.Next(30, 101);
                titolari1[i] = ForzaTitolari1;
                Console.WriteLine("Forza giocatore titolare 1 numero " + i + ":" + ForzaTitolari1);
            }

            for (int i = 0; i < titolari2.Length; i++)
            {
                int ForzaTitolari2 = rand.Next(30, 101);
                titolari2[i] = ForzaTitolari2;
                Console.WriteLine("Forza giocatore titolare 2 numero " + i + ":" + ForzaTitolari2);
            }

            for (int i = 0; i < panchina1.Length; i++)
            {
                int ForzaPanchina1 = rand.Next(30, 101);
                panchina1[i] = ForzaPanchina1;
                Console.WriteLine("Forza giocatore panchina 1 numero " + i + ":" + ForzaPanchina1);
            }

            for (int i = 0; i < panchina2.Length; i++)
            {
                int ForzaPanchina2 = rand.Next(30, 101);
                panchina2[i] = ForzaPanchina2;
                Console.WriteLine("Forza giocatore panchina 2 numero " + i + ":" + ForzaPanchina2);
            }

            CalcoloForzaSquadra1(titolari1);
            CalcoloForzaSquadra2(titolari2);
        }
        static int CalcoloForzaSquadra1(int[] titolari1)
        {
            int sommaTitolari1 = 0;

            for (int i = 0; i < titolari1.Length; i++)
            {
                sommaTitolari1 = sommaTitolari1 + titolari1[i];
            }

            Console.WriteLine("la forza della squadra 1 è: " + sommaTitolari1);

            return sommaTitolari1;
        }
        static int CalcoloForzaSquadra2(int[] titolari2)
        {
            int sommaTitolari2 = 0;

            for (int i = 0; i < titolari2.Length; i++)
            {
                sommaTitolari2 = sommaTitolari2 + titolari2[i];
            }

            Console.WriteLine("la forza della squadra 2 è: " + sommaTitolari2);

            return sommaTitolari2;
        }
        static string eventiCasuali(int[] titolari1, int[] titolari2, int[] panchina1, int[] panchina2)
        {
            Random rand = new Random();
            int Evento = rand.Next(0, 131);

            string EventoCasuale = "";

            if (Evento <= 10)
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
            else if (Evento > 10 && Evento <= 20)
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
            else if (Evento > 20 && Evento <= 30)
            {
                EventoCasuale = "Non accade niente la partita prosegue";
            }
            else if (Evento > 30 && Evento <= 40)
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
            else if (Evento > 40 && Evento <= 50)
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
            else if (Evento > 50 && Evento <= 60)
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
            else if (Evento > 60 && Evento <= 70)
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
            else if(Evento > 70 && Evento <= 80)
            {
                EventoCasuale = "Cartellino giallo squadra A";
            }
            else if(Evento > 80 && Evento <= 90)
            {
                EventoCasuale = "Cartellino giallo squadra B";
            }
            else if(Evento > 90 && Evento <= 100)
            {
                EventoCasuale = "Cartellino rosso squadra A";
            }
            else if(Evento > 100 && Evento <= 110)
            {
                EventoCasuale = "Cartellino rosso squadra B";
            }
            else if(Evento > 110 && Evento <= 120)
            {
                EventoCasuale = "Sostituzione squadra A";
            }
            else if(Evento > 120 && Evento <= 130)
            {
                EventoCasuale = "Sostituzione squadra B";
            }

             return EventoCasuale;
        }
        static void Main(string[] args)
        {
            int[] titolari1 = new int[11];
            int[] titolari2 = new int[11];

            int[] panchina1 = new int[5];
            int[] panchina2 = new int[5];

            GenerazioneSquadre(titolari1, titolari2, panchina1, panchina2);

            for(int i = 0; i < 90; i++)
            {
                Console.WriteLine("Minuto " + (i+1) + ":" + eventiCasuali(titolari1, titolari2, panchina1, panchina2));
                Console.ReadLine();
            }
        }
    }
}
