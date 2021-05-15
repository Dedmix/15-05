using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{


				Console.WriteLine("Введите число, которое будет наибольшим для массива");
				int a = int.Parse(Console.ReadLine());
				int temp = 0;
				Random rand = new Random();
				int[] arr = new int[10];
				for (int i = 0; i < arr.Length; i++)
				{
					arr[i] = rand.Next(0, a);
					Console.WriteLine(arr[i]);

				}
				Console.WriteLine();
				for (int i = 0; i < arr.Length; i++)
				{
					for (int j = 1; j < arr.Length - i; j++)
					{
						if (arr[j] > arr[j - 1])
						{
							temp = arr[j];
							arr[j] = arr[j - 1];
							arr[j - 1] = temp;
						}
					}
				}
				for (int i = 0; i < arr.Length; i++)
					Console.WriteLine(arr[i]);
			}
			catch (Exception e) 
			{ 
				Console.WriteLine(e.Message); 
			}
			Console.ReadKey();

		}
	}
}
