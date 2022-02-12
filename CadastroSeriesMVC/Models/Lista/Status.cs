using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroSeriesMVC.Models.Lista
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusNome { get; set; }

        public List<Status> ListaStatus()
        {
            return new List<Status>
            {
                new Status { StatusId = 1, StatusNome = "Ativa"},
                new Status { StatusId = 2, StatusNome = "Inativa"},
            };
        }
    }
}
