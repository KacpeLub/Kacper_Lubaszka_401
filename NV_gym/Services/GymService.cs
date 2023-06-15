using NV_gym.Models;
using NV_gym.Services.Interfaces;

namespace NV_gym.Services
{
	public class GymService : IGymService
	{
		private readonly DbGymContext _context;

        public GymService(DbGymContext dbGymContext)
        {
			_context = dbGymContext;
        }

		public List<Gym> GetAll()
		{
			var gym = _context.Gyms.ToList();
			return gym;
		}

		public int Save(Gym gym)
		{
			_context.Add(gym);
			if(_context.SaveChanges() > 0) { System.Console.WriteLine("SUKCES"); };
			return 1;
		}

        public Gym GetById(int id)
        {
            var gym = _context.Gyms.Find(id);
            return gym;
        }

        public int Delete(int id)
        {
			var gym = _context.Gyms.Find(id);
			_context.Gyms.Remove(gym);
			_context.SaveChanges();
			return id;
        }
        public int Update(int id, Gym gym)
        {
            var updatedGym = _context.Gyms.Find(id);
            if (updatedGym != null)
            {
                updatedGym.Name = gym.Name;
                updatedGym.City = gym.City;
                updatedGym.Street = gym.Street;
                updatedGym.Size = gym.Size;
                updatedGym.Description = gym.Description;

                _context.SaveChanges();
            }
            return gym.Id;
        }
    }
}
