

using System.Text.Json.Serialization;

namespace Instagram.DTOs;

public record LikesDTO
{
    [JsonPropertyName("like_id")]
    public long LikeId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("post_id")]
    public long PostId { get; set; }

    [JsonPropertyName("user_id")]
    public long UserId { get; set; }
    


}

public record LikesCreateDTO
{
    [JsonPropertyName("like_id")]
    public long LikeId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("post_id")]
    public int PostId { get; set; }

    [JsonPropertyName("user_id")]
    public long UserId { get; set; }
}
