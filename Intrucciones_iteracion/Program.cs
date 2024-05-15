using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrucciones_iteracion
{
    class Program
    {
        static void Main(string[] args)
        {

            //for(  //inicializador; condicion ; iteracior )
            //   {
            //    //codigo a repetirse;
            //}

            //Variable de bucle ( o de control)
            //int i;

            //for( i =1; i<=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int x = 2;
            //Console.WriteLine(x);



            ////Asignacion compuesta de suma
            //x += 5; // x = x + 5;

            //Console.WriteLine(x);


            //int i;

            //for(i= 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //---Concepto de contador 

            //int i;
            //int contador = 0;

            //for(i = 1; i <= 10; i++)
            //{
            //    contador++; //contador += 1; // contador = contador + 1;
            //    Console.WriteLine("Vuelta del ciclo numero {0}", contador);
            //}

            //Console.WriteLine("El numero de vueltas que dio el ciclo fue: {0}", contador);

            //---Acumulador

            //int i;
            //int acumulador = 0;
            //int precio;

            //for( i = 1; i <=5; i++)
            //{
            //    Console.Write("Ingrese el precio del producto: ");
            //    precio = Convert.ToInt32(Console.ReadLine());

            //    acumulador = acumulador + precio;

            //}

            //Console.WriteLine("El total es: {0}", acumulador);








            ////Programa para sacar el promedio de las calificacones de tres alumnos.
            ////Hay que recordar que el promedio de las calificaiones y en general de cualquier cosa, se obtine sumando a cada una de ellas y a la suma total se le divide entre el numero de cantidades que hayamos sumado.

            ////variables
            //double calif1, calif2, calif3, promedio;

            ////hacemos la primera peticion
            //Console.Write("Dame la calificacion del primer alumno: ");
            //calif1 = Convert.ToDouble(Console.ReadLine());

            ////Hacemos la segunda peticion
            //Console.Write("Dame la calificacion del segundo alumno: ");
            //calif2 = Convert.ToDouble(Console.ReadLine());

            ////Hacemos la tercera peticion 
            //Console.Write("Dame la calificacion del tercer alumno: ");
            //calif3 = Convert.ToDouble(Console.ReadLine());

            //promedio = (calif1 + calif2 + calif3) / 3;

            //Console.WriteLine("El promedio de las calificaciones de los tres alumnos es: " + promedio);

            ////NOTA: esto ya se esta volviendo una tarea extensa por que hay que escribir muchas lineas de codigo, conforme se agregan mas alumnos.


            //Variables 
            byte i, numAlumnos;
            double calificaciones;
            double sumCalif = 0;
            double promedio;

            //Perdir que ingrese el numero de alumnos 
            Console.Write("Ingrese el numero de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for( i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Ingrese la calificacion: ");
                calificaciones = Convert.ToDouble(Console.ReadLine());

                sumCalif += calificaciones;

            }

            //Calculamos el promedio
            promedio = sumCalif / numAlumnos;

            Console.WriteLine("El promedio es: {0}", promedio);
        }
    }
}
