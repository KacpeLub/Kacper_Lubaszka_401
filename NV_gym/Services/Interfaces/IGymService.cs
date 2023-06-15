using NV_gym.Models;

namespace NV_gym.Services.Interfaces
{
	public interface IGymService
	{
		int Save(Gym gym);
		List<Gym> GetAll();
        Gym GetById(int id);
		int Delete(int id);
		int Update(int id, Gym gym);

    }
}
