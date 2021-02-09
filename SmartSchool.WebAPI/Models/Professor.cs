using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Professor: Entidade
    {
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }
        public Professor()
        {
            
        }
        public Professor(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }        
        
    }
}