using Newtonsoft.Json;

namespace Novu.DTO.Topics;

/// <summary>
/// todo add docs
/// </summary>
public class TopicSubscriberAdditionRequestDto
{
    [JsonProperty("subscribers")]
    public List<string> Keys { get; set; }
}