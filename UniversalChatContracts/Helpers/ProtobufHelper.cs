using ProtoBuf;

namespace UniversalChatContracts.Helpers;

public static class ProtobufHelper
{
    public static byte[] Serialize<T>(T obj)
    {
        using var stream = new MemoryStream();
        Serializer.Serialize(stream, obj);
        return stream.ToArray();
    }

    public static T Deserialize<T>(byte[] bytes)
    {
        using var stream = new MemoryStream(bytes);
        return Serializer.Deserialize<T>(stream);
    }
}