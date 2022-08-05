using System;

namespace ejercicio1tareapg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables para el primer ejercicio
            int horas, segundos, minutos;

            //Mensaje en pantalla
            Console.WriteLine(" Ingrese la cantidad de horas: ");

            //Almacenando el dato ingresado en la variable
            horas = int.Parse(Console.ReadLine());

            //Operacion para calcular los minutos
            minutos = horas * 60;

            //Operaciones para calcular los segundos
            segundos = minutos * 60;

            //Mensajes en pantalla, resultado horas a minutos y segundos
            Console.WriteLine(horas + " horas en minutos son " + minutos + " minutos ");
            Console.WriteLine(horas + " horas en segundos son " + segundos + " segundos ");

            Console.WriteLine("--------------- ejercicio 1---------------");


            // Variables para el segundo ejercicio
            float b, a, h, c, area, perimetro;

            // Mensaje en pantalla
            Console.WriteLine(" Ingrese la base del triangulo");

            // Almacenando el dato de la base del triangulo ingresado en la variable
            b = float.Parse(Console.ReadLine());

            // Mensaje en pantalla
            Console.WriteLine(" Ingrese la altura del triangulo");

            // Almacenando el dato de la altura del triangulo ingresado en la variable
            h = float.Parse(Console.ReadLine());

            // Operacion para calcular el area del triangulo
            area = (b * h) / 2;

            // Mensaje en pantalla, resultado del area
            Console.WriteLine(" El area del triangulo es " + area + " centimetros ");

            // Mensaje en pantalla
            Console.WriteLine(" Ingrese la medida de los 3 lados ");

            // Almacenando los datos en los 3 lados del triangulo ingresados en cada unas
            // de las variables
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            // Operacion para calcular el perimetro del triangulo
            perimetro = a + b + c;

            // Mensajes en pantalla, resultado del perimetro
            Console.WriteLine(" El perimetro del triangulo es " + perimetro + " centimetros");

            Console.WriteLine("--------------- ejercicio 2---------------");


            // Variable constante con el dato del PI
            const double PI = 3.1416;

            // Variable para el tercer ejercicio
            double Radio, Altura, Area, Volumen;

            // Mensaje en pantalla
            Console.WriteLine(" Ingrese el radio del cilindro ");

            // Almacenando el dato radio del cilindro ingresado en la variable
            Radio = double.Parse(Console.ReadLine());

            // Mensaje en pantalla
            Console.WriteLine(" Ingrese la altura del cilindro ");

            // Almacenando el dato altura del cilindro ingresado en la variable
            Altura = double.Parse(Console.ReadLine());

            // Operaciones para calcular el area del cilindro
            Area = 2 * PI * Radio * (Altura + Radio);

            // Mensaje en pantalla, resultado del area del cilindro
            Console.WriteLine("El are del cilindro es " + area + " cm² ");

            // Operacion para calcular el volumen del cilindro
            Volumen = PI * (Radio * Radio) * (Altura);

            // Mensaje en pantalla, resultado del volumen del cilindro
            Console.WriteLine(" El volumen del cilindro es " + Volumen + " cm³ ");

            Console.WriteLine("--------------- ejercicio 3---------------");



            // Variable para el cuarto ejercicio
            double valor1, valor2, suma, resta, multiplicacion, division;
            // Mensaje en pantalla
            Console.WriteLine("Sumar");
            // Mensaje en pantalla
            Console.WriteLine("Ingrese el primer valor");
            // Almacenando el primer valor ingresado en la variable
            valor1 = double.Parse(Console.ReadLine());
            // Mensaje en pantalla
            Console.WriteLine("Ingrese el segundo valor");
            // Almacenando el primer valor ingresado en la variable
            valor2 = double.Parse(Console.ReadLine());
            // Operacion para calcular la suma
            suma = valor1 + valor2;
            // Mensaje en pantalla, resultado de la suma
            Console.WriteLine("El resultado de sumar " + valor1 + " + " + valor2 + " es " + suma);

            // Mensaje en pantalla
            Console.WriteLine("Restar");
            // Mensaje en pantalla
            Console.WriteLine("Ingrese el primer valor");
            // Almacenando el primer valor ingresado en la variable
            valor1 = double.Parse(Console.ReadLine());
            // Mensaje en pantalla
            Console.WriteLine("Ingrese el segundo valor");
            // Almacenando el segundo valor ingresado en la variable
            valor2 = double.Parse(Console.ReadLine());
            // Operacion para calcular la resta
            resta = valor1 - valor2;
            // Mensaje en pantalla, resultado de la resta
            Console.WriteLine("El resultado de resta " + valor1 + " - " + valor2 + " es " + resta);

            // Mensaje en pantalla
            Console.WriteLine("Multiplicar");
            // Mensaje en pantalla
            Console.WriteLine("Ingrese el primer valor");
            // Almacenando el primer valor ingresado en la variable
            valor1 = double.Parse(Console.ReadLine());
            // Mensaje en pantalla
            Console.WriteLine("Ingrese el segundo valor");
            // Almacenando el segundo valor ingresado en la variable
            valor2 = double.Parse(Console.ReadLine());
            // Operacion para calcular la multiplicacion
            multiplicacion = valor1 * valor2;
            // Mensaje en pantalla, resultado de la multiplicacion
            Console.WriteLine("El resultado de multiplicar " + valor1 + " * " + valor2 + " es " + multiplicacion);

            // Mensaje en pantalla
            Console.WriteLine("Dividir");
            // Mensaje en pantalla
            Console.WriteLine("Ingrese el primer valor");
            // Almacenando el primer valor ingresado en la variable
            valor1 = double.Parse(Console.ReadLine());
            // Mensaje en pantalla
            Console.WriteLine("Ingrese el segundo valor");
            // Almacenando el segundo valor ingresado en la variable
            valor2 = double.Parse(Console.ReadLine());
            // Operacion para calcular la division
            division = valor1 / valor2;
            // Mensaje en pantalla, resultado de la division
            Console.WriteLine("El resultado de dividir " + valor1 + " / " + valor2 + " es " + division);

            Console.WriteLine("--------------- ejercicio 4---------------");


            // Variable para el quinto ejercicio
            string nombre, tiposangre;
            double peso, estatura;
            int edad;
            // Mensaje en pantalla
            Console.WriteLine("Ingrese su nombre");
            // Almacenando el nombre ingresado en la variable
            nombre = Console.ReadLine();
            // Mensaje en pantalla
            Console.WriteLine("Ingrese su edad");
            // Almacenando el edad ingresado en la variable
            edad = int.Parse(Console.ReadLine());
            // Mensaje en pantalla
            Console.WriteLine("Ingrese su peso");
            // Almacenando el peso ingresado en la variable
            peso = double.Parse(Console.ReadLine());
            // Mensaje en pantalla
            Console.WriteLine("Ingrese su estatura");
            // Almacenando la estatura ingresado en la variable
            estatura = double.Parse(Console.ReadLine());
            // Mensaje en pantalla
            Console.WriteLine("Ingrese su tipo de sangre");
            // Almacenando el tipo de sangre ingresado en la variable
            tiposangre = Console.ReadLine();
            // Mensaje en pantalla, mostrando todos los datos almacenados
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Estatura: " + estatura);
            Console.WriteLine("Tipo de sangre: " + tiposangre);

            Console.WriteLine("--------------- ejercicio 5---------------");


        }
    }
}
