using NotelyRESTApi.Database;
using NotelyRESTApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyRESTApi.Repositories.Implementation
{
    public class NoteRepositoy : INoteRepoistory
    {

        private NotelyDbContext _context;

        public NoteRepositoy(NotelyDbContext context)
        {
            _context = context;
        }

        public Note FindById(long id)
        {
            var note = _context.Notes.Find(id);
            return note;
        }
        public IEnumerable<Note> GetAllNotes()
        {
            var note = _context.Notes;
            return note;
        }
        public void SaveNote(Note n)
        {
            _context.Notes.Add(n);
            _context.SaveChanges();
        }
        public void EditNote(Note n)
        {
            _context.Notes.Update(n);
            _context.SaveChanges();
        }

        public void Delete(Note note)
        {
            _context.Notes.Remove(note);
            _context.SaveChanges();
        }
    }
}
