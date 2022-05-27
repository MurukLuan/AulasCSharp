using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTaskInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Task tarefa1 = Task.Run(
                () =>

             Console.WriteLine(Contar())

                );
            tarefa1.Wait();



            /*int somar = 0;
            bool tempoDescanso = false;
            Thread th = new Thread(new ThreadStart(() =>
            {
                while (!tempoDescanso)
                {
                    somar++;
                    //Console.WriteLine(somar);
                }
            }));
            th.Start();
            Thread.Sleep(5000);
            tempoDescanso = true;

            Console.WriteLine("A soma no tempo de descanso foi: " + somar);*/

            /*Thread t1 = new Thread(new ThreadStart(T2));
            t1.Start();

            Thread.Sleep(2000);
            Console.WriteLine("Eita eu dormi mais 2 segundos!");*/


            /*Thread linha = new Thread(ExecucaoSegundoPlano);
            linha.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Thread Principal sendo executada ({0}) ...",
                Thread.CurrentThread.ManagedThreadId);*/

            //código da pagina da microsoft


        }
        static int Contar()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Thread.Sleep(2500);
                Console.Write("Demorei 2,5 segundos mas mostrei o valor de i: ");
                Console.Write(i);
                Console.WriteLine();
            }
            return i;

        }

        /*static void ExecucaoSegundoPlano()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Linha: {0}: {1}, Prioridade {2}",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.ThreadState,
                Thread.CurrentThread.Priority);

            do
            {
                Console.WriteLine(@"2) Linha {0}: decorreram {1:N2} segundos.",
                    Thread.CurrentThread.ManagedThreadId,
                    sw.ElapsedMilliseconds / 1000.0);
                Thread.Sleep(500);
            } while (sw.ElapsedMilliseconds <= 5000);

            sw.Stop();
        }*/
        /*static void T2()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Dormi por 5 segundos me desculpa, bora continuar!");
        }*/

    }
}
