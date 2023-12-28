using System.ComponentModel.DataAnnotations;
namespace HRPortal.Models;
public class Company { 
   //Data level Validations
   [Required, MaxLength(80)] 
    public string Firstname { get; set; } 
    public string Lastname { get; set; } 
    public string Phone { get; set; } 
    public string Address { get; set; } 
    public string Password { get; set; } 
    
    public Company(string Firstname, string Lastname ,string Phone, string Address,string Password)
    {
        this.Firstname=Firstname;
        this.Lastname=Lastname;
        this.Phone=Phone;
        this.Address=Address;
        this.Password=Password;

    }
}
