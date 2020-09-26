using Notes.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Core.UnitOfWorks
{
    interface IUnitOfWork
    {
        ITargetRepository Targets { get; }
        INoteRepository Notes { get; }
        Task CommitAsync();
        void Commit();
    }
}
