using System.Collections.Generic;

namespace PierresPatisserie.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string FlavorType { get; set; }
    public string FlavorDescription { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<Treat> Treats { get; set; }
  }
}