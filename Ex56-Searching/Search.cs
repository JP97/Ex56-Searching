using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex56_Searching
{
    public class Search
    {
		public static int FindPositionInList_Linear(int[] data, int value)
		{
			bool ikkefundet = true;
			int i = 0;

			while (ikkefundet && i < data.Length)
			{
				if(value == data[i])
				{
					return i;
				}
				else
				{
					i++;
				}
			}
			return -1;
		}




		public static int FindPositionInList_Binary(int[] data, int value)
		{
			int lowerbound = 0;
			int upperBound = data.Length;
			int midPoint = 0;
			bool ikkefundet = true;

			while (ikkefundet && lowerbound < data.Length)
			{
				midPoint = lowerbound + (upperBound - lowerbound) / 2;

				if (upperBound < lowerbound)
				{
					return -1;
				} 

				else if(data[midPoint] < value)
				{
					lowerbound = midPoint + 1;
				}
				else if(data[midPoint] > value)
				{
					upperBound = midPoint - 1;
				}
				else if(data[midPoint] == value)
				{
					ikkefundet = false;
					return midPoint;
				}
			}
			return -1;

		}


		public static int FindPositionInList_Binary()
		{


			return -1:
		}
	}
}
