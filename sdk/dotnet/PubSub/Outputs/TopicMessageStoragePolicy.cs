// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.PubSub.Outputs
{

    [OutputType]
    public sealed class TopicMessageStoragePolicy
    {
        public readonly ImmutableArray<string> AllowedPersistenceRegions;

        [OutputConstructor]
        private TopicMessageStoragePolicy(ImmutableArray<string> allowedPersistenceRegions)
        {
            AllowedPersistenceRegions = allowedPersistenceRegions;
        }
    }
}
