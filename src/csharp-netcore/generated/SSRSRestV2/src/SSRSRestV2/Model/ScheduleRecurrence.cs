// <auto-generated>
/*
 * SQL Server 2017 Reporting Services REST API
 *
 * The SQL Server 2017 Reporting Services REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://docs.microsoft.com/sql/reporting-services/reporting-services-developer-documentation  __Team Blog:__ https://blogs.msdn.microsoft.com/sqlrsteamblog  __Support forums:__ https://social.msdn.microsoft.com/Forums/en-US/home?forum=sqlreportingservices 
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace SSRSRestV2.Model
{
    /// <summary>
    /// An object that defines the recurrence of a schedule. When defining the recurrence, only one of the recurrence types can be set.
    /// </summary>
    public partial class ScheduleRecurrence : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleRecurrence" /> class.
        /// </summary>
        /// <param name="dailyRecurrence">dailyRecurrence</param>
        /// <param name="minuteRecurrence">minuteRecurrence</param>
        /// <param name="monthlyDOWRecurrence">monthlyDOWRecurrence</param>
        /// <param name="monthlyRecurrence">monthlyRecurrence</param>
        /// <param name="weeklyRecurrence">weeklyRecurrence</param>
        [JsonConstructor]
        public ScheduleRecurrence(DailyRecurrence dailyRecurrence, MinuteRecurrence minuteRecurrence, MonthlyDOWRecurrence monthlyDOWRecurrence, MonthlyRecurrence monthlyRecurrence, WeeklyRecurrence weeklyRecurrence)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (minuteRecurrence == null)
                throw new ArgumentNullException("minuteRecurrence is a required property for ScheduleRecurrence and cannot be null.");

            if (dailyRecurrence == null)
                throw new ArgumentNullException("dailyRecurrence is a required property for ScheduleRecurrence and cannot be null.");

            if (weeklyRecurrence == null)
                throw new ArgumentNullException("weeklyRecurrence is a required property for ScheduleRecurrence and cannot be null.");

            if (monthlyRecurrence == null)
                throw new ArgumentNullException("monthlyRecurrence is a required property for ScheduleRecurrence and cannot be null.");

            if (monthlyDOWRecurrence == null)
                throw new ArgumentNullException("monthlyDOWRecurrence is a required property for ScheduleRecurrence and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            DailyRecurrence = dailyRecurrence;
            MinuteRecurrence = minuteRecurrence;
            MonthlyDOWRecurrence = monthlyDOWRecurrence;
            MonthlyRecurrence = monthlyRecurrence;
            WeeklyRecurrence = weeklyRecurrence;
        }

        /// <summary>
        /// Gets or Sets DailyRecurrence
        /// </summary>
        [JsonPropertyName("DailyRecurrence")]
        public DailyRecurrence DailyRecurrence { get; set; }

        /// <summary>
        /// Gets or Sets MinuteRecurrence
        /// </summary>
        [JsonPropertyName("MinuteRecurrence")]
        public MinuteRecurrence MinuteRecurrence { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyDOWRecurrence
        /// </summary>
        [JsonPropertyName("MonthlyDOWRecurrence")]
        public MonthlyDOWRecurrence MonthlyDOWRecurrence { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyRecurrence
        /// </summary>
        [JsonPropertyName("MonthlyRecurrence")]
        public MonthlyRecurrence MonthlyRecurrence { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyRecurrence
        /// </summary>
        [JsonPropertyName("WeeklyRecurrence")]
        public WeeklyRecurrence WeeklyRecurrence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduleRecurrence {\n");
            sb.Append("  DailyRecurrence: ").Append(DailyRecurrence).Append("\n");
            sb.Append("  MinuteRecurrence: ").Append(MinuteRecurrence).Append("\n");
            sb.Append("  MonthlyDOWRecurrence: ").Append(MonthlyDOWRecurrence).Append("\n");
            sb.Append("  MonthlyRecurrence: ").Append(MonthlyRecurrence).Append("\n");
            sb.Append("  WeeklyRecurrence: ").Append(WeeklyRecurrence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type ScheduleRecurrence
    /// </summary>
    public class ScheduleRecurrenceJsonConverter : JsonConverter<ScheduleRecurrence>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ScheduleRecurrence Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            DailyRecurrence dailyRecurrence = default;
            MinuteRecurrence minuteRecurrence = default;
            MonthlyDOWRecurrence monthlyDOWRecurrence = default;
            MonthlyRecurrence monthlyRecurrence = default;
            WeeklyRecurrence weeklyRecurrence = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "DailyRecurrence":
                            dailyRecurrence = JsonSerializer.Deserialize<DailyRecurrence>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "MinuteRecurrence":
                            minuteRecurrence = JsonSerializer.Deserialize<MinuteRecurrence>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "MonthlyDOWRecurrence":
                            monthlyDOWRecurrence = JsonSerializer.Deserialize<MonthlyDOWRecurrence>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "MonthlyRecurrence":
                            monthlyRecurrence = JsonSerializer.Deserialize<MonthlyRecurrence>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "WeeklyRecurrence":
                            weeklyRecurrence = JsonSerializer.Deserialize<WeeklyRecurrence>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ScheduleRecurrence(dailyRecurrence, minuteRecurrence, monthlyDOWRecurrence, monthlyRecurrence, weeklyRecurrence);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="scheduleRecurrence"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ScheduleRecurrence scheduleRecurrence, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("DailyRecurrence");
            JsonSerializer.Serialize(writer, scheduleRecurrence.DailyRecurrence, jsonSerializerOptions);
            writer.WritePropertyName("MinuteRecurrence");
            JsonSerializer.Serialize(writer, scheduleRecurrence.MinuteRecurrence, jsonSerializerOptions);
            writer.WritePropertyName("MonthlyDOWRecurrence");
            JsonSerializer.Serialize(writer, scheduleRecurrence.MonthlyDOWRecurrence, jsonSerializerOptions);
            writer.WritePropertyName("MonthlyRecurrence");
            JsonSerializer.Serialize(writer, scheduleRecurrence.MonthlyRecurrence, jsonSerializerOptions);
            writer.WritePropertyName("WeeklyRecurrence");
            JsonSerializer.Serialize(writer, scheduleRecurrence.WeeklyRecurrence, jsonSerializerOptions);

            writer.WriteEndObject();
        }
    }
}