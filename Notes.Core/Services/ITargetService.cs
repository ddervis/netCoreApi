﻿using Notes.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Core.Services
{
    interface ITargetService:IService<Target>
    {
        Task<Target> GetWithNotesByIdAsync(int targetId);
    }
}
