namespace CalculadoraFisica;

static class EntradaUsuario
{
    /// <summary>
    /// Solicita un número decimal al usuario con validación robusta.
    /// </summary>
    /// <param name="mensaje">Texto mostrado al usuario</param>
    /// <param name="soloPositivos">
    /// Si es true, no permite cero ni negativos.
    /// </param>
    /// <returns>Valor double validado</returns>
    public static double PedirDouble(
        string mensaje,
        bool soloPositivos = true)
    {
        while (true)
        {
            Console.Write(mensaje);

            string entrada = Console.ReadLine() ?? "";

            if (double.TryParse(
                entrada,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out double resultado))
            {
                if (soloPositivos && resultado <= 0)
                {
                    Console.WriteLine(
                        "El valor debe ser mayor que cero.");
                    continue;
                }

                return resultado;
            }

            Console.WriteLine(
                "Entrada inválida. Intenta nuevamente.");
        }
    }
}