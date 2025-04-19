namespace front__wasm.Models
{
  public class ItemServiceDetails
  {
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public List<string> Categories { get; set; } = new List<string>();
    public string FarmingProcessTitle { get; set; } = "";
    public List<string> FarmingProcessDetails { get; set; } = new List<string>();
    public List<Package> Packages { get; set; } = new List<Package>();
    public string FeaturedItemsTitle { get; set; } = "";
  }
}
