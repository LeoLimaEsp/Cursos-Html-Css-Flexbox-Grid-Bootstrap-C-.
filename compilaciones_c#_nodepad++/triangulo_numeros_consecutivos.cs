using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
							Console.WriteLine("Ingrese un número");
							int n = Convert.ToInt32(Console.ReadLine());
							int m = 1;
							
							for(int i= 1; i <= n; i++)
							{
								for(int j= 1; j <= i; j++)
								{
									Console.Write(m++);
								}
								Console.WriteLine("");
								
							}
							Console.WriteLine("Obtuviste un triangulo de altura: {0}", n);
						}
						
			}
			
}