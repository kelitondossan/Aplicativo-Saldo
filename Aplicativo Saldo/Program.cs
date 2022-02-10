using System;
using System.Globalization;

namespace Aplicativo_Saldo
{
    class Program
    {
        static void Main(string[] args)
        {// PROGRAMA PARA IMPRIMIR NA TELA 
            string produto1 = "computador ";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';


            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é {preco1:F1} ");
            Console.WriteLine($"{produto2} de escritório, cujo preço é {preco2:F2}\n\n");
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo}  e genero: {genero}\n\n");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arrendondamento(três casa decimais) : {medida:F3} ");
            Console.WriteLine("Separador decimal " + medida.ToString("F3"), CultureInfo.InvariantCulture);





        }
    }
}
