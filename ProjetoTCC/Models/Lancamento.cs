using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTCC.Models
{
    public class Lancamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public bool Tipo { get; set; }
        public double Valor { get; set; }
    }
}