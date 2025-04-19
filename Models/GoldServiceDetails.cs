namespace front__wasm.Models
{
  public class GoldServiceDetails
  {
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string FeaturesTitle { get; set; } = ""; // Added
    public List<string> Features { get; set; } = new List<string>();
    public string DetailsTitle { get; set; } = ""; // Added
    public List<string> Details { get; set; } = new List<string>(); // Renamed from HowItWorks
    public string PackagesTitle { get; set; } = ""; // Added
    public List<Package> Packages { get; set; } = new List<Package>();
  }
}
