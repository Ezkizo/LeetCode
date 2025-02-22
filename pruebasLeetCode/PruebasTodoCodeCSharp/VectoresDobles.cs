namespace pruebasLeetCode.PruebasTodoCodeCSharp;
public class VectoresDobles
{
    public void Primero()
    {
        int[,] _studentNotes = new int[4, 3];
        int[] _average = new int[4];
        int sum = 0;
        var xd = _studentNotes.Length;
        for (int i = 0; i < _studentNotes.GetLength(0); i++)
        {
            Console.WriteLine("Ingrese las calificaciones del alumno: " + (i + 1));
            sum = 0;
            for (int j = 0; j <= _studentNotes.GetLength(1) - 1; j++)
            {
                Console.WriteLine("Ingrese la calificacion del parcial " + (j + 1) + ":");
                _studentNotes[i, j] = int.Parse(Console.ReadLine());
                sum += _studentNotes[i, j];
                if (j + 1 == _studentNotes.GetLength(1))
                    _average[i] = sum / _studentNotes.GetLength(1);
            }
        }

        for (int x = 0; x < _studentNotes.GetLength(0); x++)
        {
            for (int y = 0; y < _studentNotes.GetLength(1); y++)
            {
                Console.WriteLine("Alumno " + (x + 1) + " Parcial " + (y + 1) + ": " + _studentNotes[x, y]);
            }
            Console.WriteLine("Calificación: " + _average[x]);
        }
    }
}
