// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisCommonConfiguration : IUtf8JsonSerializable, IJsonModel<RedisCommonConfiguration>
    {
        /// <summary> Specifies whether the rdb backup is enabled. </summary>
        [CodeGenMemberSerializationHooks(DeserializationValueHook = nameof(ReadIsRdbBackupEnabled))]
        public bool? IsRdbBackupEnabled { get; set; }

        /// <summary> Specifies whether the aof backup is enabled. </summary>
        [CodeGenMemberSerializationHooks(DeserializationValueHook = nameof(ReadIsAofBackupEnabled))]
        public bool? IsAofBackupEnabled { get; set; }

        /// <summary> Specifies the maximum number of snapshots for rdb backup. </summary>
        [CodeGenMemberSerializationHooks(SerializationValueHook = nameof(WriteRdbBackupMaxSnapshotCount), DeserializationValueHook = nameof(ReadRdbBackupMaxSnapshotCount))]
        public int? RdbBackupMaxSnapshotCount { get; set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void WriteRdbBackupMaxSnapshotCount(Utf8JsonWriter writer)
        {
            if (RdbBackupMaxSnapshotCount == null)
                return;
            writer.WriteStringValue(RdbBackupMaxSnapshotCount.Value.ToString(CultureInfo.InvariantCulture));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ReadIsRdbBackupEnabled(JsonProperty property, ref Optional<bool> IsRdbBackupEnabled)
        {
            if (property.Value.ValueKind == JsonValueKind.Null)
                return;

            IsRdbBackupEnabled = property.Value.ValueKind == JsonValueKind.String ? string.Equals(property.Value.GetString(), "true", StringComparison.InvariantCultureIgnoreCase) : property.Value.GetBoolean();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ReadIsAofBackupEnabled(JsonProperty property, ref Optional<bool> IsAofBackupEnabled)
        {
            if (property.Value.ValueKind == JsonValueKind.Null)
                return;

            IsAofBackupEnabled = property.Value.ValueKind == JsonValueKind.String ? string.Equals(property.Value.GetString(), "true", StringComparison.InvariantCultureIgnoreCase) : property.Value.GetBoolean();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ReadRdbBackupMaxSnapshotCount(JsonProperty property, ref Optional<int> RdbBackupMaxSnapshotCount)
        {
            if (property.Value.ValueKind == JsonValueKind.Null)
                return;

            if (!int.TryParse(property.Value.GetString(), out int rdbBackupMaxSnapshotCountValue))
            {
                throw new FormatException($"cannot parse {property.Value.GetString()} into an int for property {property.Name}");
            }
            RdbBackupMaxSnapshotCount = rdbBackupMaxSnapshotCountValue;
        }
    }
}
