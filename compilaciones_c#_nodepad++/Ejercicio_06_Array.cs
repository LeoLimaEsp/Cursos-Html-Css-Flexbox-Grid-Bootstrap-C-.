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
									
									Console.WriteLine("Creando nuevo array de números impares:");
									
									for(int i = 0; i < numero; i++)
									{
										if(numberlist[i] % 2 != 0)
										{
											suma = suma +1;
											Console.WriteLine(numberlist[i]);
										}
									}	
									
									Console.WriteLine("Cantidad de números impares: {0}", suma);
									
									int[] imparList = new int[suma];
									
									int j=0;
 									for(int i = 0; i < numero; i++)
									{
										if(numberlist[i] % 2 != 0)
										{
									
											imparList[j] = numberlist[i];
											j++;
										}
									}	
												
									
									Console.WriteLine("Resultado:");
									
									foreach( int item in imparList)
									{
										Console.Write(item + " ");
									
									}
									
						}
						
			}
			
}