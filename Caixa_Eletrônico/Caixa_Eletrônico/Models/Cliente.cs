using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa_Eletrônico.Models
{
    public class Cliente
    {
        public Guid ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public double Saldo { get; set; }
        
        
        public Cliente()
        {
            ID = Guid.NewGuid();
        }
    }
}
