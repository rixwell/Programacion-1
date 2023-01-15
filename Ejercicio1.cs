int n, n1, n2, suma;

Console.WriteLine("Ingrese un numero de dos digitos:");

n = Convert.ToInt32(Console.ReadLine());

n1 = n % 10;
n = n / 10;
n2 = n % 10;
n = n / 10;

suma = n1 + n2;

Console.WriteLine ("El resultado de la suma es: " + suma );

Console.ReadKey();


