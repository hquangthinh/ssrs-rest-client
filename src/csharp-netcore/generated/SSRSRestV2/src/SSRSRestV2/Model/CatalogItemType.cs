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
    /// An enumeration of values that specifies the type of the CatalogItem.
    /// </summary>
    /// <value>An enumeration of values that specifies the type of the CatalogItem.</value>
    public enum CatalogItemType
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        Unknown = 1,

        /// <summary>
        /// Enum Folder for value: Folder
        /// </summary>
        Folder = 2,

        /// <summary>
        /// Enum Report for value: Report
        /// </summary>
        Report = 3,

        /// <summary>
        /// Enum DataSource for value: DataSource
        /// </summary>
        DataSource = 4,

        /// <summary>
        /// Enum DataSet for value: DataSet
        /// </summary>
        DataSet = 5,

        /// <summary>
        /// Enum Component for value: Component
        /// </summary>
        Component = 6,

        /// <summary>
        /// Enum Resource for value: Resource
        /// </summary>
        Resource = 7,

        /// <summary>
        /// Enum Kpi for value: Kpi
        /// </summary>
        Kpi = 8,

        /// <summary>
        /// Enum MobileReport for value: MobileReport
        /// </summary>
        MobileReport = 9,

        /// <summary>
        /// Enum LinkedReport for value: LinkedReport
        /// </summary>
        LinkedReport = 10,

        /// <summary>
        /// Enum ReportModel for value: ReportModel
        /// </summary>
        ReportModel = 11

    }

    public class CatalogItemTypeConverter : JsonConverter<CatalogItemType>
    {
        public static CatalogItemType FromString(string value)
        {
            if (value == "Unknown")
                return CatalogItemType.Unknown;

            if (value == "Folder")
                return CatalogItemType.Folder;

            if (value == "Report")
                return CatalogItemType.Report;

            if (value == "DataSource")
                return CatalogItemType.DataSource;

            if (value == "DataSet")
                return CatalogItemType.DataSet;

            if (value == "Component")
                return CatalogItemType.Component;

            if (value == "Resource")
                return CatalogItemType.Resource;

            if (value == "Kpi")
                return CatalogItemType.Kpi;

            if (value == "MobileReport")
                return CatalogItemType.MobileReport;

            if (value == "LinkedReport")
                return CatalogItemType.LinkedReport;

            if (value == "ReportModel")
                return CatalogItemType.ReportModel;

            throw new NotImplementedException($"Could not convert value to type CatalogItemType: '{value}'");
        }

        public static CatalogItemType? FromStringOrDefault(string value)
        {
            if (value == "Unknown")
                return CatalogItemType.Unknown;

            if (value == "Folder")
                return CatalogItemType.Folder;

            if (value == "Report")
                return CatalogItemType.Report;

            if (value == "DataSource")
                return CatalogItemType.DataSource;

            if (value == "DataSet")
                return CatalogItemType.DataSet;

            if (value == "Component")
                return CatalogItemType.Component;

            if (value == "Resource")
                return CatalogItemType.Resource;

            if (value == "Kpi")
                return CatalogItemType.Kpi;

            if (value == "MobileReport")
                return CatalogItemType.MobileReport;

            if (value == "LinkedReport")
                return CatalogItemType.LinkedReport;

            if (value == "ReportModel")
                return CatalogItemType.ReportModel;

            return null;
        }

        public static string ToJsonValue(CatalogItemType value)
        {
            if (value == CatalogItemType.Unknown)
                return "Unknown";

            if (value == CatalogItemType.Folder)
                return "Folder";

            if (value == CatalogItemType.Report)
                return "Report";

            if (value == CatalogItemType.DataSource)
                return "DataSource";

            if (value == CatalogItemType.DataSet)
                return "DataSet";

            if (value == CatalogItemType.Component)
                return "Component";

            if (value == CatalogItemType.Resource)
                return "Resource";

            if (value == CatalogItemType.Kpi)
                return "Kpi";

            if (value == CatalogItemType.MobileReport)
                return "MobileReport";

            if (value == CatalogItemType.LinkedReport)
                return "LinkedReport";

            if (value == CatalogItemType.ReportModel)
                return "ReportModel";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override CatalogItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            CatalogItemType? result = CatalogItemTypeConverter.FromString(rawValue);
            
            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the CatalogItemType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="catalogItemType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, CatalogItemType catalogItemType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(catalogItemType.ToString());
        }
    }

    public class CatalogItemTypeNullableConverter : JsonConverter<CatalogItemType?>
    {
        /// <summary>
        /// Returns a CatalogItemType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override CatalogItemType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            if (rawValue == null)
                return null;

            CatalogItemType? result = CatalogItemTypeConverter.FromString(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="catalogItemType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, CatalogItemType? catalogItemType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(catalogItemType?.ToString() ?? "null");
        }
    }

}
