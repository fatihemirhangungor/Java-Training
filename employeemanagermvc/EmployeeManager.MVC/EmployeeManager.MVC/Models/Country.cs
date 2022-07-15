using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManager.MVC.Models
{
    [Table("Countries")]
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
    }
}
