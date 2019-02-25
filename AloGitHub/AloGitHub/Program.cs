using System;

namespace AloGitHub
{
	class Program
	{
		static void EscreveNatela3(String txt)
		{
            EscreveNatela(txt);
		}

		static void EscreveNatela(String txt)
		{
            Console.WriteLine(txt);

		}
        static void EscreveNatela2(String txt)
        {
            EscreveNatela(txt);

        }
        static void Main(string[] args)
		{
			EscreveNatela("Primeiro teste com GitHub");
			Console.ReadKey();
		}
	}
}
