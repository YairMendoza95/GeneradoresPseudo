using System;
using System.Collections.Generic;

namespace GeneradoresPseudo
{
    public class MetodoCuadrados
    {
        public string sem = "", quadS = "", newSem = "", numA = "";
        public int longSem = 0, semN, longQuad = 0;
        double quad;
        public List<string> Semillas = new List<string>();
        public List<string> NumAlea = new List<string>();
        private int _Menu()
        {
            Console.Clear();
            Console.Write("\t\t\t\t-----Generador de Cuadrados Medios-----\n\n");
            Console.Write("1) Generar \n2) Salir \n\nElija su opción: ");
            return (int.Parse(Console.ReadLine()));
        }
        public void Cuadrados()
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
                        switch (opc)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("\t\t\t\t-----Generador de Cuadrados Medios-----\n\n");
                                _Generar();
                                Console.Write("\n\nPulse una tecla para continuar....");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("\t\t\t\t-----Generador de Cuadrados Medios----- \n\nAdios.... \nPulse una tecla para contiuar....");
                                Console.ReadKey();
                                break;
                            default:
                                Console.Clear();
                                Console.Write("\t\t\t\t-----Generador de Cuadrados Medios-----\n\nOpción inválida.... \nPulse una tecla para continuar....");
                                Console.ReadKey();
                                break;
                        }
                    } while (opc != 2);
                    x = true;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.Write("\t\t\t\t-----Generador de Cuadrados Medios----- \n\nError.... \n{0} \n\nPulse una tecla para continuar....", ex.Message);
                    Console.ReadKey();
                    x = false;
                }
            } while (x == false);
        }
        private void _Generar()
        {
            Console.Write("Ingresa la semilla: ");
            sem = Console.ReadLine();
            Console.WriteLine("\n\n--------------------------------------------------");
            Console.WriteLine("|     n     |     Xn     |   Xn+1   |    # P.    |");
            Console.WriteLine("--------------------------------------------------");
            int i = 0;
            while (semN != Convert.ToInt32(newSem))
            {
                NumAlea.Add(numA);
                Semillas.Add(sem);
                longSem = sem.Length;
                semN = Convert.ToInt32(sem);
                quad = Math.Pow(semN, 2);
                quadS = quad.ToString();
                longQuad = quadS.Length;
                while (longQuad < longSem * 2)
                {
                    quadS = "0" + quadS;
                }
                if (longQuad == longSem)
                {
                    newSem = quadS.Substring((longSem / 2), longSem);
                    numA = "." + newSem;
                    Console.WriteLine("|     {0}     |     {1}     |   {2}   |    {3}    |", i, sem, newSem, numA);
                    Console.WriteLine("--------------------------------------------------");
                    sem = newSem;
                    if (sem == Semillas[0])
                        break;
                    i++;
                }
            }
        }
    }
}