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
    /// An enumeration of values that specifies the known types for MobileReport Resources.
    /// </summary>
    /// <value>An enumeration of values that specifies the known types for MobileReport Resources.</value>
    public enum MobileReportResourceGroupType
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        Unknown = 1,

        /// <summary>
        /// Enum Style for value: Style
        /// </summary>
        Style = 2,

        /// <summary>
        /// Enum Map for value: Map
        /// </summary>
        Map = 3

    }

    public class MobileReportResourceGroupTypeConverter : JsonConverter<MobileReportResourceGroupType>
    {
        public static MobileReportResourceGroupType FromString(string value)
        {
            if (value == "Unknown")
                return MobileReportResourceGroupType.Unknown;

            if (value == "Style")
                return MobileReportResourceGroupType.Style;

            if (value == "Map")
                return MobileReportResourceGroupType.Map;

            throw new NotImplementedException($"Could not convert value to type MobileReportResourceGroupType: '{value}'");
        }

        public static MobileReportResourceGroupType? FromStringOrDefault(string value)
        {
            if (value == "Unknown")
                return MobileReportResourceGroupType.Unknown;

            if (value == "Style")
                return MobileReportResourceGroupType.Style;

            if (value == "Map")
                return MobileReportResourceGroupType.Map;

            return null;
        }

        public static string ToJsonValue(MobileReportResourceGroupType value)
        {
            if (value == MobileReportResourceGroupType.Unknown)
                return "Unknown";

            if (value == MobileReportResourceGroupType.Style)
                return "Style";

            if (value == MobileReportResourceGroupType.Map)
                return "Map";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override MobileReportResourceGroupType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            MobileReportResourceGroupType? result = MobileReportResourceGroupTypeConverter.FromString(rawValue);
            
            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the MobileReportResourceGroupType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mobileReportResourceGroupType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, MobileReportResourceGroupType mobileReportResourceGroupType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(mobileReportResourceGroupType.ToString());
        }
    }

    public class MobileReportResourceGroupTypeNullableConverter : JsonConverter<MobileReportResourceGroupType?>
    {
        /// <summary>
        /// Returns a MobileReportResourceGroupType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override MobileReportResourceGroupType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            if (rawValue == null)
                return null;

            MobileReportResourceGroupType? result = MobileReportResourceGroupTypeConverter.FromString(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mobileReportResourceGroupType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, MobileReportResourceGroupType? mobileReportResourceGroupType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(mobileReportResourceGroupType?.ToString() ?? "null");
        }
    }

}
