using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Application.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [MinLength(5)]
        [MaxLength(200)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o preço")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [MaxLength(250)]
        public string ImagemUrl { get; set; }

        [Required(ErrorMessage = "O estoque é obrigatório")]
        [Range(1, 9999)]
        public int Estoque { get; set; }

        [Required(ErrorMessage = "Informe a data do cadastro")]
        public DateTime DataCadastro { get; set; }
        public int CategoriaId { get; set; }
    }
}
