public interface IUserService
{
    List<DashboardItem> GetAll();
    DashboardItem GetById(int id);
    void Add(DashboardItem item);
}