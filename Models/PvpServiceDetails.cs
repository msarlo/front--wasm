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
    public string GradientClasses { get; set; } = "";
    public string IconColor { get; set; } = "";
    public string HoverBorderColor { get; set; } = "";
    public string PackagesTitle { get; set; } = "";
  }
}
