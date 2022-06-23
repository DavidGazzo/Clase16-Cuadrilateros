
namespace Clase16_Cuadrilateros.Modelo;

internal class Program
{
    static void Main(string[] args)
    {
        // Coordenadas para un cuadrado
        int[] infIzq = new int[] { 1, 1 };
        int[] supIzq = new int[] { 1, 4 };
        int[] supDer = new int[] { 4, 4 };
        int[] infDer = new int[] { 4, 1 };
        SupCuadrado(infIzq, supIzq, infDer, supDer);

        // Coordenadas para un rectángulo
        infIzq[0] = 1;
        infIzq[1] = 1;
        supIzq[0] = 1;
        supIzq[1] = 4;
        supDer[0] = 5;
        supDer[1] = 4;
        infDer[0] = 5;
        infDer[1] = 1;
        SupRectangulo(infIzq, supIzq, infDer, supDer);

        // Coordenadas para un trapecio
        infIzq[0] = 1;
        infIzq[1] = 1;
        supIzq[0] = 3;
        supIzq[1] = 4;
        supDer[0] = 6;
        supDer[1] = 4;
        infDer[0] = 9;
        infDer[1] = 1;
        SupTrapecio(infIzq, supIzq, infDer, supDer);
    }
    
    static void SupCuadrado(int[] infIzq, int[] supIzq, int[] infDer, int[] supDer)
    {
        Cuadrado cuadrado = new Cuadrado(infIzq, supIzq, infDer, supDer);
        double superf = cuadrado.Area(infIzq, supIzq, infDer, supDer);
        Console.WriteLine($"Superficie del Cuadrado: {superf} unidades²");
    }

    static void SupRectangulo(int[] infIzq, int[] supIzq, int[] infDer, int[] supDer)
    {
        Rectangulo rectangulo = new Rectangulo(infIzq, supIzq, infDer, supDer);
        double superf = rectangulo.Area(infIzq, supIzq, infDer, supDer);
        Console.WriteLine($"Superficie del Rectángulo: {superf} unidades²");
    }

    static void SupTrapecio(int[] infIzq, int[] supIzq, int[] infDer, int[] supDer)
    {
        Trapecio trapecio = new Trapecio(infIzq, supIzq, infDer, supDer);
        double superf = trapecio.Area(infIzq, supIzq, infDer, supDer);
        Console.WriteLine($"Superficie del Trapecio: {superf} unidades²");
    }
}