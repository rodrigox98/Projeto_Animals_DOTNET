using AnimalsAPI.Src.Context;
using AnimalsAPI.Src.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AnimalsAPI.Src.Repositories.Implementations

{
    /// <summary>
    /// <para>  Classe responsável por implementa IAnimal</para>
    /// </summary>
    public class AnimalRepository : IAnimal
    {
        #region Atributos
        private readonly AnimalsContext _context;
        #endregion

        #region Construtores
        public AnimalRepository(AnimalsContext context)
        {
            _context = context;
        }
        #endregion
        #region Métodos
        /// <summary>
        /// <para> Método assíncrono para salvar um novo animal</para>
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public async Task NovoAnimalAsync(Animal animal)
        {
            await _context.Animais.AddAsync(
                new Animal
                {
                    Nome = animal.Nome,
                    Especie = animal.Especie,
                    ExpectativaDeVida = animal.ExpectativaDeVida
                });
        }

        /// <summary>
        /// <para> Método assíncrono para pegar Animal pelo nome</para>
        /// </summary>
        /// <param name="nome">Nome do Animal</param>
        /// <returns></returns>
        public async Task<Animal> PegarAnimalPeloNome(string nome)
        {
            return await _context.Animais.FirstOrDefaultAsync(n => n.Nome == nome);
        }
        #endregion
    }
}
