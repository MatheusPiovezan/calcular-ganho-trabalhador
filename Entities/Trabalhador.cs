using Calcular.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular.Entities
{
    internal class Trabalhador
    {
        public string Nome { get; set; }
        public NivelDeTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoDeHoras> Contratos { get; set; } = new List<ContratoDeHoras>();

        public Trabalhador() { }

        public Trabalhador(string nome, NivelDeTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato(ContratoDeHoras contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoDeHoras contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Ganho(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (ContratoDeHoras contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma = soma + contrato.ValorTotal();
                }
            }
            return soma;
        }
    }
}
