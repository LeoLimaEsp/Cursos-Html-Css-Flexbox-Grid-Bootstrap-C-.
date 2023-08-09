using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
									Console.WriteLine("Por favor ingrese dos números a comparar:");
									
									int primero = Convert.ToInt32(Console.ReadLine());
									int segundo = Convert.ToInt32(Console.ReadLine());
									
									if (primero > segundo)
									{Console.WriteLine(segundo + " es menor, " + primero + " es el mayor.");}
								
									else if (segundo > primero)
									{Console.WriteLine(primero + " es menor, " + segundo + " es el mayor.");}
								    
									else if (primero == segundo)
									{Console.WriteLine("Los dos números son iguales.");}
							
						}
						
			}
			
}