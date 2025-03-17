using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FastWorkshops.models
{
    public class PresencaModel
{
    [Key] 
    public int Id { get; set; }

    [Required(ErrorMessage = "WorkshopId é obrigatório.")]
    public int WorkshopId { get; set; }

    public List<int> ColaboradorIds { get; set; } = new List<int>();
}
}