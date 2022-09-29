using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalsAPI.Src.Models
{

    [Table("tb_habitat")]
    public class Habitat
    {
        #region Atributos
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int Id { get; set; }
        public string Ambiente { get; set; }
        #endregion

        [ForeignKey("fk_animal")]
        public Animal HabitatDoAnimal { get; set; }
    }
}
