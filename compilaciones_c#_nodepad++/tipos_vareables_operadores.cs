using System;

namespace Tipos{
		
	public class Program
	{	
		public static void Main()
		{
			// literales enteras son int
			// literales decimales son double
			int entero = 11;
			long largo = 328903890;
			float flotante = 3.5F;	// la F es para float
			double doble = 3213.312312;
			bool booleano = false;
			char caracter = 'A';
			Console.WriteLine("entero: " + entero);
			Console.WriteLine("largo: "+ largo );
			Console.WriteLine("flotante: " + flotante  );
			Console.WriteLine("doble:" + doble );
			Console.WriteLine("bool:" + booleano );
			Console.WriteLine("caracter:" + caracter );
			
			// División de Enteros y Decimales
			int dividendo = 119;
			int divisor = 12;	
			int resultado = dividendo / divisor;	// solo se toma la parte entera
			Console.WriteLine("division= " + resultado);
						
			// Modulo o residuo de una división %
			int a = 10;
			int b = 3;
			int modulo = a % b;
			Console.WriteLine("a % b = " + modulo);
			
			// Operadores de Incremento y Decremento
			int i = 5;
			i++;
			Console.WriteLine("i = " + i);
			int j = 5;
			j--;
			Console.WriteLine("j = " + j);
			
			// Operadores relacionales
			Console.WriteLine("Operadores relacionales");
			Console.WriteLine("3 == 2 : " + (3 == 2) );
			Console.WriteLine( 3 != 2 );
			Console.WriteLine( 'A' < 'F' );
			Console.WriteLine( 3 > 2 );
			Console.WriteLine( 3 <= 2 );
			Console.WriteLine( 3 >= 3 );	
			
			// Operadores lógicos
			Console.WriteLine("Operadores logicos");
			Console.WriteLine(!false); 
			Console.WriteLine(!(5==5));			
			Console.WriteLine( (5==5)||(5<1) );		// OR
			Console.WriteLine( (5==5)&&(5<1) );		// AND			
			Console.WriteLine( (5==5) && (!(5<1)) );
			
			// EJERCICIO
			int year = 2000;
			bool biciesto = (year%4==0) &&  (year%100!=0||year%400==0);
			Console.WriteLine(year + " es biciesto: " + biciesto);
		}
	}

}