using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOperadores;
            Console.WriteLine("Ingrese cantidad de operadores");
            int cantOperadores = Convert.ToInt32(Console.ReadLine());
            arrayOperadores = new int[cantOperadores];

           for (int indice=0; indice < cantOperadores; indice++)
            {  
            arrayOperadores[indice] = indice;
            }
            //ArrayOperadores = [0,1,2,3,4,....] Desde Nro de operador 0 hasta cantOperadores-1
            foreach (int a in arrayOperadores)
            {
                Console.WriteLine(a);
            }

            Queue<int> colaDeOrdenes = new Queue<int>();
            colaDeOrdenes.Enqueue(111);
            colaDeOrdenes.Enqueue(222);
            colaDeOrdenes.Enqueue(333);
            colaDeOrdenes.Enqueue(444);
            colaDeOrdenes.Enqueue(555);
            colaDeOrdenes.Enqueue(666);
            colaDeOrdenes.Enqueue(777);
            colaDeOrdenes.Enqueue(888);
            colaDeOrdenes.Enqueue(999);

            Dictionary<int, List<int>> operadores = new Dictionary<int, List<int>>();
            
            int op = -1;
            while (op != 999 && colaDeOrdenes.Count > 0)
            {
                int orden = colaDeOrdenes.Peek();
                //Console.WriteLine(orden);
                if (op !=-1)
                { 
                while (op < arrayOperadores[0] || op > arrayOperadores[cantOperadores-1] )
                {
                    Console.WriteLine("No existe el operador seleccionado, ingrese uno nuevo");
                    op = Convert.ToInt32(Console.ReadLine());
                        if (op == 999)
                            {
                            break;
                            }
                }
                colaDeOrdenes.Dequeue();
                    
                if (operadores.ContainsKey(op))
                {
                 operadores[op].Add(orden);
                }
                else
                {
                    List<int> listaDeOrdenes = new List<int>();
                    listaDeOrdenes.Add(orden);
                    operadores.Add(arrayOperadores[op],listaDeOrdenes);
                }
                if (colaDeOrdenes.Count >0)
                    { 
                    orden = colaDeOrdenes.Peek();
                    }
                }
                Console.WriteLine("Seleccione operador para asignar la orden " + orden + " o escriba 999 para continuar");
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 999)
                {
                    break;
                }
            }

                foreach (KeyValuePair<int, List<int>> operador in operadores)
                {
                    Console.WriteLine("El operador " + operador.Key + " posee las siguientes ordenes asignadas: ");
                    
                    foreach (int o in operador.Value)
                    {
                    Console.Write("Orden: " + o + " ");
                    Console.WriteLine("");
                }
                }

            Console.WriteLine("Las ordenes sin asignar son: ");
                foreach (int q in colaDeOrdenes)
                {
                Console.WriteLine(q);
                }


            
               
            Console.ReadKey();
        }
}
}

 