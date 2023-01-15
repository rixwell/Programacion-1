int n, n1, n2, n3;

Console.WriteLine("Digite un numero entero de tres digitos: ");
n = Convert.ToInt32(Console.ReadLine());
n3 = n % 10;
n = n / 10;
n2 = n % 10;
n = n / 10;
n1 = n % 10;



            if (n1 > n2 && n1 > n3)
            {
            
                
                    Console.WriteLine("{0} es el digito mayor y esta en la primera posicion", n1);
                
            }
            else if (n2 > n1 && n2 > n3)
            {
                
                    Console.WriteLine("{0} es el digito mayor y esta en la segunda posicion", n2);
            }
                else{

                Console.WriteLine("{0} es el digito mayor y esta en la tercera posicion", n3);
                }
            Console.ReadKey();
        
