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
	}
}
