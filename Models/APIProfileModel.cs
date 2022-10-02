using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace MahekaruProfileCore.Models
{
    public class APIProfileModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Exp { get; set; } = 0;
        public int ExpTotal { get; set; } = 0;
        public int HP { get; set; } = 0;
        public int MP { get; set; } = 0;
        public string LinkedIn { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string GitHub { get; set; } = string.Empty;
        public string ProfileImage { get; set; } = string.Empty;

    }
}
