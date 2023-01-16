;int n, n1, n2, n3, n4, n5;

 Console.WriteLine("Ingrese un numero de cinco digitos:");
            n = Convert.ToInt32(Console.ReadLine());
             n1 = n / 10000;
             n2 = (n / 1000) % 10;
             n3 = (n / 100) % 10;
             n4 = (n / 10) % 10;
             n5 = n % 10;
            if (n1 == n5 && n2 == n4)
            {
                Console.WriteLine("El numero pantalla es capicua.");
            }
            else
            {
                Console.WriteLine("El numero en pantalla no es capicua.");
            }
            Console.ReadKey();
        
