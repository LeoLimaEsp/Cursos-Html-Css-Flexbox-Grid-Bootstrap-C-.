using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
							Console.WriteLine("Ingrese dos números");
							int n = Convert.ToInt32(Console.ReadLine());
							int m = Convert.ToInt32(Console.ReadLine());
							
							for(int i= 1; i <= n; i++)
							{
								for(int j= 1; j <= m; j++)
								{
									Console.Write("*");
								}
								Console.WriteLine("");
								
							}
							Console.WriteLine("Obtuviste un rectangulo de {0} X {1}", n,m);
						}
						
			}
			
}