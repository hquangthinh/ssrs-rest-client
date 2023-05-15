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
    /// An enumeration of Reporting Services extension types.
    /// </summary>
    /// <value>An enumeration of Reporting Services extension types.</value>
    public enum ExtensionType
    {
        /// <summary>
        /// Enum Delivery for value: Delivery
        /// </summary>
        Delivery = 1,

        /// <summary>
        /// Enum DeliveryUI for value: DeliveryUI
        /// </summary>
        DeliveryUI = 2,

        /// <summary>
        /// Enum Render for value: Render
        /// </summary>
        Render = 3,

        /// <summary>
        /// Enum Data for value: Data
        /// </summary>
        Data = 4,

        /// <summary>
        /// Enum All for value: All
        /// </summary>
        All = 5

    }

    public class ExtensionTypeConverter : JsonConverter<ExtensionType>
    {
        public static ExtensionType FromString(string value)
        {
            if (value == "Delivery")
                return ExtensionType.Delivery;

            if (value == "DeliveryUI")
                return ExtensionType.DeliveryUI;

            if (value == "Render")
                return ExtensionType.Render;

            if (value == "Data")
                return ExtensionType.Data;

            if (value == "All")
                return ExtensionType.All;

            throw new NotImplementedException($"Could not convert value to type ExtensionType: '{value}'");
        }

        public static ExtensionType? FromStringOrDefault(string value)
        {
            if (value == "Delivery")
                return ExtensionType.Delivery;

            if (value == "DeliveryUI")
                return ExtensionType.DeliveryUI;

            if (value == "Render")
                return ExtensionType.Render;

            if (value == "Data")
                return ExtensionType.Data;

            if (value == "All")
                return ExtensionType.All;

            return null;
        }

        public static string ToJsonValue(ExtensionType value)
        {
            if (value == ExtensionType.Delivery)
                return "Delivery";

            if (value == ExtensionType.DeliveryUI)
                return "DeliveryUI";

            if (value == ExtensionType.Render)
                return "Render";

            if (value == ExtensionType.Data)
                return "Data";

            if (value == ExtensionType.All)
                return "All";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ExtensionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            ExtensionType? result = ExtensionTypeConverter.FromString(rawValue);
            
            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the ExtensionType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="extensionType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ExtensionType extensionType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(extensionType.ToString());
        }
    }

    public class ExtensionTypeNullableConverter : JsonConverter<ExtensionType?>
    {
        /// <summary>
        /// Returns a ExtensionType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ExtensionType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            if (rawValue == null)
                return null;

            ExtensionType? result = ExtensionTypeConverter.FromString(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="extensionType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ExtensionType? extensionType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(extensionType?.ToString() ?? "null");
        }
    }

}
