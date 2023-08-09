using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
									Console.WriteLine("Por favor ingrese el tamaño del array a crear :");
									
									int numero = Convert.ToInt32(Console.ReadLine());
									int[] numberlist = new int[numero];
									int max = 0;
									
															
									for(int i=0; i < numero; i++)
									{
										numberlist[i] = Convert.ToInt32(Console.ReadLine());
									}
									
									for(int j=0; j < numero; j++)
									{
										if(numberlist[j] >= max)
										{
											max = numberlist[j];
										}
									}
									Console.WriteLine("El número mayor es: {0}", max);
									
									int min = numberlist[0];
									
									for(int j = 0; j < numero; j++)
									{
										if(numberlist[j] <= min)
										{
											min = numberlist[j];
										}
									}
									Console.WriteLine("El número menor es: {0}", min);
													
						}
						
			}
			
}