using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_v1
{
    class facundoList
    {
        private int[] arreglo;
        private int contador;
        private int tamañoArreglo;

        public facundoList(int tamaño)
        {
            arreglo = new int[tamaño];
            tamañoArreglo = tamaño;
            contador = 0;
        } //constructor

        public void push(int insertar)
        {

            if (contador <= tamañoArreglo - 1)
            {
                //inserto el valor
                arreglo[contador] = insertar;
                contador++;
            }
            else
            {
                //se duplica el array al tamaño doble
                int n2 = tamañoArreglo * 2;
                int[] arregloNuevo = new int[n2];

                for (int i = 0; i < tamañoArreglo; i++)
                {
                    arregloNuevo[i] = arreglo[i];//pasan los valor del vector viejo al nuevo

                }
                tamañoArreglo = n2;                     //cambio de asignación de variables
                arreglo = arregloNuevo;     //cambio de asignación de variables
                push(insertar);             //vuelvo a llamar a la misma función.

            }
        } //metodo push insertar al final

        public void insertarNumero(int valorInsertar, int posicion)
        {
            if (posicion >= tamañoArreglo)
            {
                //posición no es valido porque es mayor que el tamaño del array, mensaje y sale
                Console.WriteLine("valor no válido, ingrese un tamaño menor");
                return;
            }
            if (arreglo[posicion] == 0)
            {
                //este caso, es colocar en el ulitmo valor; 
                arreglo[posicion] = valorInsertar;

            }
            else
            {
                //se crea un array auxiliar para mover los datos
                int[] arregloAux = new int[tamañoArreglo - posicion];
                for (int i = 0; i < arregloAux.Length; i++)
                {
                    arregloAux[i] = arreglo[posicion + i];
                }

                arreglo[posicion] = valorInsertar;
                contador = posicion + 1;

                for (int j = 0; j < arregloAux.Length; j++)
                {
                    if (arregloAux[j] == 0)
                    {
                        continue;
                    }
                    push(arregloAux[j]);//llamar a push
                }

            }

        } //insertar en una posición

        public void eliminar(int posicion)
        {
            if (posicion > tamañoArreglo)
            {
                Console.WriteLine("error, no existe esa posición");
                return;
            }
            if (posicion == tamañoArreglo - 1)
            {
                //ESTA BORRANDO EL ULITMO ELEMENTO DEL ARRAY
                int[] arregloAux = new int[tamañoArreglo - 1];
                for (int i = 0; i < arregloAux.Length; i++)
                {
                    arregloAux[i] = arreglo[i];
                }
                arreglo = arregloAux;
                contador--;
                tamañoArreglo--;
            }
            else
            {
                //BORRA UNO DEL MEDIO
                int[] arregloAux = new int[tamañoArreglo - 1];

                if (posicion == 0) //BORRA EL PRIMER ELEMENTO
                {
                    for (int i = 0; i < arregloAux.Length; i++)
                    {
                        arregloAux[i] = arreglo[i + 1];
                    }
                }
                else
                {
                    int aux = 0;
                    for (int i = 0; i < arregloAux.Length; i++)
                    {
                        if (posicion == i)
                        {
                            arregloAux[i] = arreglo[i + 1];
                            aux = 1;
                        }
                        else
                        {
                            arregloAux[i] = arreglo[i + aux];
                        }

                    }
                }
                arreglo = arregloAux;
            }
            contador--;
            tamañoArreglo--;
        } //eliminar una posición

        public void buscar(int buscar)
        {
            int valor = 0;
            for(int i=0; i < arreglo.Length; i++)
            {
                if(arreglo[i] == buscar)
                {
                    valor = i;
                    break;
                }
            }

            if (valor == 0)
            {
                Console.WriteLine("no se encontro el valor {0}",buscar);
            }
            else
            {
                Console.WriteLine("el valor {0} se encuentra en la posición {1}", buscar, valor);
            }
        } // buscar un valor en el array

        public void obtener(int indice)
        {
            if(indice > tamañoArreglo)
            {
                Console.WriteLine("no se puede obtener el valor porque es mas grande que el array");
                return;
            }
            int valor = arreglo[indice];

            Console.WriteLine("el valor que se encuentra en el indice {0} es {1}", indice, valor);
        } // obtener el valor de una posición del array

        public void ordenar()
        {
            int tmp = 0;

            for (int i = 0; i < arreglo.Length; i++)
                for (int j = 0; j < arreglo.Length - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        tmp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = tmp;
                    }
                }
            listarVector();
        } //order de menor a matoy metodo de la burbuja

        public void listarVector() //listar
        {
            foreach (int a in arreglo)
            {
                Console.Write("{0} - ", a);

            }
            Console.WriteLine("\n");
            Console.WriteLine("tamaño del arrego: {0}", tamañoArreglo);
            Console.WriteLine("valor del contador: {0}", contador);
        }


    }
}

