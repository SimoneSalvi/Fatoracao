internal class Program
{
    private static void Main(string[] args)
    {
        double numero = 0;
        double controle = 0;
        double produto = 1;

        Console.WriteLine("Informe o numero:");
        numero = double.Parse(Console.ReadLine());


        if (numero == 0)
        {
            produto = 1;

        }
        else if (numero != 0 && numero > 0)
        {

            fatoracao(numero);
        }


        double fatoracao(double numero)
        {


            {

                produto *= numero;
                numero--;

            }
            if (numero >= 1)
            {
                return fatoracao(numero);
            }

            return produto;

        }

        Console.WriteLine("Resultado:");
        Console.WriteLine(produto);



    }
}