namespace ExercicesListCSharp;

public class Execise3
{
    //static void Main()
    //{
    //    Console.WriteLine("####### Calculadora CSharp #######");
    //    Console.WriteLine("\noperações matemáticas que serão feitas: \nsoma \nsubtração \nmultiplicação \ndivisão \nmédia.");

    //    Console.WriteLine("\nDigite o seu primeiro número:");
    //    var var_first_number = Console.ReadLine();
    //    Console.WriteLine("Digite o seu segundo número:");
    //    var var_second_number = Console.ReadLine();

    //    if (!double.TryParse(var_first_number, out double first_number) ||
    //        !double.TryParse(var_second_number, out double second_number))
    //    {
    //        Console.WriteLine("Os valores não podem ser nulos ou inválidos. Tente novamente!");
    //        return;
    //    }

    //    double sum = Sum(first_number, second_number);
    //    double subtraction = Subtraction(first_number, second_number);
    //    double multiplication = Multiplication(first_number, second_number);
    //    double division = Division(first_number, second_number);
    //    double average = Average(first_number, second_number);

    //    Console.WriteLine($"Soma: {sum}");
    //    Console.WriteLine($"Subtração: {subtraction}");
    //    Console.WriteLine($"Multiplicação: {multiplication}");
    //    Console.WriteLine($"Divisão: {division}");
    //    Console.WriteLine($"Média: {average}");

    //}

    public static double Sum(double a, double b) => a + b;
    public static double Subtraction(double a, double b) => a - b;
    public static double Multiplication(double a, double b) => a * b;
    public static double Division(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Divisão por zero não é permitida.");
            return 0;
        }

        return a / b;
    }
    public static double Average(double a, double b) => (a + b) / 2;

}
