using System;
using Functions = PeakElement.PeakFunctions;

namespace PeakElement
{
	class Program
	{
		static public void Main()
		{
			//int rows = 4, columns = 4;
			Console.Write("Numri i rreshtave:");
			int rows = int.Parse(Console.ReadLine());
			Console.Write("Numri i kolonave:");
			int columns = int.Parse(Console.ReadLine());


			int[,] matrix = new int[rows, columns];

			Console.WriteLine("Shkruaj elementet e matricës:");
			//Lexo matricen
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					matrix[i, j] = int.Parse(Console.ReadLine());
				}
			}

			Console.WriteLine("\nMatrica:");
			//Shkruaj matricen
			for (int i = 0; i < rows; i++)
			{
				Console.WriteLine();

				for (int j = 0; j < columns; j++)
				{
					Console.Write(matrix[i, j] + "   ");
				}
			}

			Console.WriteLine("\n\nKulmi i matricës është:" + Functions.FindPeak(matrix, rows, columns));
			Console.ReadKey();
		}
	}
}
