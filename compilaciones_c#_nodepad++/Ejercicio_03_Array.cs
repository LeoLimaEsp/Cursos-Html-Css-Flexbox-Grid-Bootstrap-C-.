using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
									Console.WriteLine("Por favor ingrese el tamaño del array a crear :");
									
									int numero = Convert.ToInt32(Console.ReadLine());
									int[] numberlist = new int[numero];
									int suma = 0;
									
									for(int i=0; i < numero; i++)
									{
										numberlist[i] = Convert.ToInt32(Console.ReadLine());
									}
									
									for(int j=0; j < numberlist.Length; j++)
									{
										suma = suma + numberlist[j];
									}

									Console.WriteLine("La suma del contenido del array es: {0}", suma);
								
							
						}
						
			}
			
}