/* 
 * Apprenda.DeveloperPortal.Web
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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

namespace IO.Swagger.Model
{
    /// <summary>
    /// EnhancedAddOn
    /// </summary>
    [DataContract]
    public partial class EnhancedAddOn :  IEquatable<EnhancedAddOn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancedAddOn" /> class.
        /// </summary>
        /// <param name="DeployedInstances">DeployedInstances.</param>
        /// <param name="ManifestVersion">ManifestVersion.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Alias">Alias.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Author">Author.</param>
        /// <param name="Vendor">Vendor.</param>
        /// <param name="DeveloperHelp">DeveloperHelp.</param>
        /// <param name="DeploymentNotes">DeploymentNotes.</param>
        /// <param name="MaxInstancesPerDevTeam">MaxInstancesPerDevTeam.</param>
        /// <param name="AllowUserDefinedParameters">AllowUserDefinedParameters.</param>
        /// <param name="Parameters">Parameters.</param>
        /// <param name="Instances">Instances.</param>
        /// <param name="Icon">Icon.</param>
        /// <param name="Href">Href.</param>
        public EnhancedAddOn(List<DeployedAddOnReference> DeployedInstances = default(List<DeployedAddOnReference>), int? ManifestVersion = default(int?), string Name = default(string), string Alias = default(string), string Description = default(string), string Version = default(string), string Author = default(string), string Vendor = default(string), string DeveloperHelp = default(string), string DeploymentNotes = default(string), int? MaxInstancesPerDevTeam = default(int?), bool? AllowUserDefinedParameters = default(bool?), List<AddOnParameterDefinition> Parameters = default(List<AddOnParameterDefinition>), AddOnInstancesContainer Instances = default(AddOnInstancesContainer), ResourceBase Icon = default(ResourceBase), string Href = default(string))
        {
            this.DeployedInstances = DeployedInstances;
            this.ManifestVersion = ManifestVersion;
            this.Name = Name;
            this.Alias = Alias;
            this.Description = Description;
            this.Version = Version;
            this.Author = Author;
            this.Vendor = Vendor;
            this.DeveloperHelp = DeveloperHelp;
            this.DeploymentNotes = DeploymentNotes;
            this.MaxInstancesPerDevTeam = MaxInstancesPerDevTeam;
            this.AllowUserDefinedParameters = AllowUserDefinedParameters;
            this.Parameters = Parameters;
            this.Instances = Instances;
            this.Icon = Icon;
            this.Href = Href;
        }
        
        /// <summary>
        /// Gets or Sets DeployedInstances
        /// </summary>
        [DataMember(Name="deployedInstances", EmitDefaultValue=false)]
        public List<DeployedAddOnReference> DeployedInstances { get; set; }
        /// <summary>
        /// Gets or Sets ManifestVersion
        /// </summary>
        [DataMember(Name="manifestVersion", EmitDefaultValue=false)]
        public int? ManifestVersion { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public string Author { get; set; }
        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name="vendor", EmitDefaultValue=false)]
        public string Vendor { get; set; }
        /// <summary>
        /// Gets or Sets DeveloperHelp
        /// </summary>
        [DataMember(Name="developerHelp", EmitDefaultValue=false)]
        public string DeveloperHelp { get; set; }
        /// <summary>
        /// Gets or Sets DeploymentNotes
        /// </summary>
        [DataMember(Name="deploymentNotes", EmitDefaultValue=false)]
        public string DeploymentNotes { get; set; }
        /// <summary>
        /// Gets or Sets MaxInstancesPerDevTeam
        /// </summary>
        [DataMember(Name="maxInstancesPerDevTeam", EmitDefaultValue=false)]
        public int? MaxInstancesPerDevTeam { get; set; }
        /// <summary>
        /// Gets or Sets AllowUserDefinedParameters
        /// </summary>
        [DataMember(Name="allowUserDefinedParameters", EmitDefaultValue=false)]
        public bool? AllowUserDefinedParameters { get; set; }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<AddOnParameterDefinition> Parameters { get; set; }
        /// <summary>
        /// Gets or Sets Instances
        /// </summary>
        [DataMember(Name="instances", EmitDefaultValue=false)]
        public AddOnInstancesContainer Instances { get; set; }
        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public ResourceBase Icon { get; set; }
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnhancedAddOn {\n");
            sb.Append("  DeployedInstances: ").Append(DeployedInstances).Append("\n");
            sb.Append("  ManifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  DeveloperHelp: ").Append(DeveloperHelp).Append("\n");
            sb.Append("  DeploymentNotes: ").Append(DeploymentNotes).Append("\n");
            sb.Append("  MaxInstancesPerDevTeam: ").Append(MaxInstancesPerDevTeam).Append("\n");
            sb.Append("  AllowUserDefinedParameters: ").Append(AllowUserDefinedParameters).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EnhancedAddOn);
        }

        /// <summary>
        /// Returns true if EnhancedAddOn instances are equal
        /// </summary>
        /// <param name="other">Instance of EnhancedAddOn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnhancedAddOn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeployedInstances == other.DeployedInstances ||
                    this.DeployedInstances != null &&
                    this.DeployedInstances.SequenceEqual(other.DeployedInstances)
                ) && 
                (
                    this.ManifestVersion == other.ManifestVersion ||
                    this.ManifestVersion != null &&
                    this.ManifestVersion.Equals(other.ManifestVersion)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Alias == other.Alias ||
                    this.Alias != null &&
                    this.Alias.Equals(other.Alias)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.Vendor == other.Vendor ||
                    this.Vendor != null &&
                    this.Vendor.Equals(other.Vendor)
                ) && 
                (
                    this.DeveloperHelp == other.DeveloperHelp ||
                    this.DeveloperHelp != null &&
                    this.DeveloperHelp.Equals(other.DeveloperHelp)
                ) && 
                (
                    this.DeploymentNotes == other.DeploymentNotes ||
                    this.DeploymentNotes != null &&
                    this.DeploymentNotes.Equals(other.DeploymentNotes)
                ) && 
                (
                    this.MaxInstancesPerDevTeam == other.MaxInstancesPerDevTeam ||
                    this.MaxInstancesPerDevTeam != null &&
                    this.MaxInstancesPerDevTeam.Equals(other.MaxInstancesPerDevTeam)
                ) && 
                (
                    this.AllowUserDefinedParameters == other.AllowUserDefinedParameters ||
                    this.AllowUserDefinedParameters != null &&
                    this.AllowUserDefinedParameters.Equals(other.AllowUserDefinedParameters)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.Instances == other.Instances ||
                    this.Instances != null &&
                    this.Instances.Equals(other.Instances)
                ) && 
                (
                    this.Icon == other.Icon ||
                    this.Icon != null &&
                    this.Icon.Equals(other.Icon)
                ) && 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DeployedInstances != null)
                    hash = hash * 59 + this.DeployedInstances.GetHashCode();
                if (this.ManifestVersion != null)
                    hash = hash * 59 + this.ManifestVersion.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
                if (this.DeveloperHelp != null)
                    hash = hash * 59 + this.DeveloperHelp.GetHashCode();
                if (this.DeploymentNotes != null)
                    hash = hash * 59 + this.DeploymentNotes.GetHashCode();
                if (this.MaxInstancesPerDevTeam != null)
                    hash = hash * 59 + this.MaxInstancesPerDevTeam.GetHashCode();
                if (this.AllowUserDefinedParameters != null)
                    hash = hash * 59 + this.AllowUserDefinedParameters.GetHashCode();
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                if (this.Instances != null)
                    hash = hash * 59 + this.Instances.GetHashCode();
                if (this.Icon != null)
                    hash = hash * 59 + this.Icon.GetHashCode();
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
