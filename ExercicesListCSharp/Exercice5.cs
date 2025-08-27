using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace ExercicesListCSharp;

public class Exercice5
{
    //public static void Main()
    //{
    //    Console.WriteLine("####### Verificação de Placas do Detran #######");

    //    Console.WriteLine("\nDigite a placa do seu carro abaixo \nObs.: 7 caracteres alfanuméricos (3 letras e 4 números \n--------------------------------------------------------");
    //    var car_license_plate = Convert.ToString(Console.ReadLine());

    //    if (String.IsNullOrEmpty(car_license_plate))
    //    {
    //        Console.WriteLine("Placa vazia. Tente novamente!");
    //        return;
    //    }

    //    if(car_license_plate.Length<=0 || car_license_plate.Length>7)
    //    {
    //        Console.WriteLine("Placa inválida. Tente novamente!");
    //        return;
    //    }

    //    string car_license_plate_without_spaces = car_license_plate.Trim();

    //    List<char> letters = new List<char>();
    //    int letter_counter = 0;

    //    while (letter_counter < 3)
    //    {
    //        letters.Add(car_license_plate_without_spaces[letter_counter]);
    //        letter_counter++;
    //    }

    //    List<char> numbers = new List<char>();
    //    int number_counter = 3;

    //    while (number_counter < 7)
    //    {
    //        numbers.Add(car_license_plate_without_spaces[number_counter]);
    //        number_counter++;
    //    }

    //    bool lettersValid = true;
    //    bool numbersValid = true;

    //    for (int i=0; i<letters.Count; i++)
    //    {
    //        if(!char.IsLetter(letters[i]))
    //        {
    //            lettersValid = false;
    //            break;
    //        }
    //    }

    //    for(int i=0; i<numbers.Count; i++)
    //    {
    //        if(!char.IsDigit(numbers[i]))
    //        {
    //            numbersValid = false;
    //            break;
    //        }
    //    }

    //    if (!lettersValid && !numbersValid)
    //    {
    //        Console.WriteLine("Placa completamente inválida. Tente novamente!");
    //    }
    //    else if (!lettersValid)
    //    {
    //        Console.WriteLine("Começo da placa é inválida. Tente novamente!");
    //    }
    //    else if (!numbersValid)
    //    {
    //        Console.WriteLine("Final da placa é inválida. Tente novamente!");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"A placa '{car_license_plate_without_spaces}' é válida!");
    //    }

    //}
}