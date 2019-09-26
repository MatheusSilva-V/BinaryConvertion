/*
 * Created by SharpDevelop.
 * User: User
 * Date: 25/09/2019
 * Time: 14:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BinaryConvertion
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite o número em binário: ");
			
			string bin = Console.ReadLine();
			char[] arr = bin.ToCharArray();
			double decimalNumber = 0;
			
			Array.Reverse(arr, 0, arr.Length);
		
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == '1')
				{
				decimalNumber += 1.0 * (Math.Pow(2, i));
				}
			}
			
			Console.WriteLine("O número em decimal é: " + decimalNumber);
			
			//for (int i = bin.Length; i == 0; i--)
			//{
			
			//}
			
				
			Console.ReadLine();
		}
	}
}