using Notes.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Core.Repositories
{
    interface INoteRepository:IRepository<Note>
    {
        Task<Note> GetWithTargetByIdAsync(int noteId);
    }
}
