namespace CalculadoraFisica;
// Programa principal de la calculadora de cinemática
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding =
        System.Text.Encoding.UTF8;

        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();

            string opcion =
            Console.ReadLine() ?? "0";

            continuar =
            ProcesarOpcion(opcion);
        }
    }
    static void MostrarMenu()
{
    Console.Clear();

    Console.WriteLine("================================");
    Console.WriteLine(" CALCULADORA DE CINEMÁTICA ");
    Console.WriteLine("================================");
    Console.WriteLine("1. Calcular Velocidad");
    Console.WriteLine("2. Calcular Distancia");
    Console.WriteLine("3. Calcular Tiempo");
    Console.WriteLine("0. Salir");

    Console.Write("\nElige una opción: ");
}

static bool ProcesarOpcion(string opcion)
{
    Console.WriteLine();

    switch (opcion.Trim())
    {
        case "1":

            double d1 = EntradaUsuario.PedirDouble(
                "Distancia (m): ");

            double t1 = EntradaUsuario.PedirDouble(
                "Tiempo (s): ");

            double velocidad =
                Calculos.CalcularVelocidad(d1, t1);

            Console.WriteLine(
                $"\nVelocidad = {velocidad:F2} m/s");

            break;

        case "2":

            double velocidad2 =
                EntradaUsuario.PedirDouble(
                "Velocidad (m/s): ");

            double tiempo2 =
                EntradaUsuario.PedirDouble(
                "Tiempo (s): ");

            double distancia =
                Calculos.CalcularDistancia(
                velocidad2,
                tiempo2);

            Console.WriteLine(
                $"\nDistancia = {distancia:F2} m");

            break;

        case "3":

            double distancia3 =
                EntradaUsuario.PedirDouble(
                "Distancia (m): ");

            double velocidad3 =
                EntradaUsuario.PedirDouble(
                "Velocidad (m/s): ");

            double tiempo =
                Calculos.CalcularTiempo(
                distancia3,
                velocidad3);

            Console.WriteLine(
                $"\nTiempo = {tiempo:F2} s");

            break;

        case "0":

            Console.WriteLine(
                "\nGracias por usar el programa.");

            return false;

        default:

            Console.WriteLine(
                "\nOpción inválida.");

            break;
    }

    Console.WriteLine(
        "\nPresiona ENTER para continuar...");

    Console.ReadLine();

    return true;
}


}
