using ProtoBuf;

namespace UniversalChatContracts.Model;

[ProtoContract]
public class TextMessage
{
    [ProtoMember(1)] public Guid MessageId { get; set; }
    [ProtoMember(2)] public Guid ChannelId { get; set; }
    [ProtoMember(3)] public Guid UserId { get; set; }
    [ProtoMember(4)] public string Text { get; set; } = null!;
}