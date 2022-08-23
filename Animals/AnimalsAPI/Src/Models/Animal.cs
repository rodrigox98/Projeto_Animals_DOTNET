using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AnimalsAPI.Src.Models
{
    [Table("tb_animal")]
    public class Animal
    {
        #region Atributos
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Especie { get; set; }

        public int ExpectativaDeVida { get; set; }
        #endregion

        //Evita problema de recursividade e aponta a propriedade inversa ->(Habitat)
        [JsonIgnore, InverseProperty("HabitatDoAnimal")]
        public List<Habitat> Habitats { get; set; }
    }
}
