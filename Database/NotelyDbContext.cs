using Microsoft.EntityFrameworkCore;
using NotelyRESTApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyRESTApi.Database
{
    public class NotelyDbContext : DbContext
    {
        public NotelyDbContext(DbContextOptions<NotelyDbContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}
