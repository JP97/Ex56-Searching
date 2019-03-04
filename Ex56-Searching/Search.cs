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
			for (int i = 0; i < data.Length; i++)
			{
				if(value == data[i])
				{
					return i;
				}
			}
			return -1;
		}
	}
}
