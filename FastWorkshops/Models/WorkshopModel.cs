using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FastWorkshops.models
{
    public class WorkshopModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do Workshop é Obrigatório")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Data de Realização é Obrigatório")]
        public DateTime DataRealizacao { get; set; }

        [Required(ErrorMessage = "Descrição é Obrigatório")]
        public string Descricao { get; set; }
    }
}