using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteApp.Models;

namespace NoteApp.Data
{
    public class NoteList
    {

        private readonly List<Note> notes;
        public NoteList() {
            this.notes = new List<Note>();
        }

        public void AddNotes(Note note)
        {
            if (note != null)
            {
                notes.Add(note);
            }
            
        }

        public List<Note> GetAllNotes()
        {
            return notes;
        }
    }
}
