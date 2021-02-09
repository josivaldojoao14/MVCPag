using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPage.Models
{
    public class Cliente
    {
       public string Nome { get; set; }
       public string SobreNome { get; set; }
       public string Telefone { get; set; }
       public int Id { get; set; }

    }
}
