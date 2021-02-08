using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController: ControllerBase
    {
        public IList<Aluno> Alunos = new List<Aluno>()
        {   
            new Aluno(1, "Rafael", "Chaves", "36222213"),
            new Aluno(2, "Maria", "José", "3622552213"),
            new Aluno(3, "Sirilo", "Silva", "36222245454513"),
            new Aluno(4, "Maria", "Joaquina", "454545")
        };
        public AlunoController()
        {
            
        }   

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if(aluno == null)
            {
                return BadRequest("O Aluno não foi encontrado.");
            }
            return Ok(aluno);
        }

        [HttpGet("{nome}")]
        public IActionResult GetByNome(string nome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
            if(aluno == null)
            {
                return BadRequest("O Aluno não foi encontrado.");
            }
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {            
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {            
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {            
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, Aluno aluno)
        {            
            return Ok(aluno);
        }
    }
}