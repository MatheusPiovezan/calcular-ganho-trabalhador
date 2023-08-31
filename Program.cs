using Calcular.Entities;
using Calcular.Entities.Enums;
using System.Globalization;

namespace Calcular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();
            Console.WriteLine("Dados do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel (Junior/Pleno/Senior): ");
            NivelDeTrabalhador nivel = Enum.Parse<NivelDeTrabalhador>(Console.ReadLine());
            Console.Write("Salario base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(nomeDepartamento);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, dept);

            Console.Write("Quantidade de contratos a cadastrar: ");
            int qContratos = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qContratos; i++)
            {
                Console.WriteLine($"Entre com os dados do contrato #{i}: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int duracao = int.Parse(Console.ReadLine());

                ContratoDeHoras contrato = new ContratoDeHoras(data, valorPorHora, duracao);
                trabalhador.AddContrato(contrato);
            }

            Console.WriteLine();
            Console.Write("Entre com o  mes e ano para calcular o ganho (MM/YYYY): ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));

            Console.WriteLine($"Nome: {trabalhador.Nome}");
            Console.WriteLine($"Departamento: {trabalhador.Departamento.Nome}");
            Console.WriteLine($"Ganho de {mesEano}: {trabalhador.Ganho(ano, mes)}");
        }
    }
}