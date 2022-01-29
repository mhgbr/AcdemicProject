﻿using Microsoft.EntityFrameworkCore;
using MVCProject.Models;
using System.Linq;

namespace MVCProject.Service
{
    public class StdWithCrService : IStdWithCrService
    {
        public DBFile Context { get; }

        public StdWithCrService(DBFile context)
        {
            Context = context;
        }
        public StdWithCr Get(int id)
        {
            return Context.StdWithCrs.Include(c => c.Course).Include(ww => ww.Student).FirstOrDefault(ww => ww.Id == id);
        }
    }
}
