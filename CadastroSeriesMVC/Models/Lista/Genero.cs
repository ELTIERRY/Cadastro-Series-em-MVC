using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroSeriesMVC.Models.Lista
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string GeneroNome { get; set; }

        public List<Genero> ListaGeneros()
        {
            return new List<Genero>
            {
                new Genero { GeneroId = 1, GeneroNome = "Acao"},
                new Genero { GeneroId = 2, GeneroNome = "Aventura"},
                new Genero { GeneroId = 3, GeneroNome = "Comedia" },
                new Genero { GeneroId = 4, GeneroNome = "Documentario" },
                new Genero { GeneroId = 5, GeneroNome = "Drama" },
                new Genero { GeneroId = 6, GeneroNome = "Espionagem" },
                new Genero { GeneroId = 7, GeneroNome = "Faroeste" },
                new Genero { GeneroId = 8, GeneroNome = "Fantasia" },
                new Genero { GeneroId = 9, GeneroNome = "Ficcao_Cientifica" },
                new Genero { GeneroId = 10, GeneroNome = "Musical" },
                new Genero { GeneroId = 11, GeneroNome = "Romance" },
                new Genero { GeneroId = 12, GeneroNome = "Suspense" },
                new Genero { GeneroId = 13, GeneroNome = "Terror" },
                new Genero { GeneroId = 14, GeneroNome = "Animação" }
            };
        }
    }
}
