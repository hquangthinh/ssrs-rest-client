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
    /// An object that contains information about the Report Server user.
    /// </summary>
    public partial class User : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="displayName">A string value that specifies the name to display for the network user.</param>
        /// <param name="hasFavoriteItems">A boolean value that indicates whether the user has items that are designated as favorite items.</param>
        /// <param name="id">A unique UUID value that specifies the identifier by which this User object can be referenced in requests or in other defined objects.</param>
        /// <param name="myReportsPath">A string value that specifies a path to a folder where a user&#39;s reports are stored by default. (This feature must be enabled by the server administrator).</param>
        /// <param name="username">A string value that specifies the network user name for the user.</param>
        [JsonConstructor]
        public User(string displayName, bool hasFavoriteItems, Guid id, string myReportsPath, string username)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (id == null)
                throw new ArgumentNullException("id is a required property for User and cannot be null.");

            if (username == null)
                throw new ArgumentNullException("username is a required property for User and cannot be null.");

            if (displayName == null)
                throw new ArgumentNullException("displayName is a required property for User and cannot be null.");

            if (hasFavoriteItems == null)
                throw new ArgumentNullException("hasFavoriteItems is a required property for User and cannot be null.");

            if (myReportsPath == null)
                throw new ArgumentNullException("myReportsPath is a required property for User and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            DisplayName = displayName;
            HasFavoriteItems = hasFavoriteItems;
            Id = id;
            MyReportsPath = myReportsPath;
            Username = username;
        }

        /// <summary>
        /// A string value that specifies the name to display for the network user.
        /// </summary>
        /// <value>A string value that specifies the name to display for the network user.</value>
        [JsonPropertyName("DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// A boolean value that indicates whether the user has items that are designated as favorite items.
        /// </summary>
        /// <value>A boolean value that indicates whether the user has items that are designated as favorite items.</value>
        [JsonPropertyName("HasFavoriteItems")]
        public bool HasFavoriteItems { get; set; }

        /// <summary>
        /// A unique UUID value that specifies the identifier by which this User object can be referenced in requests or in other defined objects.
        /// </summary>
        /// <value>A unique UUID value that specifies the identifier by which this User object can be referenced in requests or in other defined objects.</value>
        [JsonPropertyName("Id")]
        public Guid Id { get; set; }

        /// <summary>
        /// A string value that specifies a path to a folder where a user&#39;s reports are stored by default. (This feature must be enabled by the server administrator).
        /// </summary>
        /// <value>A string value that specifies a path to a folder where a user&#39;s reports are stored by default. (This feature must be enabled by the server administrator).</value>
        [JsonPropertyName("MyReportsPath")]
        public string MyReportsPath { get; set; }

        /// <summary>
        /// A string value that specifies the network user name for the user.
        /// </summary>
        /// <value>A string value that specifies the network user name for the user.</value>
        [JsonPropertyName("Username")]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  HasFavoriteItems: ").Append(HasFavoriteItems).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MyReportsPath: ").Append(MyReportsPath).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
    /// A Json converter for type User
    /// </summary>
    public class UserJsonConverter : JsonConverter<User>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override User Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string displayName = default;
            bool hasFavoriteItems = default;
            Guid id = default;
            string myReportsPath = default;
            string username = default;

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
                        case "DisplayName":
                            displayName = utf8JsonReader.GetString();
                            break;
                        case "HasFavoriteItems":
                            hasFavoriteItems = utf8JsonReader.GetBoolean();
                            break;
                        case "Id":
                            id = utf8JsonReader.GetGuid();
                            break;
                        case "MyReportsPath":
                            myReportsPath = utf8JsonReader.GetString();
                            break;
                        case "Username":
                            username = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new User(displayName, hasFavoriteItems, id, myReportsPath, username);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="user"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, User user, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("DisplayName", user.DisplayName);
            writer.WriteBoolean("HasFavoriteItems", user.HasFavoriteItems);
            writer.WriteString("Id", user.Id);
            writer.WriteString("MyReportsPath", user.MyReportsPath);
            writer.WriteString("Username", user.Username);

            writer.WriteEndObject();
        }
    }
}