using System;
using System.Collections.Generic;
using System.Text;

namespace JustNote.Models
{
    public interface INoteModel
    {
        int Id { get; set; } 
        string NoteTitle { get; set; }
        DateTime? CreationDataTime { get; set; }
        DateTime LastEditDataTime { get; set; }
    }
}
