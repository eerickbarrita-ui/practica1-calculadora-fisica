namespace CalculadoraFisica;

/// <summary>
/// Módulo de cálculos físicos de cinemática.
/// </summary>
static class Calculos
{
    /// <summary>
    /// Calcula velocidad usando out: v = d / t.
    /// </summary>
    public static void CalcularVelocidad(
        double distanciaMetros,
        double tiempoSegundos,
        out double velocidadMs)
    {
        velocidadMs = distanciaMetros / tiempoSegundos;
    }

    /// <summary>
    /// Calcula distancia usando ref: d = v * t.
    /// </summary>
    public static void CalcularDistancia(
        ref double distanciaMetros,
        double velocidadMs,
        double tiempoSegundos)
    {
        distanciaMetros = velocidadMs * tiempoSegundos;
    }

    /// <summary>
    /// Calcula tiempo usando out: t = d / v.
    /// </summary>
    public static void CalcularTiempo(
        double distanciaMetros,
        double velocidadMs,
        out double tiempoSegundos)
    {
        tiempoSegundos = distanciaMetros / velocidadMs;
    }
}