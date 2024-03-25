using Model.Context;
using Model.Dto;
using Model.Entity;
using Services.CrossCutting;
using Services.Interfaces;

namespace Services.ApplicationServices
{
    public class LivroService:ILivroService
    {
        private readonly DataBaseContext _context;

        public LivroService(DataBaseContext context)
        {
            _context = context;
        }

        public LivroDTO GetLivro(int id)
        {
            var livro = _context.Livro.Find(id);
            if (livro == null)
                throw new Exception("O livro não foi encontrado!");
            var dto = DtoConverter.Converter<Livro, LivroDTO>(livro);
            return dto;

            // Implementação para obter cliente do contexto e mapear para DTO
        }
        // outras implementações dos métodos da interface
    }
}
