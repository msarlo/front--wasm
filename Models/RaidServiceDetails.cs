namespace front__wasm.Models
{
  public class RaidServiceDetails
  {
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string FeaturesTitle { get; set; } = "";
    public List<string> Features { get; set; } = new List<string>();
    public string AvailableRaidsTitle { get; set; } = "";
    public List<string> AvailableRaids { get; set; } = new List<string>();
    public string PackagesTitle { get; set; } = "";
    public List<Package> Packages { get; set; } = new List<Package>();
  }
}