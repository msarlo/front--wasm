using System.Collections.Generic;

namespace front__wasm.Models
{
  public class RaidServiceDetails
  {
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string GradientClasses { get; set; } = "";
    public string IconColor { get; set; } = "";
    public string HoverBorderColor { get; set; } = "";
    public string FeaturesTitle { get; set; } = "";
    public List<string> Features { get; set; } = new List<string>();
    public string AvailableRaidsTitle { get; set; } = "";
    public List<string> AvailableRaids { get; set; } = new List<string>();
    public string PackagesTitle { get; set; } = "";
    public List<Package> Packages { get; set; } = new List<Package>();
  }
}

// Note: Ensure the Package class exists or is defined, similar to how it's used in PvpServiceDetails.
// If it doesn't exist, create Models/Package.cs:
/*
namespace front__wasm.Models
{
    public class Package
    {
        public string Name { get; set; } = "";
        public string Price { get; set; } = "";
        public bool IsPopular { get; set; }
    }
}
*/
