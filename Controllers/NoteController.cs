using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotelyRESTApi.Models;
using NotelyRESTApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyRESTApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteRepoistory _noterepository;

        public NoteController(INoteRepoistory noterepo)
        {
            _noterepository = noterepo;
        }

        [HttpGet("{id}")]
        public ActionResult<Note> GetNote(long id)
        {
            var note = _noterepository.FindById(id);
            return note;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Note>> GetNotes()
        {
            var note = _noterepository.GetAllNotes().ToList();
            return note;
        }
        [HttpPost]
        public ActionResult<Note> PostNote(Note note)
        {
            var currentDate = DateTime.Now;
            note.CreatedData = currentDate;
            note.LastModified = currentDate;
            _noterepository.SaveNote(note);
            return note;
        }
        [HttpPut]
        public ActionResult<Note> PutNote(Note note)
        {
            var currentDate = DateTime.Now;
            note.LastModified = currentDate;
            _noterepository.EditNote(note);
            return note;
        }

        [HttpDelete("{id}")]
        public ActionResult<Note> DeleteNote(long Id)
        {
            var note = _noterepository.FindById(Id);
            _noterepository.Delete(note);
            return note;
        }

    }
}
