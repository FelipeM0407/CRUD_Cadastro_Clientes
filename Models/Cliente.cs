using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Cadastro_Clientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Razao_Social { get; set; }
        public string Fantasia { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}