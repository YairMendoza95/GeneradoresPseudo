using System;

namespace GeneradoresPseudo
{
    public class Program
    {
        static int Menu()
        {
            Console.Write("\t\t\t\t-----Generadores de Números Pseudo-aleatorios-----\n");
            Console.Write("\n1) Generador de Cuadrados Medios \n2) Generador Congruencial Lineal \n3) Generador de Productos Medios \n4) Salir\n");
            Console.Write("\nElige una opción: ");
            return (int.Parse(Console.ReadLine()));
        }
        public static void Main()
        {
            bool x;
            do
            {
                try
                {
                    int opc;
                    do
                    {
                        Console.Clear();
                        opc = Menu();
                        switch(opc)
                        {
                            case 1:
                                Console.Clear();
                                MetodoCuadrados quad = new MetodoCuadrados();
                                quad.Cuadrados();
                                break;
                            case 2:
                                Console.Clear();
                                MetodoCongrunencial mCon = new MetodoCongrunencial();
                                mCon.Congruencial();
                                break;
                            case 3:
                                Console.Clear();
                                MetodoProductos mPro = new MetodoProductos();
                                mPro.Productos();
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Adios.....");
                                break;
                            default:
                                Console.Clear();
                                Console.Write("\t\t\t\t-----Generadores de Números Pseudo-aleatorios----- \n\nOpción inválida.... \nPulse una tecla para continuar....");
                                Console.ReadKey();
                                break;
                        }
                    } while (opc != 4);
                    x = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error... \n{0}\n\nPulse una tecla par continuar....", ex.Message);
                    Console.ReadKey();
                    x = false;
                }
            } while (x == false);
        }
    }
}
