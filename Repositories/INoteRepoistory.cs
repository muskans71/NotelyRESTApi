using NotelyRESTApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyRESTApi.Repositories
{
    public interface INoteRepoistory
    {
        Note FindById(long id);
        public IEnumerable<Note> GetAllNotes();
        public void SaveNote(Note n);
        public void EditNote(Note n);
        public void Delete(Note note);

    }
}
