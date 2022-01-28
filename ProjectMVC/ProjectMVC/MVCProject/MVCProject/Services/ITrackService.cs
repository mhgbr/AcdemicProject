using MVCProject.Models;
using System.Collections.Generic;

namespace MVCProject.Service
{
    public interface ITrackService
    {
        int Create(Track newTrack);
        int Delete(int id);
        List<Track> GetAll();
        Track GetById(int id);
        Track GetByName(string name);
        int Update(Track newTrack);
    }
}