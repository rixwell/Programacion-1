 int n1, n2, nmayor, nmenor;

 Console.WriteLine("Digite el primer numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            if (n1 > n2)
            {
                nmayor = n1;
                nmenor = n2;
            }
            else
            {
                nmayor = n2;
                nmenor = n1;
            }
            if ((nmayor - nmenor) <= 10)
            {
                Console.WriteLine("Los numeros se encuentran organizados en la siguiente secuencia: ");
                for (int i = nmenor; i <= nmayor; i++)
                {
                    Console.WriteLine(i);
                }
                
            } 
            else 
            {
                Console.WriteLine("Existe una diferencia entre ambos numeros mayor a diez. ");
            }
            Console.ReadKey();