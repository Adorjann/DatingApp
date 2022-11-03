using API.Entities;
using System.Text.Json.Serialization;

namespace API.DTOs
{
    public class MessageDto
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderUserName { get; set; }

        public string SenderPhotoUrl { get; set; }

        public int RecipientId { get; set; }

        public string RecipientUsername { get; set; }

        public string RecipientPhotoUrl { get; set; }

        public string Conttent { get; set; }
        public DateTime? DateRead { get; set; }

        public DateTime MessageSent { get; set; }

        [JsonIgnore]
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }
    }
}
