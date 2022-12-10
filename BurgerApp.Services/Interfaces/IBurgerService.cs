using BurgerApp.InterfaceModels;
namespace BurgerApp.Services.Interfaces
{
    public interface IBurgerService
    {
        public void Add(BurgerViewModel model);
        public IEnumerable<BurgerViewModel> GetAll();
        public void Update(BurgerViewModel model);
        public BurgerViewModel GetById(int id);
        public void DeleteById(int id);
    }
}
