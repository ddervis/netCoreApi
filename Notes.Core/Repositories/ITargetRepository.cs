using Notes.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Core.Repositories
{
    interface ITargetRepository:IRepository<Target>
    {
        Task<Target> GetWithNotesByIdAsync(int targetId);
    }
}
