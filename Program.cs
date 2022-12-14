// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Dime tu nombre");
string nombre;
nombre=Console.ReadLine ();
Console.WriteLine ($"Tu nombre es {nombre}");
*/
var generadoraleatorio = new Random();
int numeroAdivinar = generadoraleatorio.Next(1, 15);
int numeroUsuario;
string eleccionUsuario;
Console.WriteLine(@"El juego consiste en adivinar un número al azar del 1 al 15.
Para ello tienes tres oportunidades.");
int i;
int intentos =3;
for(i=0;i<3;i++)
{
    intentos--;
    Console.WriteLine("¿Qué número eliges?");
    eleccionUsuario = Console.ReadLine();
    numeroUsuario = Int32.Parse(eleccionUsuario);
    Console.WriteLine($"tu número es el {numeroUsuario}");
    if (numeroUsuario == numeroAdivinar)
    {
        Console.WriteLine("HAS GANADO");
        break;
    }
    else if (numeroUsuario < numeroAdivinar)
    { 
        Console.WriteLine("Ese no es,el numero es mayor");
    }
    else if(numeroUsuario> numeroAdivinar)
    {
        Console.WriteLine("Ese no es,el numero menor");
    }
    if(intentos == 0)
    {   Console.WriteLine("Te has quedado sin intentos, has perdido.");
        Console.WriteLine($"El número para advinar es {numeroAdivinar}");
        break;
    }
}
