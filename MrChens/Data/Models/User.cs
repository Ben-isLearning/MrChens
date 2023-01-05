using System.ComponentModel.DataAnnotations;
namespace MrChens.Data.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string DisplayName { get; set; }

    }
}
