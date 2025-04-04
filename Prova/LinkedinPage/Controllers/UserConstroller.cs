public class UserController
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }

    public List<InformacoesUser> GetAll() => _service.GetAll();

    public int GetCountBySId(int id) => _service.CountById(id);
}