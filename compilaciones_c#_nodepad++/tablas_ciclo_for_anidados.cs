using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
							for(int i= 1; i <= 10; i++)
							{
								for(int j= 1; j <= 10; j++)
								{
									Console.WriteLine("{0} X {1} = {2}", i, j, i*j);
								}
								Console.WriteLine("");
							}
						}
						
			}
			
}