using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_dotNetDeveloperIntermediario.Models
{
    public class Excecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção tratada." + ex.Message);
            }
            Console.WriteLine("Método1");
        }
        public void Metodo2()
        {
            Metodo3();
            Console.WriteLine("Método2");
        }
        public void Metodo3()
        {
            Metodo4();
            Console.WriteLine("Método3");

        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu exceção!");

        }
    }
}