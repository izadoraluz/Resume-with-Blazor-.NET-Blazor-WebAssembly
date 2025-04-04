public class UserService : IUserService
{
    private readonly List<InformaçõesUser> _mockDb;

    public UserService
()
    {
        _mockDb = new List<InformaçõesUser>
        {
            new InformaçõesUser { Id = 1, Nome = "Izadora", Descrição = "Estou inserida no mundo da tecnologia a mais de 5 anos, sou movida pela convicção de que a inovação tecnológica tem o poder de transformar o mundo e criar um futuro melhor. Acredito que cada um de nós pode ser parte ativa dessa mudança, contribuindo com soluções criativas e impactantes. Ao longo da minha trajetória, tive a oportunidade de trabalhar em projetos focados em inovação, o que me permitiu desenvolver habilidades como colaboração, comunicação eficaz, pensamento crítico e inteligência emocional.", habilidades = "Java, Python, C#, JavaScript, HTML, CSS", experiências = "Desenvolvedora de Software na empresa XYZ (2020 - presente), Estagiária em Desenvolvimento Web na empresa ABC (2018 - 2020)", experiencia = "Desenvolvedora de Software na empresa XYZ (2020 - presente), Estagiária em Desenvolvimento Web na empresa ABC (2018 - 2020)" };
    }

    public List<InformaçõesUser> GetAll() => _mockDb;
    public InformaçõesUser GetById(int id) => _mockDb.FirstOrDefault(x => x.Id == id);
    public void Add(InformaçõesUser item)
    {
        item.Id = _mockDb.Max(x => x.Id) + 1;
        _mockDb.Add(item);
    }
    }}