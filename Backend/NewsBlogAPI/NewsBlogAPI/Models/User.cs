using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NewsBlogAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(255)")]
        public string Email { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(255)"),JsonIgnore]
        public string Password { get; set; } = string.Empty;

        [JsonIgnore]
        public List<NewsPost> newsPosts { get; set; }
    }
}
