

using Instagram.DTOs;
using Instagram.DTOS;

namespace Instagram.Models;

public record Hashtag
{
    public long HashId { get; set; }
    public string HashName { get; set; }



    public HashtagDTO asDto => new HashtagDTO
    {
        HashId = HashId,
        HashName = HashName,


    };
}