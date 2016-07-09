using System;
using System.Collections.Generic;

namespace GeneradoresPseudo
{
    public class MetodoProductos
    {
        public List<int> PrimerasSemillas = new List<int>();
        public List<int> SegundasSemillas = new List<int>();
        public List<string> NumAleatorios = new List<string>();
        public int sem1 = 0, sem2 = 0, nuevaSem = 0, longRes = 0, lon1 = 0, lon2 = 0;
        public double resultado = 0;
        public string res = "", num1 = "", num2 = "", numAlea = "", nuevaSemS = "";

        private int _Menu()
        {
            Console.Clear();
            Console.Write("\t\t\t\t-----Generador de Productos Medios-----\n\n");
            Console.Write("1) Generar \n2) Salir");
            Console.Write("\n\nElija su opción: ");
            return (int.Parse(Console.ReadLine()));
        }
        public void Productos()
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
                                Console.Write("\t\t\t-----Generador de Productos Medios------\n\n");
                                _Generar();
                                Console.Write("\n\nPulse una tecla para continuar....");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("\t\t\t-----Generador De Productos Medios------ \n\n\t\t\t\tAdios.....");
                                break;                            
                            default:
                                Console.Clear();
                                Console.Write("\t\t\t-----Generador de Productos Medios---- \nOpción inválida.... \nPulse una tecla para continuar....");
                                Console.ReadKey();
                                break;
                        }
                    } while (opc != 3);
                    x = true;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.Write("Error.... \n\n{0}", ex.Message);
                    x = false;
                }
            } while (x == false);
        }
        private void _Generar()
        {
            Console.Write("Ingresa la primera semilla: ");
            sem1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa la segunda semilla: ");
            sem2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n----------------------------------------------------------------------");
            Console.WriteLine("|     n     | Semilla 1 | Semilla 2 | Producto |   Xn+1   |   # P.   |");
            Console.WriteLine("----------------------------------------------------------------------");
            int i = 0;
            while (sem1 > 0)
            {
                //bool x;
                PrimerasSemillas.Add(sem1);
                SegundasSemillas.Add(sem2);
                resultado = sem1 * sem2;
                res = resultado.ToString();
                longRes = res.Length;
                num1 = sem1.ToString();
                num2 = sem2.ToString();
                lon1 = num1.Length;
                lon2 = num2.Length;
                int longitudes = lon1 + lon2;
                numAlea = "0." + res;
                if (longitudes == longRes)
                {
                    nuevaSemS = res.Substring(lon1 / 2, lon1);
                }
                else
                {
                    do
                    {
                        res = "0" + res;
                    } while (longitudes > longRes);
                    nuevaSemS = res.Substring(lon1 / 2, lon1);
                }
                NumAleatorios.Add(numAlea);
                nuevaSem = Convert.ToInt32(nuevaSemS);
                Console.WriteLine("|     {0}     |     {1}    |     {2}    |    {3}    |   {4}   |   {5}   |", i, sem1, sem2, resultado, nuevaSem, numAlea);
                Console.WriteLine("----------------------------------------------------------------------");
                sem1 = sem2;
                sem2 = nuevaSem;
                i++;
            }
        }
    }
}
