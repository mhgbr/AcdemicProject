using MVCProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCProject.Service
{
    public class TrackService : ITrackService
    {
        public DBFile Context { get; }
        public TrackService(DBFile context)
        {
            Context = context;
        }
        //crud
        //create
        public int Create(Track newTrack)
        {
            Context.Add(newTrack);
            int row = Context.SaveChanges();
            return row;
        }


        //read
        public Track GetById(int id)
        {
            return Context.Tracks.FirstOrDefault(x => x.Id == id);
        }
        public Track GetByName(string name)
        {
            return Context.Tracks.FirstOrDefault(x => x.Name == name);
        }
        public List<Track> GetAll()
        {
            return Context.Tracks.ToList();
        }
        //update
        public int Update(Track newTrack)
        {
            Context.Update(newTrack);
            int row = Context.SaveChanges();
            return row;
        }
        //delete
        public int Delete(int id)
        {
            Context.Remove(Context.Tracks.FirstOrDefault(x => x.Id == id));
            int row = Context.SaveChanges();
            return row;
        }
    }
}
