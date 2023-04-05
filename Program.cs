namespace Reverse.Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle veya kelime giriniz: ");
            string ifade = Console.ReadLine();
            string bosluk = "";

            for (int i = ifade.Length - 1; i >= 0; i--)
            {
                bosluk += ifade[i];

            }
            Console.WriteLine(bosluk);
        }
    }
}