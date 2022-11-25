using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteLanche.Models {

    [Table("Categorias")]
    public class Categoria {


        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage ="O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome  da categoria")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }


        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        public List<Lanche> Lanche { get; set; }
    }
}
