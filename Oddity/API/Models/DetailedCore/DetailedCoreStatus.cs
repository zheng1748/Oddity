﻿using System.Runtime.Serialization;

namespace Oddity.API.Models.DetailedCore
{
    public enum DetailedCoreStatus
    {
        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "lost")]
        Lost,

        [EnumMember(Value = "inactive")]
        Inactive,

        [EnumMember(Value = "unknown")]
        Unknown
    }
}
