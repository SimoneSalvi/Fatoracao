internal class Program
{
    private static void Main(string[] args)
    {
        double numero = 0;
        double controle = 0;
        double produto = 1;

        Console.WriteLine("Informe o numero:");
        numero = double.Parse(Console.ReadLine());
        controle = numero;

        if (numero == 0)
        {
            Console.WriteLine("1");
        }

        if (numero != 0  && numero > 0)
        {
            for(int i = 0; i < controle; i++)
            {
                produto *= numero;
                numero--;

            }
            Console.WriteLine("Resultado:");
            Console.WriteLine(produto);
        }

    }
}