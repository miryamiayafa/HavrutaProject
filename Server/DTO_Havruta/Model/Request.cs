using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DTO_Havruta.Model;

public partial class Request
{
    public int Idrequest { get; set; }

    public int? IdAsking { get; set; }

    public int? IdAcceptingRequest { get; set; }

    public int? IdSubject { get; set; }

    public int? IdStudyType { get; set; }

    public string? DescriptionRequest { get; set; }

    [JsonConverter(typeof(TimeOnlyJsonConverter))]
    public TimeOnly StartTime { get; set; }

    [JsonConverter(typeof(TimeOnlyJsonConverter))]
    public TimeOnly? EndTime { get; set; }

    public bool? AllDay { get; set; }

    public bool? Ok { get; set; }

    public virtual User? IdAskingNavigation { get; set; }

    public virtual StudyType? IdStudyTypeNavigation { get; set; }

    public virtual Subject? IdSubjectNavigation { get; set; }

    
}

public class TimeOnlyJsonConverter : JsonConverter<TimeOnly>
{
    public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return TimeOnly.Parse(value);
    }
    public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString("HH:mm:ss"));
    }
}