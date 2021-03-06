// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Backup.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties for restore options.
    /// </summary>
    public partial class RestoreOptions
    {
        /// <summary>
        /// Initializes a new instance of the RestoreOptions class.
        /// </summary>
        public RestoreOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestoreOptions class.
        /// </summary>
        /// <param name="roleName">The Azure Stack role name for restore, set
        /// it to empty for all infrastructure role</param>
        /// <param name="decryptionCertBase64">The certificate file raw data in
        /// Base64 string. This should be the .pfx file with the private
        /// key.</param>
        /// <param name="decryptionCertPassword">The password for the
        /// decryption certificate.</param>
        public RestoreOptions(string roleName = default(string), string decryptionCertBase64 = default(string), string decryptionCertPassword = default(string))
        {
            RoleName = roleName;
            DecryptionCertBase64 = decryptionCertBase64;
            DecryptionCertPassword = decryptionCertPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Stack role name for restore, set it to empty
        /// for all infrastructure role
        /// </summary>
        [JsonProperty(PropertyName = "roleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets the certificate file raw data in Base64 string. This
        /// should be the .pfx file with the private key.
        /// </summary>
        [JsonProperty(PropertyName = "decryptionCertBase64")]
        public string DecryptionCertBase64 { get; set; }

        /// <summary>
        /// Gets or sets the password for the decryption certificate.
        /// </summary>
        [JsonProperty(PropertyName = "decryptionCertPassword")]
        public string DecryptionCertPassword { get; set; }

    }
}
