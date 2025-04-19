namespace front__wasm.Models
{
  public class PvpServiceDetails
  {
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public List<string> Features { get; set; } = new List<string>();
    public string DifferentialsTitle { get; set; } = "";
    public List<string> DifferentialsDetails { get; set; } = new List<string>();
    public List<Package> Packages { get; set; } = new List<Package>();
    public string PackagesTitle { get; set; } = "";
  }
}