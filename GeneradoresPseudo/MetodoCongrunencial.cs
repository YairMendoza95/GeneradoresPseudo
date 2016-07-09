using System;
using System.Collections.Generic;

namespace GeneradoresPseudo
{
    public class MetodoCongrunencial
    {
        public int semilla, modulo, incremento, multiplicador, i;
        public double numAlea = 0, resultado = 0;

        public List<double> numAleaatorios = new List<double>();
        public List<double> semillas = new List<double>();
        private int _Menu()
        {
            Console.Clear();
            Console.Write("\t\t\t\t-----Generador Congruencial Lineal-----");
            Console.Write("\n\n1) Generar \n2) Salir");
            Console.Write("\n\nElija su opción: ");
            return (int.Parse(Console.ReadLine()));
        }
        public void Congruencial()
        {
            bool x;
            do
            {
                try
                {
                    int opc;
                    do
                    {
                        opc = _Menu();
                        switch(opc)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("\t\t\t\t-----Generador Congruencial Lineal------\n\n");
                                _Generar();
                                Console.Write("\n\nPulse una tecla para continuar....");
                                Console.ReadKey();
                                break;
                            case 2:
                                break;
                            default:
                                Console.Clear();
                                Console.Write("\t\t\t\t-----Generador Congruencial Lineal---- \n\nOpción inválida.... \nPulse una tecla para continuar....");
                                Console.ReadKey();
                                break;
                        }
                    } while (opc != 3);
                    x = true;
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    Console.Write("Error.... \n{0}\n\nPulse una tecla oar continuar....", ex.Message);
                    Console.ReadKey();
                    x = false;
                }
            } while (x == false);
        }
        private void _Generar()
        {
            Console.Write("Ingresa el valor de la semilla: ");
            semilla = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor del modulo: ");
            modulo = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor del incremento: ");
            incremento = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor del multiplicador: ");
            multiplicador = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n------------------------------------------------");
            Console.WriteLine("|     n     |     Xn     |   Xn+1   |   # P.   |");
            Console.WriteLine("--------------------------------------------------");
            for (i = 0; i < modulo; i++)
            {
                semillas.Add(semilla);
                numAleaatorios.Add(numAlea);
                resultado = ((multiplicador * semilla) + incremento) % modulo;
                numAlea = resultado / modulo;
                Console.WriteLine("|     {0}     |     {1}     |   {2}   |   {3}   |", i, semilla, resultado, numAlea);
                Console.WriteLine("------------------------------------------------");
                semilla = Convert.ToInt32(resultado);
                if (semilla == semillas[0] || semilla == semillas[i])
                    break;
            }
        }
    }
}
