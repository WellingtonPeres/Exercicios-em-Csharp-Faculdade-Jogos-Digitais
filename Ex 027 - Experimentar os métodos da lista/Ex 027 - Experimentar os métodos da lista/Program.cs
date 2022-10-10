using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_027___Experimentar_os_métodos_da_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declarar uma lista de string e experimentar os métodos:
             * Add, Count, Insert, Remove, RemoveAt, Clear, IndexOf, Sort, Reverse. */

            List<string> listaTeste = new List<string>();

            #region Método (Add)
            Console.WriteLine("Método (Add):");
            Console.WriteLine("-------------");
            listaTeste.Add("sim");
            listaTeste.Add("teste");
            listaTeste.Add("prata");
            foreach (string item in listaTeste)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Método (Count)
            Console.WriteLine("Método (Count):");
            Console.WriteLine("-------------");
            Console.WriteLine(listaTeste.Count);
            #endregion

            #region Método (Insert)
            Console.WriteLine("Método (Insert):");
            Console.WriteLine("-------------");
            listaTeste.Insert(1, "não");
            listaTeste.Insert(3, "sim");
            foreach (string item in listaTeste)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Método (Remove)
            Console.WriteLine("Método (Remove):");
            Console.WriteLine("-------------");
            listaTeste.Remove("sim");
            foreach (string item in listaTeste)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Método (RemoveAt)
            Console.WriteLine("Método (RemoveAt):");
            Console.WriteLine("-------------");
            listaTeste.RemoveAt(2);
            foreach (string item in listaTeste)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Método (Clear)
            //Console.WriteLine("Método (Clear):");
            //Console.WriteLine("-------------");
            //listaTeste.Clear();
            //Console.WriteLine(listaTeste.Count);
            #endregion

            #region Método (IndexOf)
            Console.WriteLine("Método (IndexOf):");
            Console.WriteLine("-------------");
            Console.WriteLine(listaTeste.IndexOf("sim"));
            #endregion

            #region Método (Sort)
            Console.WriteLine("Método (Sort):");
            Console.WriteLine("-------------");
            listaTeste.Sort();
            foreach (string item in listaTeste)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Método (Reverse)
            Console.WriteLine("Método (Reverse):");
            Console.WriteLine("-------------");
            listaTeste.Reverse();
            foreach (string item in listaTeste)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.ReadLine();
        }
    }
}
