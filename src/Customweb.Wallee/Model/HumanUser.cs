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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Human User
    /// </summary>
    [DataContract]
    public partial class HumanUser :  IEquatable<HumanUser>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public HumanUser()
        {
        }

        /// <summary>
        /// The email address of the user.
        /// </summary>
        /// <value>The email address of the user.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; private set; }

        /// <summary>
        /// Defines whether a user is verified or not.
        /// </summary>
        /// <value>Defines whether a user is verified or not.</value>
        [DataMember(Name="emailAddressVerified", EmitDefaultValue=false)]
        public bool? EmailAddressVerified { get; private set; }

        /// <summary>
        /// The first name of the user.
        /// </summary>
        /// <value>The first name of the user.</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; private set; }

        /// <summary>
        /// The preferred language of the user.
        /// </summary>
        /// <value>The preferred language of the user.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        /// <value>The last name of the user.</value>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; private set; }

        /// <summary>
        /// MobilePhoneNumber
        /// </summary>
        /// <value>MobilePhoneNumber</value>
        [DataMember(Name="mobilePhoneNumber", EmitDefaultValue=false)]
        public string MobilePhoneNumber { get; private set; }

        /// <summary>
        /// Defines whether a users mobile phone number is verified or not.
        /// </summary>
        /// <value>Defines whether a users mobile phone number is verified or not.</value>
        [DataMember(Name="mobilePhoneVerified", EmitDefaultValue=false)]
        public bool? MobilePhoneVerified { get; private set; }

        /// <summary>
        /// The primary account links the user to a specific account.
        /// </summary>
        /// <value>The primary account links the user to a specific account.</value>
        [DataMember(Name="primaryAccount", EmitDefaultValue=false)]
        public Account PrimaryAccount { get; private set; }

        /// <summary>
        /// The scope to which the user belongs to.
        /// </summary>
        /// <value>The scope to which the user belongs to.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public Scope Scope { get; private set; }

        /// <summary>
        /// The time zone which is applied for the user. If no timezone is specified the browser is used to determine an appropriate time zone.
        /// </summary>
        /// <value>The time zone which is applied for the user. If no timezone is specified the browser is used to determine an appropriate time zone.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// Defines whether two-factor authentication is enabled for this user.
        /// </summary>
        /// <value>Defines whether two-factor authentication is enabled for this user.</value>
        [DataMember(Name="twoFactorEnabled", EmitDefaultValue=false)]
        public bool? TwoFactorEnabled { get; private set; }

        /// <summary>
        /// TwoFactorType
        /// </summary>
        /// <value>TwoFactorType</value>
        [DataMember(Name="twoFactorType", EmitDefaultValue=false)]
        public TwoFactorAuthenticationType TwoFactorType { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
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
            return this.Equals(obj as HumanUser);
        }

        /// <summary>
        /// Returns true if HumanUser instances are equal
        /// </summary>
        /// <param name="other">Instance of HumanUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HumanUser other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.EmailAddressVerified == other.EmailAddressVerified ||
                    this.EmailAddressVerified != null &&
                    this.EmailAddressVerified.Equals(other.EmailAddressVerified)
                ) && 
                (
                    this.Firstname == other.Firstname ||
                    this.Firstname != null &&
                    this.Firstname.Equals(other.Firstname)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Lastname == other.Lastname ||
                    this.Lastname != null &&
                    this.Lastname.Equals(other.Lastname)
                ) && 
                (
                    this.MobilePhoneNumber == other.MobilePhoneNumber ||
                    this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(other.MobilePhoneNumber)
                ) && 
                (
                    this.MobilePhoneVerified == other.MobilePhoneVerified ||
                    this.MobilePhoneVerified != null &&
                    this.MobilePhoneVerified.Equals(other.MobilePhoneVerified)
                ) && 
                (
                    this.PrimaryAccount == other.PrimaryAccount ||
                    this.PrimaryAccount != null &&
                    this.PrimaryAccount.Equals(other.PrimaryAccount)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.TwoFactorEnabled == other.TwoFactorEnabled ||
                    this.TwoFactorEnabled != null &&
                    this.TwoFactorEnabled.Equals(other.TwoFactorEnabled)
                ) && 
                (
                    this.TwoFactorType == other.TwoFactorType ||
                    this.TwoFactorType != null &&
                    this.TwoFactorType.Equals(other.TwoFactorType)
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
                int hash = 41;
                if (this.EmailAddress != null)
                {
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                }
                if (this.EmailAddressVerified != null)
                {
                    hash = hash * 59 + this.EmailAddressVerified.GetHashCode();
                }
                if (this.Firstname != null)
                {
                    hash = hash * 59 + this.Firstname.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.Lastname != null)
                {
                    hash = hash * 59 + this.Lastname.GetHashCode();
                }
                if (this.MobilePhoneNumber != null)
                {
                    hash = hash * 59 + this.MobilePhoneNumber.GetHashCode();
                }
                if (this.MobilePhoneVerified != null)
                {
                    hash = hash * 59 + this.MobilePhoneVerified.GetHashCode();
                }
                if (this.PrimaryAccount != null)
                {
                    hash = hash * 59 + this.PrimaryAccount.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hash = hash * 59 + this.Scope.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                }
                if (this.TwoFactorEnabled != null)
                {
                    hash = hash * 59 + this.TwoFactorEnabled.GetHashCode();
                }
                if (this.TwoFactorType != null)
                {
                    hash = hash * 59 + this.TwoFactorType.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
