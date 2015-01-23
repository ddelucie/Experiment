using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
	//base 10 to binary
	public static class BinaryConverter
	{
		public static string Convert(double num)
		{
			// find largest power of 2
			double currentPower = 0;
			int largestPower;
			int[] binaryNum;
			string binaryNumber = "";
			while (true)
			{
				if ((num - Math.Pow(2.0, currentPower)) < 0)
				{
					largestPower = (int)currentPower-1;
					break;
				} 

				currentPower++;
			}
			binaryNum = new int[largestPower + 1];


			for (int power = largestPower; power >= 0; power--)
			{
				if ((num - Math.Pow(2.0, power)) >= 0)
				{
					binaryNum[power] = 1;
					num = num - Math.Pow(2.0, power);
					
				}
				else binaryNum[power] = 0;
			}


			return String.Join("",binaryNum.Reverse());
		}

	}
}
