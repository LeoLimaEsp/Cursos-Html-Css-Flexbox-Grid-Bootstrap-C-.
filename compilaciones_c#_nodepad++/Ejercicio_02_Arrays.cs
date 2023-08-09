using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
									Console.WriteLine("Por favor ingrese el tamaño del array a crear de strings:");
									
									int numcadenas = Convert.ToInt32(Console.ReadLine());
									string[] cadenas = new string[numcadenas];
									
									for(int i=0; i < numcadenas; i++)
									{
										cadenas[i] = Console.ReadLine();
									}
									
									foreach(string item in cadenas)
									{
										Console.Write(item + " ");
									}
									
									
							
						}
						
			}
			
}