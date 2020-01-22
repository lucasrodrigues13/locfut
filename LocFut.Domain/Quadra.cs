using System;
using System.Collections.Generic;
using System.Text;

namespace LocFut.Domain
{
    public class Quadra : Base.Entidade
    {
        public Quadra(string nome, string endereco, string telefone, string tipoPiso, DateTime horaAbertura, DateTime horaFechamento, decimal valorHora)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            TipoPiso = tipoPiso;
            HoraAbertura = horaAbertura;
            HoraFechamento = horaFechamento;
            ValorHora = valorHora;
        }

        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string TipoPiso { get; private set; }
        public string Dimensoes { get; private set; }
        public string Descricao { get; private set; }
        public DateTime HoraAbertura { get; private set; }
        public DateTime HoraFechamento { get; private set; }
        public decimal ValorHora { get; private set; }
        public EStatus StatusAtual { get; private set; }

        public void AlterarStatus(EStatus status)
        {
            StatusAtual = status;
        }
    }

    public enum EStatus
    {
        Disponivel,
        Reservada,
        EmUso
    }
}
