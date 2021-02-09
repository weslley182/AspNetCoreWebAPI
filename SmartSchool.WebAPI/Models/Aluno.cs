using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Aluno: Entidade
    {        
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }

        public Aluno()
        {

        }
        public Aluno(int id, string nome, string sobrenome, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
        }

    }
}