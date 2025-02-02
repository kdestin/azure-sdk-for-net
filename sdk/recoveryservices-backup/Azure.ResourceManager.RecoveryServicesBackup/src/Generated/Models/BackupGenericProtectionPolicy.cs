// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Base class for backup policy. Workload-specific backup policies are derived from this class.
    /// Please note <see cref="BackupGenericProtectionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="IaasVmProtectionPolicy"/>, <see cref="SqlProtectionPolicy"/>, <see cref="FileShareProtectionPolicy"/>, <see cref="VmWorkloadProtectionPolicy"/>, <see cref="GenericProtectionPolicy"/> and <see cref="MabProtectionPolicy"/>.
    /// </summary>
    public abstract partial class BackupGenericProtectionPolicy
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupGenericProtectionPolicy"/>. </summary>
        protected BackupGenericProtectionPolicy()
        {
            ResourceGuardOperationRequests = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BackupGenericProtectionPolicy"/>. </summary>
        /// <param name="protectedItemsCount"> Number of items associated with this policy. </param>
        /// <param name="backupManagementType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuard Operation Requests. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupGenericProtectionPolicy(int? protectedItemsCount, string backupManagementType, IList<string> resourceGuardOperationRequests, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProtectedItemsCount = protectedItemsCount;
            BackupManagementType = backupManagementType;
            ResourceGuardOperationRequests = resourceGuardOperationRequests;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Number of items associated with this policy. </summary>
        public int? ProtectedItemsCount { get; set; }
        /// <summary> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </summary>
        internal string BackupManagementType { get; set; }
        /// <summary> ResourceGuard Operation Requests. </summary>
        public IList<string> ResourceGuardOperationRequests { get; }
    }
}
