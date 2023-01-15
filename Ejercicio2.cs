int n;
Console.WriteLine("Ingrese un numero entero de dos digitos:");
n = Convert.ToInt32(Console.ReadLine());
if ( n < 10 || n > 99 ) 
{
Console.WriteLine("Error, el numero debe tener dos digitos");
}
 if (n < 0) {
        Console.WriteLine("El numero es negativo");
    } else {
        if (nprimo(n)) {
            Console.WriteLine("El numero es primo");
        } else {
            Console.WriteLine("El numero no es primo");
        }
    }

static bool nprimo(int n) {
      if (n < 2) return false;
      for (int i = 2; i <= n / 2; i++) {
          if (n % i == 0) return false;
      }
      return true;
  }
