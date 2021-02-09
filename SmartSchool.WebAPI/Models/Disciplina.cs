using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Disciplina: Entidade
    {
        
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
        public Disciplina()
        {
            
        }
        public Disciplina(int id, string nome, int professorId)
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
        }
    }
}