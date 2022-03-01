using System;
using System.Collections.Generic;
using System.Text;
using Cap9ExResolvido.Entidades.Enums;

namespace Cap9ExResolvido.Entidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public Level Level { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento{ get; set; } //desa forma, a classe departamento está associada a classe departamento
        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>(); // instanciando agora para que não haja riscos de não instanciar
        // uma lista de contratos do tipo HoraContrato, pois um funcionário pode ter vários contratos
        public Trabalhador(string nome, Level level, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Level = level;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }// não é usual passar uma lista instanciada no constutor do objeto. REGRA: Sempre que tiver uma associação para mts, não incluir no construtor

        public void AddContrato(HoraContrato contrato)
        {
            Contratos.Add(contrato);
        }
        //método que faz adicionar um novo contrato na minha lista de contratos
        public void RemoveContrato(HoraContrato contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Ganho (int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (HoraContrato contrato in Contratos)
            {
                if(contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }
        /* meu Ganho percorre a lista de contratos comparando o mes e ano informados e somando com o valor total da
         hora x tempo trabalhado naquele contrato, no método ValorTotal da classe HoraContrato*/

    }
}
