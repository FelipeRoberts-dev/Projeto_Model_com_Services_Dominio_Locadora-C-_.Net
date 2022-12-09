using System;
using LocadoraExObjServices.Entidades;
using System.Globalization;
using LocadoraExObjServices.Services;
namespace ProjectLocadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com os Dados do Aluguel: ");
            Console.WriteLine("Modelo do Carro:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Pegar (dd/MM/yyyy hh:ss): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Retorno (dd/MM/yyyy hh:ss): ");
            DateTime retorno = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com o preço da hora: ");
            double hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do dia: ");
            double dia = double.Parse(Console.ReadLine());



            AluguelCarro aluguel = new AluguelCarro(inicio, retorno, new Veiculo(modelo));

            ServicoAluguel servicoAluguel = new ServicoAluguel(hora, dia, new BrasilTaxasServicos());

            servicoAluguel.ProcessarFatura(aluguel);

            Console.WriteLine("Fatura: ");
            Console.WriteLine(aluguel.Fatura);
        }
    }
}