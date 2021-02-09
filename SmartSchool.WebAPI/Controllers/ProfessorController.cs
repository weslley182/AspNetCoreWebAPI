using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController: ControllerBase
    {       
        private readonly SmartContext _context;
        public ProfessorController(SmartContext context)
        {
            _context = context;
        }   

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professores);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _context.Professores.FirstOrDefault(a => a.Id == id);
            if(professor == null)
            {
                return BadRequest("O Professor não foi encontrado.");
            }
            return Ok(professor);
        }

        [HttpGet("ByName")]
        public IActionResult GetByNome(string nome)
        {
            var professor = _context.Professores.FirstOrDefault(a => a.Nome.Contains(nome));
            if(professor == null)
            {
                return BadRequest("O Professor não foi encontrado.");
            }
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult Post(Professor prof)
        {            
            _context.Add(prof);
            _context.SaveChanges();
            return Ok(prof);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor prof)
        {            
            var professor = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if(professor == null)
            {
                return BadRequest("Professor não encontrado.");
            }
            _context.Update(prof);
            _context.SaveChanges();
            return Ok(prof);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor prof)
        {            
            var professor = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if(professor == null)
            {
                return BadRequest("Professor não encontrado.");
            }

            _context.Update(prof);
            _context.SaveChanges();
            return Ok(prof);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {            
            var prof = _context.Professores.FirstOrDefault(a => a.Id == id);
            if(prof == null)
            {
                return BadRequest("Professor não encontrado.");
            }

            _context.Remove(prof);
            _context.SaveChanges();
            return Ok($"' {prof.Nome} ' apagado com sucesso.");
        }

    }
}