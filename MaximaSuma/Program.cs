using System;

class Program
{
    static void Main()
    {
        int[] array = { 4, -3, 5, -2, -1, 2, 6, -2 };
        int maxSum = MaxSubArraySum(array);
        Console.WriteLine("La máxima suma de subarray es: " + maxSum);
    }

    static int MaxSubArraySum(int[] array)
    {
        // Inicialización de las variables
        int maxCurrent = array[0]; // La suma máxima de la subarray que termina en la posición actual
        int maxGlobal = array[0];  // La suma máxima encontrada hasta ahora

        // Iteración a través del array comenzando desde el segundo elemento
        for (int i = 1; i < array.Length; i++)
        {
            // Actualizar maxCurrent
            maxCurrent = Math.Max(array[i], maxCurrent + array[i]);

            // Actualizar maxGlobal si maxCurrent es mayor
            if (maxCurrent > maxGlobal)
            {
                maxGlobal = maxCurrent;
            }

            
        }

        // Devolver la suma máxima encontrada
        return maxGlobal;

        
        
    }
}