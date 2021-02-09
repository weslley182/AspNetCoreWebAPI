using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Curso: Entidade
    {
        
    
        public Curso() { }
        public Curso(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }        
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }    
    }
}