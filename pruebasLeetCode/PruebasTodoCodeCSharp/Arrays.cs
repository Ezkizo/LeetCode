namespace pruebasLeetCode.PruebasTodoCodeCSharp;
public class Arrays
{
    String[] _nombres = new String[8];
    public void Something()
    {
        var nombres = new String[] { "Juan", "Pedro", "Maria", "Jose", "Ana", "Luis", "Carlos", "Sofia" };
        for (int i = 0; i <= _nombres.Length - 1; i++)
        {
            _nombres[i] = nombres[i];
        }
        for (int i = 0; i <= _nombres.Length -1; i++)
        {
            Console.WriteLine($"Índice {i+1}: " + _nombres[i]);
        }
    }
}
