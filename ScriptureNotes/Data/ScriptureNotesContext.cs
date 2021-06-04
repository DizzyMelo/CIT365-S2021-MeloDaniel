using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScriptureNotes.Models;

    public class ScriptureNotesContext : DbContext
    {
        public ScriptureNotesContext (DbContextOptions<ScriptureNotesContext> options)
            : base(options)
        {
        }

        public DbSet<ScriptureNotes.Models.Scripture> Scripture { get; set; }
    }
