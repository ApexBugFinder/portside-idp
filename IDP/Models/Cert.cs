using System.ComponentModel.DataAnnotations.Schema;

namespace IDP.Models {
  [NotMapped]
  public class Cert {
    public string Location {get; set;}
    public string Password { get; set;}
    public string Path { get; set; }
    public string Filename {get; set; }

    public string AllowInvalid {  get; set; }
  }
}