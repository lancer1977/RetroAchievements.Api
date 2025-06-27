namespace PolyhydraGames.RetroAchievements;

public class CustomDateFormatConverter : System.Text.Json.Serialization.JsonConverter<DateTime>
{
    private readonly string dateFormat = "yyyy-MM-dd HH:mm:ss";

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? dateString = reader.GetString();
        if(dateString == null) return DateTime.MinValue;
        try
        {
            return DateTime.Parse(dateString);
        }
        catch (Exception ex)
        {
            return DateTime.ParseExact(dateString, dateFormat, null);
        }

    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(dateFormat));
    }
}