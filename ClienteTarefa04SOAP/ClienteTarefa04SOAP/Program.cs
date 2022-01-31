using System;
using ServicoReferenciaAreaDePoligonos;

namespace ClienteTarefa04SOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceAreaDePoligonosClient client = new InterfaceAreaDePoligonosClient();

            Console.WriteLine("Área de Polígonos utilizando SOAP\n");
            
            Console.WriteLine("|----------POLÍGONOS REGULARES------------|");
            Console.WriteLine("   |--(a): Triângulo");
            Console.WriteLine("   |--(b): Retângulo");
            Console.WriteLine("   |--(c): Pentágono");
            Console.WriteLine("   |--(d): Hexágono");
            Console.WriteLine("|----------POLÍGONOS IRREGULARES----------|");
            Console.WriteLine("   |--(e): Losango");
            Console.WriteLine("   |--(f): Trapézio\n");

            while (true)
            {
                string op;
                Console.WriteLine("Escolha a operação ou insira 'x' para sair:");
                op = Console.ReadLine();
                if (op == "x") break;

                string[] argumentos;
                switch (op) 
                {
                    case "a":
                        Console.WriteLine("\nTRIÂNGULO: Insira base e altura:");
                        argumentos = Console.ReadLine().Split();

                        areaTrianguloRequest reqTriangulo = new areaTrianguloRequest(double.Parse(argumentos[0]), double.Parse(argumentos[1]));
                        areaTrianguloResponse resTriangulo = client.areaTriangulo(reqTriangulo);

                        Console.WriteLine("\nResultado: " + resTriangulo.@return.ToString("N6") + "\n");

                        break;
                    case "b":
                        Console.WriteLine("\nRETÂNGULO: Insira base e altura:");
                        argumentos = Console.ReadLine().Split();

                        areaRetanguloRequest reqRetangulo = new areaRetanguloRequest(double.Parse(argumentos[0]), double.Parse(argumentos[1]));
                        areaRetanguloResponse resRetangulo = client.areaRetangulo(reqRetangulo);

                        Console.WriteLine("\nResultado: " + resRetangulo.@return.ToString("N6") + "\n");

                        break;
                    case "c":
                        Console.WriteLine("\nPENTÁGONO: Insira lado e apótema:");
                        argumentos = Console.ReadLine().Split();

                        areaPentagonoRequest reqPentagono = new areaPentagonoRequest(double.Parse(argumentos[0]), double.Parse(argumentos[1]));
                        areaPentagonoResponse resPentagono = client.areaPentagono(reqPentagono);

                        Console.WriteLine("\nResultado: " + resPentagono.@return.ToString("N6") + "\n");

                        break;
                    case "d":
                        Console.WriteLine("\nHEXÁGONO: Insira lado:");
                        string lado = Console.ReadLine();

                        areaHexagonoRequest reqHexagono = new areaHexagonoRequest(double.Parse(lado));
                        areaHexagonoResponse resHexagono = client.areaHexagono(reqHexagono);

                        Console.WriteLine("\nResultado: " + resHexagono.@return.ToString("N6") + "\n");

                        break;
                    case "e":
                        Console.WriteLine("\nLOSANGO: Insira as duas diagonais:");
                        argumentos = Console.ReadLine().Split();

                        areaLosangoRequest reqLosango = new areaLosangoRequest(double.Parse(argumentos[0]), double.Parse(argumentos[1]));
                        areaLosangoResponse resLosango = client.areaLosango(reqLosango);

                        Console.WriteLine("\nResultado: " + resLosango.@return.ToString("N6") + "\n");

                        break;
                    case "f":
                        Console.WriteLine("\nTRAPÉZIO: Insira as duas bases e a altura:");
                        argumentos = Console.ReadLine().Split();

                        areaTrapezioRequest reqTrapezio = new areaTrapezioRequest(double.Parse(argumentos[0]), double.Parse(argumentos[1]), double.Parse(argumentos[2]));
                        areaTrapezioResponse resTrapezio = client.areaTrapezio(reqTrapezio);

                        Console.WriteLine("\nResultado: " + resTrapezio.@return.ToString("N6") + "\n");

                        break;
                    default: break;
                }
            }
        }
    }
}
