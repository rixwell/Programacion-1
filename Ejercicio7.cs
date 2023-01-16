int n1, n2, n3, nm;

            Console.WriteLine("Ingrese el primer numero:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero:");
            n3 = Convert.ToInt32(Console.ReadLine());

            nm = Math.Max(n1, n2);
            nm = Math.Max(nm, n3);

            Console.WriteLine("El número mayor es: " + nm);
            Console.ReadKey();
