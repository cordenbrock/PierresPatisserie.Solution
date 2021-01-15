using System.Collections.Generic;

namespace PierresPatisserie.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors= new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string TreatName { get; set }
    public int TreatPrice { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<Flavor> Flavors { get; set; }
  }
}