﻿/*
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
		Conversao:
			Console.WriteLine("Digite o número em binário: ");
			
			string bin = Console.ReadLine();
								
			char[] arr = bin.ToCharArray();
			double decimalNumber = 0;
			
			Verificacao:
			for (int p = 0; p < arr.Length; p++)
				{
					while (arr[p] != '1' && arr[p] != '0')
					{
						Console.WriteLine("Número digitado não é binário!");
						Console.WriteLine("Digite novamente o número em binário: ");
						bin = Console.ReadLine();
						arr = bin.ToCharArray();
						goto Verificacao;
					}
				}
			
			Array.Reverse(arr, 0, arr.Length);
			
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] == '1')
					{
					decimalNumber += 1.0 * (Math.Pow(2, i));
					}
				}
				
				Console.WriteLine("O número em decimal é: " + decimalNumber);
				
			NovaConversao:
				Console.WriteLine("Gostaria de fazer nova conversão? (s/n) ");
				char resp = char.Parse(Console.ReadLine());
				if (resp == 's')
				{
					goto Conversao;
				}
				else if (resp != 'n')
				{
					Console.WriteLine("Não entendi sua resposta.");
					goto NovaConversao;
				}
							
		}
	}
}