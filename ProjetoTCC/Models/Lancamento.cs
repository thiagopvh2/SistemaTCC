using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTCC.Models
{
    public class Lancamento
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [DisplayName("Data de registro")]
        [Required(ErrorMessage = "A data não pode ficar em branco!")]
        public DateTime Data { get; set; }
        [DisplayName("Tipo (Entrada ou Saída?)")]
        public bool Tipo { get; set; }
        [DisplayName("Valor")]
        [Required(ErrorMessage = "O valor' não pode ficar em branco!")]
        public double Valor { get; set; }
    }
}