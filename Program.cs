namespace string_sessiz_harf_compare;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input:");
        string[] input=Console.ReadLine().Split(' ');
        for (int i = 0; i < input.Length; i++)
        {
            bool found = false; 
            string ifade=input[i];
            for (int b = 0; b < ifade.Length-1; b++)
            {
                if (IsSessiz(ifade[b]) && IsSessiz(ifade[b + 1]))
                {
                    found = true;
                    break;
                }                
            }
            Console.Write(found + " ");
        }
        Console.ReadLine();
    }
    static bool IsSessiz(char c)
    {
        string sessizHarfler = "bcçdfgğhjklmnprsştvyzBCÇDFGĞHJKLMNPRSŞTVYZ";
        return sessizHarfler.Contains(c);
    }
}
