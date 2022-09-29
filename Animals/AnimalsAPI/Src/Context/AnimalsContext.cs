using AnimalsAPI.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalsAPI.Src.Context

{
    /// <summary>
    /// <para>Resumo: classe contexto , responsável por carregar contexto e definir DbSets</para>
    /// <para
    /// Criado por: rodrigox98
    /// Data: 22/08/2022
    /// </summary>
    public class AnimalsContext : DbContext
    {
        #region Atributos

        public DbSet<Animal> Animais { get; set; }

        public DbSet<Habitat> Habitats { get; set; }
        #endregion

        #region Construtores
        public AnimalsContext(DbContextOptions<AnimalsContext> opt) : base(opt)
        {

        }
        #endregion
    }
}
