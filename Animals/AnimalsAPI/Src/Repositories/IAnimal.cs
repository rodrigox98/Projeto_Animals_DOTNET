
using AnimalsAPI.Src.Models;
using System.Threading.Tasks;

namespace AnimalsAPI.Src.Repositories
{
    /// <summary>
    /// <para>Resumo: Responsável por ações de CRUD de Animal </para>
    /// <para>Criado por : @rodrigox98 </para>
    /// </summary>
    public interface IAnimal
    {
        Task<Animal> PegarAnimalPeloNome(string nome);

        Task NovoAnimalAsync(Animal animal);
    }
}
