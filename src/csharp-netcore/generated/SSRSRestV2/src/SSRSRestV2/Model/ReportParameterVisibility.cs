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
    /// An enumeration of values that specify the visibility of a report parameter, as to whether it is visible at runtime, hidden at runtime, or internal, meaning only visible in the definition.
    /// </summary>
    /// <value>An enumeration of values that specify the visibility of a report parameter, as to whether it is visible at runtime, hidden at runtime, or internal, meaning only visible in the definition.</value>
    public enum ReportParameterVisibility
    {
        /// <summary>
        /// Enum Visible for value: Visible
        /// </summary>
        Visible = 1,

        /// <summary>
        /// Enum Hidden for value: Hidden
        /// </summary>
        Hidden = 2,

        /// <summary>
        /// Enum Internal for value: Internal
        /// </summary>
        Internal = 3

    }

    public class ReportParameterVisibilityConverter : JsonConverter<ReportParameterVisibility>
    {
        public static ReportParameterVisibility FromString(string value)
        {
            if (value == "Visible")
                return ReportParameterVisibility.Visible;

            if (value == "Hidden")
                return ReportParameterVisibility.Hidden;

            if (value == "Internal")
                return ReportParameterVisibility.Internal;

            throw new NotImplementedException($"Could not convert value to type ReportParameterVisibility: '{value}'");
        }

        public static ReportParameterVisibility? FromStringOrDefault(string value)
        {
            if (value == "Visible")
                return ReportParameterVisibility.Visible;

            if (value == "Hidden")
                return ReportParameterVisibility.Hidden;

            if (value == "Internal")
                return ReportParameterVisibility.Internal;

            return null;
        }

        public static string ToJsonValue(ReportParameterVisibility value)
        {
            if (value == ReportParameterVisibility.Visible)
                return "Visible";

            if (value == ReportParameterVisibility.Hidden)
                return "Hidden";

            if (value == ReportParameterVisibility.Internal)
                return "Internal";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ReportParameterVisibility Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            ReportParameterVisibility? result = ReportParameterVisibilityConverter.FromString(rawValue);
            
            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the ReportParameterVisibility to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="reportParameterVisibility"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ReportParameterVisibility reportParameterVisibility, JsonSerializerOptions options)
        {
            writer.WriteStringValue(reportParameterVisibility.ToString());
        }
    }

    public class ReportParameterVisibilityNullableConverter : JsonConverter<ReportParameterVisibility?>
    {
        /// <summary>
        /// Returns a ReportParameterVisibility from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ReportParameterVisibility? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            if (rawValue == null)
                return null;

            ReportParameterVisibility? result = ReportParameterVisibilityConverter.FromString(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="reportParameterVisibility"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ReportParameterVisibility? reportParameterVisibility, JsonSerializerOptions options)
        {
            writer.WriteStringValue(reportParameterVisibility?.ToString() ?? "null");
        }
    }

}