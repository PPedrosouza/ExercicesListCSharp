using System.Globalization;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercicesListCSharp;

public class Exercice6
{
    public static void Main()
    {
        Console.WriteLine("####### Datas #######");

        DateTime today = DateTime.Now;

        Console.WriteLine($"\nFormato completo: {today.ToString("F", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"Data resumida: {today.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"Hora: {today.ToString("HH:mm" + "", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"Data por extenso: {today.ToString("dd ' de ' MMMM ' de ' yyyy", new CultureInfo("pt-BR"))}");

    }
}