using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteApp.Models
{
    public class Note
    {
        public Note(string tile, string noteDetail)
        {
            this.Title = tile;
            this.NoteDetail = noteDetail;
        }

        public string Title { get; set; }

        public string NoteDetail { get; set; }
    }
}
