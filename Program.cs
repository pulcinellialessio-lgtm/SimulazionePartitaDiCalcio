namespace SimulazionePartitaDiCalcio
{
    internal class Program
    {
        static void GenerazioneSquadre(int[] titolari1, int[] titolari2, int[] panchina1, int[] panchina2)
        {
            Random rand = new Random();

            for(int i = 0; i < titolari1.Length; i++)
            {
                int ForzaTitolari1 = rand.Next(30, 101);
                titolari1[i] = ForzaTitolari1;
            }

            for (int i = 0; i < titolari2.Length; i++)
            {
                int ForzaTitolari2 = rand.Next(30, 101);
                titolari2[i] = ForzaTitolari2;
            }

            for (int i = 0; i < panchina1.Length; i++)
            {
                int ForzaPanchina1 = rand.Next(30, 101);
                panchina1[i] = ForzaPanchina1;
            }

            for (int i = 0; i < panchina2.Length; i++)
            {
                int ForzaPanchina2 = rand.Next(30, 101);
                panchina2[i] = ForzaPanchina2;
            }
        }
        static void Main(string[] args)
        {
            int[] titolari1 = new int[11];
            int[] titolari2 = new int[11];

            int[] panchina1 = new int[5];
            int[] panchina2 = new int[5];
        }
    }
}
