using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
									Console.WriteLine("Por favor ingrese dos números a dividir, siendo el primer número el dividendo y el segundo el divisor:");
									
									int dividendo = Convert.ToInt32(Console.ReadLine());
									int divisor = Convert.ToInt32(Console.ReadLine());
									
									if (divisor != 0)
										{
											Console.WriteLine("El resultado es: " + dividendo/divisor);
									    }
								    else {Console.WriteLine("Error, el divisor no puede ser 0");}						
						}
						
			}
			
}