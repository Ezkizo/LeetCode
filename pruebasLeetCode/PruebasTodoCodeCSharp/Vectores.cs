namespace pruebasLeetCode.PruebasTodoCodeCSharp;
public class Vectores
{
    public void Primero()
    {
        int[] _nums = new int[10];
        var nums = new int[] { 20, 2, 3, 1001, 5, -1, 1011, 8, 9, 10 };
        for (int i = 0; i <= _nums.Length - 1; i++)
        {
            _nums[i] = nums[i];
        }
        int menor = int.MaxValue;
        int mayor = int.MinValue;

        for (int i = 0; i <= _nums.Length - 1; i++)
        {
            if (_nums[i] > mayor)
                mayor = _nums[i];

            if (_nums[i] < menor)
                menor = _nums[i];

        }

        Console.WriteLine($"Menor: {menor}");
        Console.WriteLine($"Mayor: {mayor}");
    }

    public void Segundo(int value)
    {
        int[] _nums = new int[15];
        var nums = new int[] { 20, 2, 3, 1001, 5, -1, 3, 9, 9, 3, -15, -46, 9, 25, 3 };
        _nums = nums;
        var contador = 0;
        foreach (var item in _nums)
        {
            if (item == value)
                contador++;
        }
        Console.WriteLine($"Hay {contador} " + value);
    }

    public void Tercero()
    {
        int[] _nums = new int[12];
        int[] nums = new int[] { 1500, 1200, 1450, 1500, 1600, 1400, 2000, 2100, 5400, 2000, 900, 0 };
        var suma = 0;
        foreach (var item in nums)
        {
            suma += item;
        }
        Console.WriteLine($"La suma es: {suma}");
        Console.WriteLine($"El promedio es: {suma / nums.Length}");
    }
}
