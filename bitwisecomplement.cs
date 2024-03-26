using System;
 
namespace Operator
{
	class BitWiseComplement
	{
		public static void Main(string[] args)
		{
			int number = 26, result;
			result = ~number;
			Console.WriteLine("~{0} = {1}", number, result);
		}
	}
}