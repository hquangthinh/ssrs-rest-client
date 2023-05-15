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
    /// An enumeration of values that specifies the available types of visualizations for a KPI.
    /// </summary>
    /// <value>An enumeration of values that specifies the available types of visualizations for a KPI.</value>
    public enum KpiVisualization
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        None = 1,

        /// <summary>
        /// Enum Bar for value: Bar
        /// </summary>
        Bar = 2,

        /// <summary>
        /// Enum Line for value: Line
        /// </summary>
        Line = 3,

        /// <summary>
        /// Enum Step for value: Step
        /// </summary>
        Step = 4,

        /// <summary>
        /// Enum Area for value: Area
        /// </summary>
        Area = 5

    }

    public class KpiVisualizationConverter : JsonConverter<KpiVisualization>
    {
        public static KpiVisualization FromString(string value)
        {
            if (value == "None")
                return KpiVisualization.None;

            if (value == "Bar")
                return KpiVisualization.Bar;

            if (value == "Line")
                return KpiVisualization.Line;

            if (value == "Step")
                return KpiVisualization.Step;

            if (value == "Area")
                return KpiVisualization.Area;

            throw new NotImplementedException($"Could not convert value to type KpiVisualization: '{value}'");
        }

        public static KpiVisualization? FromStringOrDefault(string value)
        {
            if (value == "None")
                return KpiVisualization.None;

            if (value == "Bar")
                return KpiVisualization.Bar;

            if (value == "Line")
                return KpiVisualization.Line;

            if (value == "Step")
                return KpiVisualization.Step;

            if (value == "Area")
                return KpiVisualization.Area;

            return null;
        }

        public static string ToJsonValue(KpiVisualization value)
        {
            if (value == KpiVisualization.None)
                return "None";

            if (value == KpiVisualization.Bar)
                return "Bar";

            if (value == KpiVisualization.Line)
                return "Line";

            if (value == KpiVisualization.Step)
                return "Step";

            if (value == KpiVisualization.Area)
                return "Area";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override KpiVisualization Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            KpiVisualization? result = KpiVisualizationConverter.FromString(rawValue);
            
            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the KpiVisualization to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kpiVisualization"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, KpiVisualization kpiVisualization, JsonSerializerOptions options)
        {
            writer.WriteStringValue(kpiVisualization.ToString());
        }
    }

    public class KpiVisualizationNullableConverter : JsonConverter<KpiVisualization?>
    {
        /// <summary>
        /// Returns a KpiVisualization from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override KpiVisualization? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            if (rawValue == null)
                return null;

            KpiVisualization? result = KpiVisualizationConverter.FromString(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kpiVisualization"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, KpiVisualization? kpiVisualization, JsonSerializerOptions options)
        {
            writer.WriteStringValue(kpiVisualization?.ToString() ?? "null");
        }
    }

}