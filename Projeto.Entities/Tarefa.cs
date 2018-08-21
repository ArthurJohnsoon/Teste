using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    class Tarefa
    {
        public int IdTarefa { get; set; }
        public string Titulo { get; set; }

        public Tarefa()
        {

        }

        public Tarefa(int idTarefa, string titulo)
        {
            IdTarefa = idTarefa;
            Titulo = titulo;
        }

        public override string ToString()
        {
            return $"Id: {IdTarefa},  Título: {Titulo}";
        }
    }
}
