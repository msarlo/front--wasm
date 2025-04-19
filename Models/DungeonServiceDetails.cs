using System.Collections.Generic;

namespace front__wasm.Models
{
  public class DungeonServiceDetails
  {
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public List<string> Features { get; set; } = new List<string>();
    public List<string> HowItWorks { get; set; } = new List<string>();
    public List<Package> Packages { get; set; } = new List<Package>();
    public string GradientClasses { get; set; } = "";
    public string IconColor { get; set; } = "";
    public string HoverBorderColor { get; set; } = "";
  }

  public class Package
  {
    public string Name { get; set; } = "";
    public string Price { get; set; } = "";
    public bool IsPopular { get; set; } = false;
  }
}
