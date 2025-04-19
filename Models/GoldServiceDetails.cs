namespace front__wasm.Models
{
  public class GoldServiceDetails
  {
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public List<string> Features { get; set; } = new List<string>();
    public List<string> HowItWorks { get; set; } = new List<string>();
    public List<Package> Packages { get; set; } = new List<Package>();
  }
}
