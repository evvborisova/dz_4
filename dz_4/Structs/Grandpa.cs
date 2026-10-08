using dz_4.Enums;

namespace dz_4.Structs
{
    public struct Grandpa
    {
        public string Name;
        public Grumpiness Level;
        public string[] Phrase;
        public int Bruises;

        public Grandpa(string name, Grumpiness level, string[] phrase)
        {
            Name = name;
            Level = level;
            Phrase = phrase;
            Bruises = 0;
        }

        public int Bruise(params string[] words)
        {
            int countBruises = 0;

            foreach (string phrase in Phrase)
            {
                foreach (string word in words)
                {
                    if (phrase.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                        countBruises ++;
                }
            }
            return countBruises;
        }
    }
}
