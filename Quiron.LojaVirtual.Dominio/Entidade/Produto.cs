﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidade
{
   public class Produto
    {
       public int Produtoid { get; set; }
       public string Nome { get; set; }
       public string Descricao { get; set; }
       public Decimal Preco { get; set; }
       public string Categoria { get; set; }

    }
}
