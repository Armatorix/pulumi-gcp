// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AccessContextManager.Outputs
{

    [OutputType]
    public sealed class AccessLevelBasicCondition
    {
        public readonly Outputs.AccessLevelBasicConditionDevicePolicy? DevicePolicy;
        public readonly ImmutableArray<string> IpSubnetworks;
        public readonly ImmutableArray<string> Members;
        public readonly bool? Negate;
        public readonly ImmutableArray<string> Regions;
        public readonly ImmutableArray<string> RequiredAccessLevels;

        [OutputConstructor]
        private AccessLevelBasicCondition(
            Outputs.AccessLevelBasicConditionDevicePolicy? devicePolicy,

            ImmutableArray<string> ipSubnetworks,

            ImmutableArray<string> members,

            bool? negate,

            ImmutableArray<string> regions,

            ImmutableArray<string> requiredAccessLevels)
        {
            DevicePolicy = devicePolicy;
            IpSubnetworks = ipSubnetworks;
            Members = members;
            Negate = negate;
            Regions = regions;
            RequiredAccessLevels = requiredAccessLevels;
        }
    }
}