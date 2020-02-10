using System;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int OP;

            Console.WriteLine("ESCOJA UNA OPCION:");
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("MENU 1");
            Console.WriteLine("MENU 2");
            OP = Convert.ToInt32(Console.ReadLine());
            switch(OP)
            {
                case 1: menu(); break;
                case 2: menu2(); break;
            }

        }



        static void menu2()
        {
            int Opcion;

            Console.WriteLine("ESCOJA UNA OPCION:");
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("0.Salir"); 
            Console.WriteLine("1. Calcular Numero de Billetes y Monedas");
            Console.WriteLine("2.ClasificarEdad");
            Console.WriteLine("2.Horas Trabajadas");
            Console.WriteLine("3.Calcular Pago ");
            Console.WriteLine("4.Formula de Suma");
            Console.WriteLine("5.Serie Finonacci");
            Opcion = Convert.ToInt32(Console.ReadLine());

            switch (Opcion)
            {
                case 0: Console.WriteLine("Saliendo del Programa..."); Console.ReadKey(); break;
                case 1: ConvertirMonto(); menu2(); break;
                case 2: Clasificaredad(); menu2(); break;
                case 3: Calcularpago(); menu2(); break;
                case 4: FormulaSuma(); menu2(); break;
                case 5:  menu2(); break;
                case 6: SerieFibonacci(); menu2(); break;

            }
        }


        static void SerieFibonacci()
        {
            int a, b, limite, i, auxiliar;

            Console.WriteLine("Trabajeremos una seria Fibonacci: ");
            Console.WriteLine("Ingrese el numero de Fibonacci que desea mostrar");
            limite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(""); 

            a = 0;
            b = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
            }
            Console.ReadKey();

        }

        static void ConvertirMonto()
        {
            int cantidad;
            Console.WriteLine("Calcularemos el numero de billetenes de 100,50,20,10,5 y 1 que posea la cantidad que ingresa");
            Console.WriteLine("Ingrese la cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La cantidad que usted ingreso esta compuesta por " + CalcularrBilletes(cantidad));
            Console.ReadKey();
        }

        static void FormulaSuma()
        {
            int N;
            double variable;
            Console.WriteLine("Calcularemos la formula correspondiente al punto numero 4 ");
            Console.WriteLine("Ingrese el valor de N: ");
            N = Convert.ToInt32(Console.ReadLine());
            variable = (1 / calcularfactorial(N)*(calcularfactorial(N) + 2));
            Console.WriteLine("El resultado de la formula es " + variable); 
            Console.ReadLine();

        }
        static void Calcularpago()
        {
           
             int Horas,valor;
            string Nombre;

            Console.Write("Calcularemos el pago de su dia segun sus horas trabajadas\n");
            Console.WriteLine("Ingrese su nombre: ");
            Nombre = Convert.ToString(Console.ReadLine());
            Console.Write("Ingrese las horas trabajadas ");
            Horas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su pago por hora ");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.Write("El pago de " + Nombre + " es de: " + Pago(Horas,valor));
            Console.ReadKey();

        }


        static Double Pago(int Horas, double valor)
        {
            int SueldoD;
            double SueldoT,Suma;

            int HE;
            SueldoT = 0;
            if (Horas < 8)
            {
                SueldoD=Horas* Convert.ToInt32(valor);
            }
            else { 
            SueldoD = 8 * Convert.ToInt32(valor);
            }
            HE = Horas - 8;
            if (HE > 0)
            {
            SueldoT = (valor * 1.5 );
            SueldoT = SueldoT * HE;
            }
             Suma = Convert.ToDouble(SueldoD) + SueldoT;
            return Suma;
        }

        static String CalcularrBilletes(int cantidad)
        {
            string respuesta;
            int guardad100, guardad50, guardad20, guardad10, guardad5, guardad1, R100, R50, R20, R10, R5, R1;
            guardad100 = cantidad / 100;
            R100 = (cantidad % 100);
            guardad50 = (R100 / 50);
            R50 = (R100 % 50);
            guardad20 = (R50 / 20);
            R20 = (R50 % 20);
            guardad10 = (R20 / 10);
            R10 = (R20 % 10);
            guardad5 = (R10 / 5);
            R5 = (R10 % 5);
            guardad1 = (R5 / 1);
            R1 = (R5 % 1);

            return respuesta = " " + guardad100 + " Billetes de 100.00 " + guardad50 + " Billetes de 50.00 " + guardad20 + " Billetes de 20.00 " + guardad10  +" Billetes de 10.00 " + guardad5 + " Billetes de 5.00 " + guardad1 + " Billetes de 1.00 ";
        }

        static void Clasificaredad()
        {
            int edad;

            Console.WriteLine("Calcularemos su edad");
            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ustede esta en el rango de " + Cedad(edad));
            Console.ReadKey();
        }

       static String Cedad(int edad)
       {
            String respuesta;

            if(edad>0 && edad < 6)
            {
                respuesta = "BEBE";
                return respuesta;
            }
            else if(edad>5 && edad < 13)
            {
                respuesta = "NIÑO";
                return respuesta;


            }
            else if (edad >12 && edad < 18)
            {
                respuesta = "ADOLECENTE";
                return respuesta;
            }
            else if (edad>17 && edad < 50)
            {
                respuesta = "ADULTO";
                return respuesta;
            }
            else if(edad>49)
            { 
            
                respuesta = "ANCIANO";
                return respuesta;
            }
            else
            {
                    respuesta = "-HUMANO";
                    return respuesta;
            }
       } 



        static void menu()
        {
            System.Console.Clear();
            int opcion;
            Console.WriteLine("ELIJA UNA OPCION");
            Console.WriteLine("Menu principal");
            Console.WriteLine("1. Convertir Q -> $ ");
            Console.WriteLine("2. Clasificar Triangulo");
            Console.WriteLine("3. Obvtener Factorial");
            Console.WriteLine("4. Promedio de Estudiante");
            Console.WriteLine("5. Calculo Cuotas");
            Console.WriteLine("6. Numero Intermedio de 3 Numeros Ingresados");
            Console.WriteLine("7. Días de la Semana");
            Console.WriteLine("8. 3ER Numero es la suma del 1ER Y 2DO");
            Console.WriteLine("9. Numero Intermedio de 3 Numeros Ingresados por Funcion");
            Console.WriteLine("10. Formula");
            Console.WriteLine("11. salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {

                case 1: ConvertirValor(); menu(); break;
                case 2: ClasificarTriangulo(); menu(); break;
                case 3: Factorial(); menu(); break;
                case 4: PromedioNotas(); menu(); break;
                case 5:  Calculocuetos(); menu(); break;
                case 6:  NumeroIntermedio(); menu(); break;
                case 7:  diasemana(); menu(); break;
                case 8:  Sumadenumeros(); menu(); break;
                case 9: NumeroIntermedio(); menu(); break;
                case 10: calcularformula(); menu(); break;
                case 11: Console.WriteLine("Saliendo del Programa..."); Console.ReadKey(); break;
                default: Console.WriteLine("opcion invalida"); Console.ReadKey(); menu();break;

            }
        }


        static void Calculocuetos()
        {
            System.Console.Clear();

            Double SUELDO,SUELDOML, Suma;

            Console.WriteLine("Calcularemos sus cuotas");
            Console.WriteLine("Ingrese su sueldo:");
            SUELDO = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Su Cuota Laboral es: " + Laboratol(SUELDO));
            SUELDOML = SUELDO- Laboratol(SUELDO);

            Console.WriteLine("Su Cuota Laboral es: " + Patronal(SUELDOML));
            Suma = Laboratol(SUELDO) + Patronal(SUELDOML);

            Console.WriteLine("Su Sueldo Liquido es: " +  (SUELDO - Suma));
            Console.ReadKey();


        }
        static Double Patronal(Double SUELDOML)
        {
            Double CP;
            CP = SUELDOML * 0.01;

            return CP;
        }

        static Double Laboratol(double SUELDO)
        {
            System.Console.Clear();
            Double CL;
            CL = SUELDO* 0.0483;

            return CL;

        }


        static void calcularformula()
        {
            System.Console.Clear();


            int n, r;
            double resultado;

            Console.WriteLine("Programa que calcula una permutacion");
            Console.WriteLine("Ingrese el valor de la constante N");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la constante R");
            r = Convert.ToInt32(Console.ReadLine());

            resultado = (calcularfactorial(n)) / calcularfactorial(n - r);

            Console.WriteLine("factorial:" + resultado);
            Console.ReadKey();
        }


        static int calcularfactorial(int n)
        {
            int i, acumulador;
            acumulador = 1;
            for (i = 1; i <= n; i++)
            {

                acumulador = acumulador * i;

            }

            return acumulador;

        }


        static void ConvertirValor()
        {
            System.Console.Clear();
            int cantidad;
            Console.WriteLine("Ingrese la cantidad que desea convertir de Q  a $");
            cantidad = Convert.ToInt32(Console.ReadLine());
            cantidad = cantidad * 8;
            Console.WriteLine("Su cantidad en $ es: " + cantidad);
            Console.ReadKey();
        }

        static void ClasificarTriangulo()
        {
            System.Console.Clear();
            int A, B, C;
            Console.WriteLine("Clasificaremos un triangulo segun sus lados:");
            Console.WriteLine("Ingrese la medida del lado A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la medida del lado B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la medida del lado C");
            C = Convert.ToInt32(Console.ReadLine());

            if(A==B && B == C)
            {
                Console.WriteLine("Es un triangulo Equilatero");
            }else if (A == B || B == C || A == C)
            {
                Console.WriteLine("Es un triangulo Isoceles");
            }else if (A!=B && B !=C && A != C)
            {
                Console.WriteLine("Es un triangulo Escaleno"); 
            }
            Console.ReadKey();
        }

        static void Factorial()
        {
            System.Console.Clear();
            int A;
            Console.WriteLine("Ingrese el numero entere del que desea obtener su factorial");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El factorial es " + calcularfactorial(A));
            Console.ReadKey();
        }

        static void PromedioNotas()
        {
            System.Console.Clear();
            int A, B, C, D;
            float Promedio;

            Console.WriteLine("Calcularemos su promedio de notas:");
            Console.WriteLine("Ingrese la 1er Nota");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la 1er Nota");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la 1er Nota");
            C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la 1er Nota");
            D = Convert.ToInt32(Console.ReadLine());
            Promedio = (A + B + C + D) / 4;
            if(Promedio> 60)
            {
                Console.WriteLine("Su Promedio es " + Promedio);
                Console.WriteLine("Felicidades Clase Aprobada");
            }
            else { 
            Console.WriteLine("Su Promedio es " + Promedio);
            Console.WriteLine("Lo sentimos Clase Reprobada");
            }
            Console.ReadKey();
        }

        static void NumeroIntermedio()
        {
            System.Console.Clear();
            int A, B, C;

            Console.WriteLine("Calcularemos el numero intermedio de los 3 numeros que ingrese");
            Console.WriteLine("Ingrese 1er Numero");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese 2do Numero");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese 3er Numero");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El Numero Intermedio es " + CalcularNumeroIntermedio(A, B, C));

            Console.ReadKey();

        }

        static int CalcularNumeroIntermedio(int A, int B, int C)
        {
            
            if(A >= B && A <= C || A >= C && A <= B )
            {
                
                return A;
            }
            else if (B >= A && B <= C || B >= C && B <= A)
            {
                return B;
            }
            else 
            {
                
                return C;
            }

        }


        static void diasemana()
        {
            System.Console.Clear();
            int A;

            Console.WriteLine("Calcularemos el día de la semana que segun el numero que ingrese");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Día " + dia(A));
            Console.ReadKey();
        }

        static string dia(int A)
        {
            string Nombredia;
            
            switch (A)
            {
                case 1: Nombredia = "Domingo"; return Nombredia; 
                case 2: Nombredia = "Lunes"; return Nombredia; 
                case 3: Nombredia = "Martes"; return Nombredia; 
                case 4: Nombredia = "Miercoles"; return Nombredia; 
                case 5: Nombredia = "Jueves"; return Nombredia; 
                case 6: Nombredia = "Viernes"; return Nombredia; 
                case 7: Nombredia = "Sabado"; return Nombredia; 
                default: Nombredia = "Numero Invalido"; return Nombredia;
                 }
        }

        static void Sumadenumeros()
        {
            System.Console.Clear();
            int A, B, C;
            Console.WriteLine("Calcularemos si el 3ER numero que ingrese es la suma del 1ER y 2DO numero");
            Console.WriteLine("Ingrese el Primer Numero");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Numero");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Tercer Numero");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El 3ER numero ingresado " + Calcular(A,B,C));
            Console.ReadKey();
        }

        static String Calcular(int A, int B, int C)
        {
            String Respuesta;

            if (C == (A + B))
            {
                Respuesta = "ES LA SUMA DEL 1ER Y 2DO NUMERO";
                return Respuesta;
            }
            else
            {
                Respuesta = "NO ES LA SUMA DEL 1ER Y 2DO NUMERO";
                return Respuesta;
            }
        }
    }

}
