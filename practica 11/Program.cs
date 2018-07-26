using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_11
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero;
			Console.WriteLine("Digite numero");
			numero = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine();

			for (int i = 1; i < 12; i++)
			{
				int Multiplicar = numero * i;
				Console.WriteLine("{0}x{1}={2}", numero, i, Multiplicar);
			}
			Console.ReadKey();


		}
	}
}
