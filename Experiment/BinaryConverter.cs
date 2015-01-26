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


        /// <summary>
        /// just keep dividing by 2s until quotient is 0.
        /// the binary result will be the remainders of each division in reverse.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string Convert2(int num)
        {
            string binaryResult = "";
            int quotient = num / 2;
            while (quotient > 0)
            {
                binaryResult += num % 2;
                quotient = num / 2;
                num = quotient;
            }

            return string.Join("", binaryResult.Reverse());
        }

	}
}
