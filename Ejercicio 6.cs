int n, n1,n2,n3;
Console.WriteLine("Digite un numero de tres digitos: ");
n = Convert.ToInt32(Console.ReadLine());
n1 = n/100;
n2 = (n/10) % 10;
n3 = n % 10;

 if (n1 % n2 == 0 || n2 % n3 == 0 || n1 % n3 == 0 || n2 % n1 == 0 || n3 % n2 == 0 || n3 % n1 == 0)
{
Console.WriteLine("Uno de los digitos es un multiplo de otro numero.");

}

else
{
    Console.WriteLine("Ninguno de los digitos es multiplo de otro numero. ");

}
Console.ReadKey();