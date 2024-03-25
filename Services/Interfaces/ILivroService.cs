using Model.Dto;

namespace Services.Interfaces
{
    public interface ILivroService
    {
        LivroDTO GetLivro(int id);
    }
}
