using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
							Console.WriteLine("Ingrese un número");
							int n = Convert.ToInt32(Console.ReadLine());
							
							for(int i= 1; i <= n; i++)
							{
								for(int j= 1; j <= i; j++)
								{
									Console.Write(j);
								}
								Console.WriteLine("");
								
							}
							Console.WriteLine("Obtuviste un triangulo de altura: {0}", n);
						}
						
			}
			
}