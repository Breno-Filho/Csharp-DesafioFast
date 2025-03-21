using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FastWorkshops.models
{
    public class ColaboradorModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do Colaborador é Obrigatório")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string Nome { get; set; }
    }
}