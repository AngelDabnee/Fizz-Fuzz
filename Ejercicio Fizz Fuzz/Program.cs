// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//DE
Random rnd = new Random();
int num = rnd.Next();
int var = 0;
//Proceso		Ciclo para determinar un número de 0 a 333.
for (int i = 0; i < 333; i++)
{
    //Console.WriteLine(rnd.Next(i));
	var = rnd.Next(i);//Guardaremos el valor de ese número alatorio en la variable "var"
}
//Valoramos las condiciones e imprimimos la condición que se cumpla.  
if (var % 3 == 0)
{
	Console.WriteLine($"Fizz el número aleatorio obtenido es {var}");
}
if (var % 5 == 0)
{
	Console.WriteLine($"Fuzz el número aleatorio obtenido es {var}");
}
if (var % 3 == 0 && var % 5 == 0 )
{
	Console.WriteLine($"Fizz y Fuzz el número aleatorio obtenido es {var}");
}

Console.WriteLine($"El número es {var}");