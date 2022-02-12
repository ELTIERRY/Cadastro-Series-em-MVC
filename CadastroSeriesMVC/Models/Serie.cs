using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroSeriesMVC.Models
{
    public class Serie
    {
        public int Id { get; set; }
        public string Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public string Status { get; set; }
    }
}
