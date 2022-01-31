using MVCProject.Models;
using System.Collections.Generic;

namespace MVCProject.Service
{
    public interface IStdWithCrService
    {
        DBFile Context { get; }

        StdWithCr Get(int id);
        List<StdWithCr> GetAll();
    }
}