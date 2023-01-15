int n1, n2, suma;
Console.WriteLine("Digite el primer numero entero de dos digitos: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite el segundo numero entero de dos digitos: ");
n2 = Convert.ToInt32(Console.ReadLine());
suma= n1+n2;
if (n1 <= 99 && n1 >= 10){
    if (n2 <= 99 && n2 >= 10 )
    {
if (suma % 2 == 0)
{
    Console.WriteLine("Este numero es par: " + suma);
}
else
{
Console.WriteLine("Este numero no es par: "+ suma);
}
    }
}
else
{
   Console.WriteLine("Error, el numero debe tener dos digitos");
}
Console.ReadKey();
