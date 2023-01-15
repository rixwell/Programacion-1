int a = 0, i, n;
Console.WriteLine("Digite un numero entero de dos digitos: ");
 n = Convert.ToInt32(Console.ReadLine());
if ( n >= 10 || n >= 99 ) 
{

for (i = 1; i < (n + 1); i++)
{
    if (n % i  == 0)
{
    a++;
}
}
if (a != 2) 
{
    Console.WriteLine("Este numero no es primo");
}
else {
     Console.WriteLine("Este numero es primo");  
}
}
else {
    Console.WriteLine("Error, el numero debe tener dos digitos");
}
Console.ReadKey();
