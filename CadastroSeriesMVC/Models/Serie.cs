using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroSeriesMVC.Models
{
    public class Serie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Selecione o gênero")]
        [DisplayName("Gênero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Preencha o Título")]
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Preencha a descrição")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preencha ano")]
        [Range(1900, maximum: 2022, ErrorMessage = "Intervalo 1900 a 2022")]
        public int Ano { get; set; }

        //[Required(ErrorMessage = "Selecione o status")]
        [DisplayName("Status")]
        public string Status { get; set; }
    }
}
