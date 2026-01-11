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
        static void eventiCasuali()
        {

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

            }
        }
    }
}
