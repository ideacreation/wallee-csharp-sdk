using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// The metric usage provides details about the consumption of a particular metric.
    /// </summary>
    [DataContract]
    public partial class MetricUsage :  IEquatable<MetricUsage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public MetricUsage()
        {
        }

        /// <summary>
        /// The consumed units provide the value of how much has been consumed of the particular metric.
        /// </summary>
        /// <value>The consumed units provide the value of how much has been consumed of the particular metric.</value>
        [DataMember(Name="consumedUnits", EmitDefaultValue=true)]
        public decimal? ConsumedUnits { get; private set; }

        /// <summary>
        /// The metric description describes the metric.
        /// </summary>
        /// <value>The metric description describes the metric.</value>
        [DataMember(Name="metricDescription", EmitDefaultValue=true)]
        public Dictionary<string, string> MetricDescription { get; private set; }

        /// <summary>
        /// The metric ID identifies the metric for consumed units.
        /// </summary>
        /// <value>The metric ID identifies the metric for consumed units.</value>
        [DataMember(Name="metricId", EmitDefaultValue=true)]
        public long? MetricId { get; private set; }

        /// <summary>
        /// The metric name defines the name of the consumed units.
        /// </summary>
        /// <value>The metric name defines the name of the consumed units.</value>
        [DataMember(Name="metricName", EmitDefaultValue=true)]
        public Dictionary<string, string> MetricName { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricUsage {\n");
            sb.Append("  ConsumedUnits: ").Append(ConsumedUnits).Append("\n");
            sb.Append("  MetricDescription: ").Append(MetricDescription).Append("\n");
            sb.Append("  MetricId: ").Append(MetricId).Append("\n");
            sb.Append("  MetricName: ").Append(MetricName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricUsage);
        }

        /// <summary>
        /// Returns true if MetricUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumedUnits == input.ConsumedUnits ||
                    (this.ConsumedUnits != null &&
                    this.ConsumedUnits.Equals(input.ConsumedUnits))
                ) && 
                (
                    this.MetricDescription == input.MetricDescription ||
                    this.MetricDescription != null &&
                    input.MetricDescription != null &&
                    this.MetricDescription.SequenceEqual(input.MetricDescription)
                ) && 
                (
                    this.MetricId == input.MetricId ||
                    (this.MetricId != null &&
                    this.MetricId.Equals(input.MetricId))
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    this.MetricName != null &&
                    input.MetricName != null &&
                    this.MetricName.SequenceEqual(input.MetricName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ConsumedUnits != null)
                    hashCode = hashCode * 59 + this.ConsumedUnits.GetHashCode();
                if (this.MetricDescription != null)
                    hashCode = hashCode * 59 + this.MetricDescription.GetHashCode();
                if (this.MetricId != null)
                    hashCode = hashCode * 59 + this.MetricId.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                return hashCode;
            }
        }

    }

}
