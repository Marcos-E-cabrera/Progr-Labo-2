/*
                                                        Ejercicio I02 - Números locos2
Consigna:
            Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros 
            (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

            1. Mostrar el vector tal como fue ingresado.
            2. Luego mostrar los positivos ordenados en forma decreciente.
            3. Por último, mostrar los negativos ordenados en forma creciente.
 
 */

using System;

namespace Unidad_06_Ejercicio_i02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero;

            #region LIST
            List<int> vector = new List<int>();

            while (vector.Count < 20)
            {
                numero = random.Next(-100, 100);
                if (numero != 0)
                {
                    vector.Add(numero);
                }
            }

            Console.WriteLine("El vector tal como fue ingresado: ");
            ImprimirVector(vector);

            Console.WriteLine("\n\nlos positivos ordenados en forma decreciente:");
            List<int> positivosOrdenados = vector.Where(num => num > 0).OrderByDescending(num => num).ToList();
            ImprimirVector(positivosOrdenados);


            Console.WriteLine("\n\nlos negativos ordenados en forma creciente:");
            List<int> negativosOrdenados = vector.Where(num => num < 0).OrderBy(num => num).ToList();
            ImprimirVector(negativosOrdenados);
            #endregion

            #region STACK
            Stack<int> stack = new Stack<int>();

            while (stack.Count < 20)
            {
                numero = random.Next(-100, 100);
                if (numero != 0)
                {
                    stack.Push(numero);
                }
            }

            Console.WriteLine("\n\nEl Stack tal como fue ingresado: ");
            ImprimirStack(stack);

            Console.WriteLine("\n\nlos positivos ordenados en forma decreciente:");
            Stack<int> stackPositivosOrdenados = new Stack<int>(stack.Where(num => num > 0).OrderBy(num => num));
            ImprimirStack(stackPositivosOrdenados);

            Console.WriteLine("\n\nlos negativos ordenados en forma creciente:");
            Stack<int> stackNegativosOrdenados = new Stack<int>(stack.Where(num => num < 0).OrderByDescending(num => num));
            ImprimirStack(stackNegativosOrdenados);
            #endregion

            #region Queue
            Queue<int> queue = new Queue<int>();

            while (queue.Count < 20)
            {
                numero = random.Next(-100, 100);
                if (numero != 0)
                {
                    queue.Enqueue(numero);
                }
            }

            Console.WriteLine("\n\nEl Queue tal como fue ingresado: ");
            ImprimirQueue(queue);

            Console.WriteLine("\n\nlos positivos ordenados en forma decreciente:");
            Stack<int> QueuePositivosOrdenados = new Stack<int>(stack.Where(num => num > 0).OrderBy(num => num));
            ImprimirStack(QueuePositivosOrdenados);

            Console.WriteLine("\n\nlos negativos ordenados en forma creciente:");
            Stack<int> QueueNegativosOrdenados = new Stack<int>(stack.Where(num => num < 0).OrderByDescending(num => num));
            ImprimirStack(QueueNegativosOrdenados);

            #endregion
        }

        static void ImprimirVector(List<int> vector)
        {
            foreach (int item in vector)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
        }

        static void ImprimirStack(Stack<int> stack)
        {
            foreach (int item in stack)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();            
        }

        static void ImprimirQueue(Queue<int> queue)
        {
            foreach (int item in queue)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
        }
    }
}