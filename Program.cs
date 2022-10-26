using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOS...\n");
            Console.WriteLine("DEFINA EL TAMAÑO DEL VECTOR: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            facundoList lista = new facundoList(n); //iniciamos el constructor con parametros;

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. HACER PUSH");
                    Console.WriteLine("2. INSERT");
                    Console.WriteLine("3. LISTAR");
                    Console.WriteLine("4. ELIMINAR");
                    Console.WriteLine("5. BUSCAR");
                    Console.WriteLine("6. OBTENER");
                    Console.WriteLine("7. ORDENAR");
                    Console.WriteLine("8. SALIR");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    switch (opcion)
                    {
                        
                        case 1:
                            
                            Console.WriteLine("ingrese el valor a insertar");
                            int valor = int.Parse(Console.ReadLine());
                            lista.push(valor);
                            Console.Clear();
                            break;

                        case 2:
                            Console.WriteLine("ingrese el valor a insertar ");
                            int insert = int.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese la posición ");
                            int posicion = int.Parse(Console.ReadLine());
                            lista.insertarNumero(insert, posicion);
                            Console.Clear();
                            break;

                        case 3:
                            //Console.WriteLine("Has elegido la opción 3");
                            lista.listarVector();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("ingrese la posición a eliminar ");
                            int delete = int.Parse(Console.ReadLine());
                            lista.eliminar(delete);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 5:
                            Console.WriteLine("ingrese el valor a buscar");
                            int buscar = int.Parse(Console.ReadLine());
                            lista.buscar(buscar);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 6:
                            Console.WriteLine("ingrese el valor del indice: ");
                            int obtener = int.Parse(Console.ReadLine());
                            lista.obtener(obtener);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 7:
                            Console.WriteLine("SE VA A ORDENAR EL ARRAY DE MENOR A MAYOR");
                            lista.ordenar();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 8:
                            Console.WriteLine("Saliendo...");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 7");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();

        }
    }
}
