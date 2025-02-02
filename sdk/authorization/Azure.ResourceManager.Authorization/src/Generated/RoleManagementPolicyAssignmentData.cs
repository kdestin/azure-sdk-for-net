// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing the RoleManagementPolicyAssignment data model.
    /// Role management policy
    /// </summary>
    public partial class RoleManagementPolicyAssignmentData : ResourceData
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RoleManagementPolicyAssignmentData"/>. </summary>
        public RoleManagementPolicyAssignmentData()
        {
            EffectiveRules = new ChangeTrackingList<RoleManagementPolicyRule>();
        }

        /// <summary> Initializes a new instance of <see cref="RoleManagementPolicyAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope"> The role management policy scope. </param>
        /// <param name="roleDefinitionId"> The role definition of management policy assignment. </param>
        /// <param name="policyId"> The policy id role management policy assignment. </param>
        /// <param name="effectiveRules">
        /// The readonly computed rule applied to the policy.
        /// Please note <see cref="RoleManagementPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RoleManagementPolicyApprovalRule"/>, <see cref="RoleManagementPolicyAuthenticationContextRule"/>, <see cref="RoleManagementPolicyEnablementRule"/>, <see cref="RoleManagementPolicyExpirationRule"/> and <see cref="RoleManagementPolicyNotificationRule"/>.
        /// </param>
        /// <param name="policyAssignmentProperties"> Additional properties of scope, role definition and policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleManagementPolicyAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string scope, ResourceIdentifier roleDefinitionId, ResourceIdentifier policyId, IReadOnlyList<RoleManagementPolicyRule> effectiveRules, PolicyAssignmentProperties policyAssignmentProperties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PolicyId = policyId;
            EffectiveRules = effectiveRules;
            PolicyAssignmentProperties = policyAssignmentProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The role management policy scope. </summary>
        public string Scope { get; set; }
        /// <summary> The role definition of management policy assignment. </summary>
        public ResourceIdentifier RoleDefinitionId { get; set; }
        /// <summary> The policy id role management policy assignment. </summary>
        public ResourceIdentifier PolicyId { get; set; }
        /// <summary>
        /// The readonly computed rule applied to the policy.
        /// Please note <see cref="RoleManagementPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RoleManagementPolicyApprovalRule"/>, <see cref="RoleManagementPolicyAuthenticationContextRule"/>, <see cref="RoleManagementPolicyEnablementRule"/>, <see cref="RoleManagementPolicyExpirationRule"/> and <see cref="RoleManagementPolicyNotificationRule"/>.
        /// </summary>
        public IReadOnlyList<RoleManagementPolicyRule> EffectiveRules { get; }
        /// <summary> Additional properties of scope, role definition and policy. </summary>
        public PolicyAssignmentProperties PolicyAssignmentProperties { get; }
    }
}
