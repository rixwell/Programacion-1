 int n, penultimodig,segdigito;
 Console.WriteLine("Ingrese un numero de cuatrp digitos: ");
            n= Convert.ToInt32(Console.ReadLine());

            segdigito = (n / 100) % 10;
            penultimodig = (n / 10) % 10;

            if (segdigito == penultimodig)
            {
                Console.WriteLine("El segundo digito es igual al penultimo digito ");
            }
            else
            {
                Console.WriteLine("El segundo digito no es igual al penultimo digito ");
            }
            Console.ReadKey();
