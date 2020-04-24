using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaNOMBRES
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] personas = new string[10];
			Console.WriteLine("Ingresar	nombre	de	persona	1");
			personas[0] = Console.ReadLine();
			Console.WriteLine("Ingresar	nombre	de	persona	2");
			personas[1] = Console.ReadLine();
			Console.WriteLine("Ingresar	nombre	de	persona	3");
			personas[2] = Console.ReadLine();
			Console.WriteLine("Ingresar	nombre	de	persona	4");
			personas[3] = Console.ReadLine();
			Console.WriteLine("Ingresar	nombre	de	persona	5");
			personas[4] = Console.ReadLine();
			Console.WriteLine("Ingresar	nombre	de	persona	6");
			personas[5] = Console.ReadLine();
			Console.WriteLine("Ingresar	nombre	de	persona	7");
			personas[6] = Console.ReadLine();
			Console.WriteLine("Ingresar	nombre	de	persona	8");
			personas[7] = Console.ReadLine();
			Console.WriteLine("Ingresar	nombre	de	persona	9");
			personas[8] = Console.ReadLine();
			Console.WriteLine("Ingresar	nombre	de	persona	10");
			personas[9] = Console.ReadLine();
			Console.WriteLine("Los	nombres	ingresados	son:	");
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(personas[i]);
			}
			Console.ReadKey();

		}
	}
}
