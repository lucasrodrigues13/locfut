using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocFut.Models
{
    public class QuadraModel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string TipoPiso { get; set; }
        public string Dimensoes { get; set; }
        public string Descricao { get; set; }
        public DateTime HoraAbertura { get; set; }
        public DateTime HoraFechamento { get; set; }
        public decimal ValorHora { get; set; }
        public EStatus StatusAtual { get; set; }
    }
    public enum EStatus
    {
        Disponivel,
        Reservada,
        EmUso
    }
}
