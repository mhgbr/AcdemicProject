using MVCProject.Models;

namespace MVCProject.Service
{
    public interface IStdWithCrService
    {
        DBFile Context { get; }

        StdWithCr Get(int id);
    }
}