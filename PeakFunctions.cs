using System;

namespace PeakElement
{
    public class PeakFunctions
    {
		//Gjej vleren maksimale te kolones, mid -> kolona e mesme
		public static int FindMaxIndex(int[,] arr, int rows, int mid, int max)
		{
			int max_index = 0;
			for (int i = 0; i < rows; i++)
			{
				if (max < arr[i, mid])
				{

					// Gjej vleren maksimale te kolones dhe kthe indeksin e saj
					max = arr[i, mid];
					max_index = i;
				}
			}
			return max_index;
		}

		// Kthe vleren maksimale te kolones
		public static int Max(int[,] arr, int rows, int mid, int max)
		{
			for (int i = 0; i < rows; i++)
			{
				if (max < arr[i, mid])
				{

					// Gjej vleren maksimale te kolones
					max = arr[i, mid];
				}
			}
			return max;
		}

		// Funksioni per gjetjen e majes se matrices
		public static int FindPeakRec(int[,] arr, int rows,	int columns, int mid)
		{
			int max = 0;
			int max_index = FindMaxIndex(arr, rows, mid, max);
			max = Max(arr, rows, mid, max);

			// Nese jemi ne kolonen e pare ose te fundit
			// vlera maksimale e kolones eshte maja 
			if (mid == 0 || mid == columns - 1)
				return max;

			// Nese maksimumi gjendet ne kolonen e mesme, ai eshte maja
			if (max >= arr[max_index, mid - 1] && max >= arr[max_index, mid + 1])
				return max;

			// Nese maksimumi eshte me i vogel se vlera majtas
			if (max < arr[max_index, mid - 1])
				return FindPeakRec(arr, rows, columns, (int)(mid - Math.Ceiling((double)mid / 2)));

			// Nese maksimumi eshte me i vogel se vlera djathtas
			return FindPeakRec(arr, rows, columns, (int)(mid + Math.Ceiling((double)mid / 2)));
		}

		public static int FindPeak(int[,] arr, int rows, int columns)
		{
			return FindPeakRec(arr, rows, columns, columns / 2);
		}

	}
}
