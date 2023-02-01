using System.ComponentModel.DataAnnotations;

namespace MyFirstASPProject.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Boi { get; set; }
    }
}
