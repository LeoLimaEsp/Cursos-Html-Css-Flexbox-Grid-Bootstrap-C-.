using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
									Console.WriteLine("Por favor ingrese el tamaño del array a crear :");
									
									int numero = Convert.ToInt32(Console.ReadLine());
									int[] numberlist = new int[numero];
									
									for(int i=0; i < numero; i++)
									{
										numberlist[i] = Convert.ToInt32(Console.ReadLine());
									}
									
									foreach(int item in numberlist)
									{
										Console.Write(item);
									}
									
									
							
						}
						
			}
			
}