using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Models
{
    [Table("CLIENTE")]
    public class ClienteModel
    {
        [Key, Column("ID_CLIENTE")]
        public int IdCliente { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("CPF_CNPJ")]
        public string CpfCnpj { get; set; }

        [Column("DATA_NASCIMENTO")]
        public DateTime? DataNascimento { get; set; }
    }
}
