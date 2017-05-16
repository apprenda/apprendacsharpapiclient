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
    /// Application
    /// </summary>
    [DataContract]
    public partial class Application :  IEquatable<Application>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Alias">Alias.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CurrentVersion">CurrentVersion.</param>
        /// <param name="TransitioningVersion">TransitioningVersion.</param>
        /// <param name="UiAllocatedCpuMhz">UiAllocatedCpuMhz.</param>
        /// <param name="DbAllocatedCpuMhz">DbAllocatedCpuMhz.</param>
        /// <param name="SvcAllocatedCpuMhz">SvcAllocatedCpuMhz.</param>
        /// <param name="WarAllocatedCpuMhz">WarAllocatedCpuMhz.</param>
        /// <param name="LinuxServiceAllocatedCpuMhz">LinuxServiceAllocatedCpuMhz.</param>
        /// <param name="UiAllocatedMemoryMb">UiAllocatedMemoryMb.</param>
        /// <param name="DbAllocatedMemoryMb">DbAllocatedMemoryMb.</param>
        /// <param name="SvcAllocatedMemoryMb">SvcAllocatedMemoryMb.</param>
        /// <param name="WarAllocatedMemoryMb">WarAllocatedMemoryMb.</param>
        /// <param name="LinuxServiceAllocatedMemoryMb">LinuxServiceAllocatedMemoryMb.</param>
        /// <param name="AllocatedStorageMb">AllocatedStorageMb.</param>
        /// <param name="Href">Href.</param>
        public Application(string Name = default(string), string Alias = default(string), string Description = default(string), Version CurrentVersion = default(Version), Version TransitioningVersion = default(Version), long? UiAllocatedCpuMhz = default(long?), long? DbAllocatedCpuMhz = default(long?), long? SvcAllocatedCpuMhz = default(long?), long? WarAllocatedCpuMhz = default(long?), long? LinuxServiceAllocatedCpuMhz = default(long?), long? UiAllocatedMemoryMb = default(long?), long? DbAllocatedMemoryMb = default(long?), long? SvcAllocatedMemoryMb = default(long?), long? WarAllocatedMemoryMb = default(long?), long? LinuxServiceAllocatedMemoryMb = default(long?), long? AllocatedStorageMb = default(long?), string Href = default(string))
        {
            this.Name = Name;
            this.Alias = Alias;
            this.Description = Description;
            this.CurrentVersion = CurrentVersion;
            this.TransitioningVersion = TransitioningVersion;
            this.UiAllocatedCpuMhz = UiAllocatedCpuMhz;
            this.DbAllocatedCpuMhz = DbAllocatedCpuMhz;
            this.SvcAllocatedCpuMhz = SvcAllocatedCpuMhz;
            this.WarAllocatedCpuMhz = WarAllocatedCpuMhz;
            this.LinuxServiceAllocatedCpuMhz = LinuxServiceAllocatedCpuMhz;
            this.UiAllocatedMemoryMb = UiAllocatedMemoryMb;
            this.DbAllocatedMemoryMb = DbAllocatedMemoryMb;
            this.SvcAllocatedMemoryMb = SvcAllocatedMemoryMb;
            this.WarAllocatedMemoryMb = WarAllocatedMemoryMb;
            this.LinuxServiceAllocatedMemoryMb = LinuxServiceAllocatedMemoryMb;
            this.AllocatedStorageMb = AllocatedStorageMb;
            this.Href = Href;
        }
        
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
        /// Gets or Sets CurrentVersion
        /// </summary>
        [DataMember(Name="currentVersion", EmitDefaultValue=false)]
        public Version CurrentVersion { get; set; }
        /// <summary>
        /// Gets or Sets TransitioningVersion
        /// </summary>
        [DataMember(Name="transitioningVersion", EmitDefaultValue=false)]
        public Version TransitioningVersion { get; set; }
        /// <summary>
        /// Gets or Sets UiAllocatedCpuMhz
        /// </summary>
        [DataMember(Name="uiAllocatedCpuMhz", EmitDefaultValue=false)]
        public long? UiAllocatedCpuMhz { get; set; }
        /// <summary>
        /// Gets or Sets DbAllocatedCpuMhz
        /// </summary>
        [DataMember(Name="dbAllocatedCpuMhz", EmitDefaultValue=false)]
        public long? DbAllocatedCpuMhz { get; set; }
        /// <summary>
        /// Gets or Sets SvcAllocatedCpuMhz
        /// </summary>
        [DataMember(Name="svcAllocatedCpuMhz", EmitDefaultValue=false)]
        public long? SvcAllocatedCpuMhz { get; set; }
        /// <summary>
        /// Gets or Sets WarAllocatedCpuMhz
        /// </summary>
        [DataMember(Name="warAllocatedCpuMhz", EmitDefaultValue=false)]
        public long? WarAllocatedCpuMhz { get; set; }
        /// <summary>
        /// Gets or Sets LinuxServiceAllocatedCpuMhz
        /// </summary>
        [DataMember(Name="linuxServiceAllocatedCpuMhz", EmitDefaultValue=false)]
        public long? LinuxServiceAllocatedCpuMhz { get; set; }
        /// <summary>
        /// Gets or Sets UiAllocatedMemoryMb
        /// </summary>
        [DataMember(Name="uiAllocatedMemoryMb", EmitDefaultValue=false)]
        public long? UiAllocatedMemoryMb { get; set; }
        /// <summary>
        /// Gets or Sets DbAllocatedMemoryMb
        /// </summary>
        [DataMember(Name="dbAllocatedMemoryMb", EmitDefaultValue=false)]
        public long? DbAllocatedMemoryMb { get; set; }
        /// <summary>
        /// Gets or Sets SvcAllocatedMemoryMb
        /// </summary>
        [DataMember(Name="svcAllocatedMemoryMb", EmitDefaultValue=false)]
        public long? SvcAllocatedMemoryMb { get; set; }
        /// <summary>
        /// Gets or Sets WarAllocatedMemoryMb
        /// </summary>
        [DataMember(Name="warAllocatedMemoryMb", EmitDefaultValue=false)]
        public long? WarAllocatedMemoryMb { get; set; }
        /// <summary>
        /// Gets or Sets LinuxServiceAllocatedMemoryMb
        /// </summary>
        [DataMember(Name="linuxServiceAllocatedMemoryMb", EmitDefaultValue=false)]
        public long? LinuxServiceAllocatedMemoryMb { get; set; }
        /// <summary>
        /// Gets or Sets AllocatedStorageMb
        /// </summary>
        [DataMember(Name="allocatedStorageMb", EmitDefaultValue=false)]
        public long? AllocatedStorageMb { get; set; }
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
            sb.Append("class Application {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CurrentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  TransitioningVersion: ").Append(TransitioningVersion).Append("\n");
            sb.Append("  UiAllocatedCpuMhz: ").Append(UiAllocatedCpuMhz).Append("\n");
            sb.Append("  DbAllocatedCpuMhz: ").Append(DbAllocatedCpuMhz).Append("\n");
            sb.Append("  SvcAllocatedCpuMhz: ").Append(SvcAllocatedCpuMhz).Append("\n");
            sb.Append("  WarAllocatedCpuMhz: ").Append(WarAllocatedCpuMhz).Append("\n");
            sb.Append("  LinuxServiceAllocatedCpuMhz: ").Append(LinuxServiceAllocatedCpuMhz).Append("\n");
            sb.Append("  UiAllocatedMemoryMb: ").Append(UiAllocatedMemoryMb).Append("\n");
            sb.Append("  DbAllocatedMemoryMb: ").Append(DbAllocatedMemoryMb).Append("\n");
            sb.Append("  SvcAllocatedMemoryMb: ").Append(SvcAllocatedMemoryMb).Append("\n");
            sb.Append("  WarAllocatedMemoryMb: ").Append(WarAllocatedMemoryMb).Append("\n");
            sb.Append("  LinuxServiceAllocatedMemoryMb: ").Append(LinuxServiceAllocatedMemoryMb).Append("\n");
            sb.Append("  AllocatedStorageMb: ").Append(AllocatedStorageMb).Append("\n");
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
            return this.Equals(obj as Application);
        }

        /// <summary>
        /// Returns true if Application instances are equal
        /// </summary>
        /// <param name="other">Instance of Application to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Application other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.CurrentVersion == other.CurrentVersion ||
                    this.CurrentVersion != null &&
                    this.CurrentVersion.Equals(other.CurrentVersion)
                ) && 
                (
                    this.TransitioningVersion == other.TransitioningVersion ||
                    this.TransitioningVersion != null &&
                    this.TransitioningVersion.Equals(other.TransitioningVersion)
                ) && 
                (
                    this.UiAllocatedCpuMhz == other.UiAllocatedCpuMhz ||
                    this.UiAllocatedCpuMhz != null &&
                    this.UiAllocatedCpuMhz.Equals(other.UiAllocatedCpuMhz)
                ) && 
                (
                    this.DbAllocatedCpuMhz == other.DbAllocatedCpuMhz ||
                    this.DbAllocatedCpuMhz != null &&
                    this.DbAllocatedCpuMhz.Equals(other.DbAllocatedCpuMhz)
                ) && 
                (
                    this.SvcAllocatedCpuMhz == other.SvcAllocatedCpuMhz ||
                    this.SvcAllocatedCpuMhz != null &&
                    this.SvcAllocatedCpuMhz.Equals(other.SvcAllocatedCpuMhz)
                ) && 
                (
                    this.WarAllocatedCpuMhz == other.WarAllocatedCpuMhz ||
                    this.WarAllocatedCpuMhz != null &&
                    this.WarAllocatedCpuMhz.Equals(other.WarAllocatedCpuMhz)
                ) && 
                (
                    this.LinuxServiceAllocatedCpuMhz == other.LinuxServiceAllocatedCpuMhz ||
                    this.LinuxServiceAllocatedCpuMhz != null &&
                    this.LinuxServiceAllocatedCpuMhz.Equals(other.LinuxServiceAllocatedCpuMhz)
                ) && 
                (
                    this.UiAllocatedMemoryMb == other.UiAllocatedMemoryMb ||
                    this.UiAllocatedMemoryMb != null &&
                    this.UiAllocatedMemoryMb.Equals(other.UiAllocatedMemoryMb)
                ) && 
                (
                    this.DbAllocatedMemoryMb == other.DbAllocatedMemoryMb ||
                    this.DbAllocatedMemoryMb != null &&
                    this.DbAllocatedMemoryMb.Equals(other.DbAllocatedMemoryMb)
                ) && 
                (
                    this.SvcAllocatedMemoryMb == other.SvcAllocatedMemoryMb ||
                    this.SvcAllocatedMemoryMb != null &&
                    this.SvcAllocatedMemoryMb.Equals(other.SvcAllocatedMemoryMb)
                ) && 
                (
                    this.WarAllocatedMemoryMb == other.WarAllocatedMemoryMb ||
                    this.WarAllocatedMemoryMb != null &&
                    this.WarAllocatedMemoryMb.Equals(other.WarAllocatedMemoryMb)
                ) && 
                (
                    this.LinuxServiceAllocatedMemoryMb == other.LinuxServiceAllocatedMemoryMb ||
                    this.LinuxServiceAllocatedMemoryMb != null &&
                    this.LinuxServiceAllocatedMemoryMb.Equals(other.LinuxServiceAllocatedMemoryMb)
                ) && 
                (
                    this.AllocatedStorageMb == other.AllocatedStorageMb ||
                    this.AllocatedStorageMb != null &&
                    this.AllocatedStorageMb.Equals(other.AllocatedStorageMb)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.CurrentVersion != null)
                    hash = hash * 59 + this.CurrentVersion.GetHashCode();
                if (this.TransitioningVersion != null)
                    hash = hash * 59 + this.TransitioningVersion.GetHashCode();
                if (this.UiAllocatedCpuMhz != null)
                    hash = hash * 59 + this.UiAllocatedCpuMhz.GetHashCode();
                if (this.DbAllocatedCpuMhz != null)
                    hash = hash * 59 + this.DbAllocatedCpuMhz.GetHashCode();
                if (this.SvcAllocatedCpuMhz != null)
                    hash = hash * 59 + this.SvcAllocatedCpuMhz.GetHashCode();
                if (this.WarAllocatedCpuMhz != null)
                    hash = hash * 59 + this.WarAllocatedCpuMhz.GetHashCode();
                if (this.LinuxServiceAllocatedCpuMhz != null)
                    hash = hash * 59 + this.LinuxServiceAllocatedCpuMhz.GetHashCode();
                if (this.UiAllocatedMemoryMb != null)
                    hash = hash * 59 + this.UiAllocatedMemoryMb.GetHashCode();
                if (this.DbAllocatedMemoryMb != null)
                    hash = hash * 59 + this.DbAllocatedMemoryMb.GetHashCode();
                if (this.SvcAllocatedMemoryMb != null)
                    hash = hash * 59 + this.SvcAllocatedMemoryMb.GetHashCode();
                if (this.WarAllocatedMemoryMb != null)
                    hash = hash * 59 + this.WarAllocatedMemoryMb.GetHashCode();
                if (this.LinuxServiceAllocatedMemoryMb != null)
                    hash = hash * 59 + this.LinuxServiceAllocatedMemoryMb.GetHashCode();
                if (this.AllocatedStorageMb != null)
                    hash = hash * 59 + this.AllocatedStorageMb.GetHashCode();
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
