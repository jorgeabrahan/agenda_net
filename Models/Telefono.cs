using System.ComponentModel.DataAnnotations;
namespace agenda.Models;

public class Telefono
{
  [Key]
  public Guid TelefonoId { get; set; }

  public Guid CodigoAreaId { get; set; }

  public Guid PersonaId { get; set; }

  public string Numero { get; set; } = "";

  public virtual CodigoArea? CodigoArea { get; set; }
  public virtual Persona? Persona { get; set; }
}
