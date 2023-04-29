internal class Program
{
    private static void Main(string[] args)
    {
        float chocolate, menta, flocos, total;
        float quantidade_vendidaChocolate, quantidade_vendidaMenta, quantidade_vendidaFlocos;

        Console.Write("Informe a quantidade de sorvete de chocolate vendida: ");
        quantidade_vendidaChocolate = float.Parse(Console.ReadLine());
        Console.Write("Informe a quantidade de menta vendida: ");
        quantidade_vendidaMenta = float.Parse(Console.ReadLine());
        Console.Write("Informe a quantidade de flocos vendida: ");
        quantidade_vendidaFlocos = float.Parse(Console.ReadLine());

        chocolate = 0.50f;
        menta = 0.60f;
        flocos = 0.75f;

        total = quantidade_vendidaChocolate * chocolate + quantidade_vendidaMenta * menta + quantidade_vendidaFlocos * flocos;

        Console.WriteLine($"O total vendido foi de: {total}");
       

    }

}